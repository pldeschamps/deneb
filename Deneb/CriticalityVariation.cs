using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deneb
{
    [Serializable]
    public class CriticalityVariation  
    {
        public double length { get; set; } // durée de la variation (positive, en secondes)
        public double variation { get; set; } // Variation de la réactivité (positive ou négative, en pcm)
        public CriticalityVariation()
        {
            length = 0;
            variation = 0;
        }
        public CriticalityVariation(double _length, double _variation)
        {
            length = Math.Abs(_length);
            variation = _variation;
        }
    }
}

