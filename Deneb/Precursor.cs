using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;
using System.Runtime.Serialization;

namespace Deneb
{
    [Serializable]
    class Precursor
    {
        private double beta;
        private double tau;
        private double lambda;
        public bool active;
        public double population;
        [NonSerialized]
        public List<DataPoint> populationAtEveryStep;

        public double Beta
        {
            get { return beta; }
        }
        public double Tau
        {
            get { return tau; }
        }
        public double Lambda
        {
            get { return lambda; }
        }

        public Precursor(double beta, double tau)
        {
            defineBetaTau(beta, tau);
            active = true;
        }
        public Precursor(double betaPcm,double tau, bool active)
        {
            defineBetaTau(betaPcm, tau);
            this.active = active;
        }

        private void defineBetaTau(double betaPcm, double tau)
        {
            this.beta = betaPcm / 100000;
            this.tau = tau;
            try
            {
                lambda = Math.Log(2) / tau;
            }
            catch (Exception e)
            {
                Console.Error.WriteLine(e.ToString());
                throw;
            }
            populationAtEveryStep = new List<DataPoint>();
        }
        [OnDeserialized]
        private void OnDeserializedMethod(StreamingContext context)
        {
            populationAtEveryStep = new List<DataPoint>();
        }
    }
}
