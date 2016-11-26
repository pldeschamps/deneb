using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deneb
{
    public class CriticalityVariationsEventArgs : EventArgs
    {
        private CriticalityVariations criticalityVariationsUpdated;
        public CriticalityVariationsEventArgs(CriticalityVariations e)
        {
            criticalityVariationsUpdated = e;
        }
        public CriticalityVariations CriticalityVariationsUpdated
        {
            get { return criticalityVariationsUpdated; }
        }
    }
}
