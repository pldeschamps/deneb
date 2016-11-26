using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deneb
{
    [Serializable]
    class ExperimentSerializedData
    {
        public CriticalityVariations criticalityVariations { get; set; }
        public Precursors precursors { get; set; }
        public ExperimentSerializedData(CriticalityVariations cvs, Precursors ps)
        {
            this.criticalityVariations = cvs;
            this.precursors = ps;
        }

    }
}
