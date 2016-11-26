using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deneb
{
    // β, λ et l * considérés constants pour transitoires (quelques minutes) 
    // usure combustible négligée 
    [Serializable]
    class Precursors
    {
        private List<Precursor> items;

        internal List<Precursor> Items
        {
            get { return items; }
        }

        private Precursor globalPrecursor;

        public Precursors(bool uranium)
        {
            items = new List<Precursor>();

            // Valeur par défaut pour le constructeur vide 
            // Les 6 groupes classiques pour l'U235
            this.add(new Precursor(24.5, 55.7));
            this.add(new Precursor(142.4, 15.9));
            this.add(new Precursor(127.4, 6));
            this.add(new Precursor(256.8, 2));
            this.add(new Precursor(74.8, 0.8));
            this.add(new Precursor(27.3, 0.2));
        }
        public Precursors()
        {
            items = new List<Precursor>();
        }
        public Precursors(Precursors precursors)
        {
            items = new List<Precursor>();
            foreach (Precursor p in precursors.Items)
            {
                this.add(p);
            }
        }

        public Precursor GlobalPrecursor
        {
            get { return globalPrecursor; }
        }

        public void add(Precursor p)
        {
            items.Add(p);
            calculateGlobalPrecursor();
        }

        // modification des propriétés des précurseurs

        private void calculateGlobalPrecursor()
        {
            double sigma = 0;   //Somme des beta_i * tau_i
            double globalBeta = 0;
            double globalTau;

            foreach (Precursor p in items)
            {
                if (p.active)
                {
                    globalBeta += p.Beta;
                    sigma += p.Tau * p.Beta;
                }
            }

            if (globalBeta ==0)
            {
                globalTau = 0;
            }
            else
            {
                globalTau = sigma / globalBeta  ;
            }

            globalPrecursor = new Precursor(globalBeta*100000, globalTau);
        }
        public void clearPopulations()
        {
            foreach (Precursor p in items)
                p.populationAtEveryStep.Clear();
            if (globalPrecursor!=null)
                globalPrecursor.populationAtEveryStep.Clear();
        }
        
    }
}
