using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Deneb
{
    /* Géraud,
     * Il faudrait faire hériter cette classe de Point, cela allègerait le code de CriticalityVariationsPoints
     * En effet, nous pourrions écrire :
     * p.X plutôt que p.PanelPoint.X
     */
    //[Serializable]
    class PhysicalAndPanelPoint
    {
 
        public double PhysicalY { get; set; }
        public double PhysicalX { get; set; }
        public Point PanelPoint { get; set; }
 
        public PhysicalAndPanelPoint(double x, double y, Point panelPoint)
        {
            PhysicalX=x;
            PhysicalY = y;
            PanelPoint = panelPoint;
        }
        public PhysicalAndPanelPoint(Point panelPoint)
        {
            PhysicalX = 0;
            PhysicalY = 0;
            PanelPoint = panelPoint;
        }

    }
}
