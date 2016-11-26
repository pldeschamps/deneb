using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Forms;

namespace Deneb
{
    class Reactor
    {
        private double timeSpan;
        private CriticalityVariations cv;
        private Precursors precursors;
        private bool balancedPrecursorAtStartup;
        private double initialNeutronPop;
        private double source;  // Neutron Source : neutron per second (n/s)
        //private double _l;  // Durée de vie l (10-4 pour thermique, 10-6 pour rapides) 
        private double lStar; // temps de génération 
        public List<DataPoint> timeSteps;
        public List<DataPoint> populationAtEveryStep;
        const int maxDataPoints = 100000; 

        public Reactor(CriticalityVariations cv, Precursors p, Double n, Double s, Double lStar)
        {
            this.cv = cv;
            this.precursors = p;
            this.balancedPrecursorAtStartup = true;
            this.initialNeutronPop = n;
            this.timeSpan = cv.TimeSpan;
            this.source = s;
            this.lStar = lStar;
            this.timeSteps = new List<DataPoint>();
            this.populationAtEveryStep = new List<DataPoint>();
            this.populationAtEveryStep.Add(new DataPoint(0, n)); //initialise ne nombre de neutrons à n à l'instant 0 secondes
            calculatePopulations();
        }

        public Reactor(CriticalityVariations cv, Precursors p) : this(cv, p, 1, 1, 0.0001)
        { }

        private void calculatePopulations()
        {
            const double hInitial = 0.01;       // incrément par défaut
            const double hMax = 0.1;            // incrément max
            const double hMin = 0.000001;
            const double epsilonDividedByN = 0.01;    // epsilon / n : erreur acceptable dans le calcul de n par la méthode d'Euler explicite
            double t;
            double h;//incrément de temps de la méthode d'Euler explicite
            long i; // index des tableaux
            double n;
            double dn;
            double sumLambdasDPop;//Somme des lambda * dPop/dt (ou lambda_i * dc_i/dt)
            double d2ndt2; // d²n/dt²
            double new_h; // h calculé
            n = initialNeutronPop;
#if DEBUG
            double hMinCalculated=0;
#endif
            //réinitialisation des populations de précurseurs
            precursors.clearPopulations();
            // Calcul des populations de précurseur à l'équilibre 
            if (balancedPrecursorAtStartup)
            {
                foreach (Precursor p in precursors.Items)
                {
                    if(p.active)
                        p.population = n * p.Beta / (lStar * p.Lambda);
                }
            }
            else
            {
                foreach (Precursor p in precursors.Items) p.population = 0;
            }
            h = hInitial; // timestep initial
            i = 0;
            // Début du calcul des populations
            // Méthode d'Euler explicite
            for (t = 0; (t < timeSpan && i < maxDataPoints && h > hMin) ; t += h)
            {
                try
                {
                    // on calcule la variation de n
                    this.populationAtEveryStep.Add(new DataPoint(t, n));
                    dn = n * (cv.criticality(t) - precursors.GlobalPrecursor.Beta) / lStar;    // fissions
                    dn += source;                                                            // source neutronique
                    foreach (Precursor p in precursors.Items)
                        if (p.active)
                            dn += p.Lambda * p.population;     // précurseurs
                    n += dn * h;
                    // on calcule la variation des populations de précurseurs
                    precursors.GlobalPrecursor.populationAtEveryStep.Add(new DataPoint(t, precursors.GlobalPrecursor.population));
                    precursors.GlobalPrecursor.population = 0;
                    sumLambdasDPop = 0;
                    foreach (Precursor p in precursors.Items)
                        if (p.active)
                        {
                            p.populationAtEveryStep.Add(new DataPoint(t, p.population));
                            p.population += h * (n * p.Beta / lStar - p.Lambda * p.population);
                            precursors.GlobalPrecursor.population += p.population;
                        }
                    // on calcule l'incrément de temps pour le pas suivant
                    // h² < 2.ε.d²n/dt²
                    h = hInitial;
                    // calcul de dn
                    dn = n * (cv.criticality(t + h) - precursors.GlobalPrecursor.Beta) / lStar + source;
                    foreach (Precursor p in precursors.Items)
                        if(p.active)
                            dn += p.Lambda * p.population;
                    // calcul de Σ λi.dci/dt
                    sumLambdasDPop = 0;
                    foreach (Precursor p in precursors.Items)
                        if(p.active)
                            sumLambdasDPop += p.Lambda * n * p.Beta / lStar - p.Lambda * p.population;
                    d2ndt2 = dn * (cv.criticality(t + h) - precursors.GlobalPrecursor.Beta) / lStar + sumLambdasDPop;
                    //TODO : gestion des exceptions
                    if (d2ndt2 != 0)
                    {
                        new_h = Math.Sqrt(Math.Abs(epsilonDividedByN * initialNeutronPop / d2ndt2));
                    }
                    else
                    {
                        new_h = hInitial;
                    }
#if DEBUG
                    hMinCalculated = Math.Min(new_h, h);
#endif
                    h = Math.Min(new_h, hMax);
                    //h = Math.Max(h, hMin);
                    timeSteps.Add(new DataPoint(t, h));
                    i++;
#if DEBUG
                    //Console.WriteLine(i.ToString());
#endif          
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            if (h < hMin)
                MessageBox.Show("Time step became too low : d²n/dt² was too high.");
            if (i == maxDataPoints)
                MessageBox.Show("There were too many calculation steps. Calculation stopped.");
            // Ajout de la dernière valeur, à t = timespan
            this.populationAtEveryStep.Add(new DataPoint(timeSpan, n));
            precursors.GlobalPrecursor.populationAtEveryStep.Add(new DataPoint(timeSpan, precursors.GlobalPrecursor.population));
            foreach (Precursor p in precursors.Items)
                if (p.active)
                    p.populationAtEveryStep.Add(new DataPoint(timeSpan, p.population));
#if DEBUG
            //Console.WriteLine(hMinCalculated.ToString());
#endif
        }
    }
}
