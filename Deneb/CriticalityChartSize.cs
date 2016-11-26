using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Deneb
{
    //[Serializable]
    class CriticalityChartSize
    {
        public Point LeftTopMargins { get; set; }
        public Point RightBottomMargins { get; set; }
        public Size PanelSize { get; set; }
        public CriticalityChartSize(Size panelSize, Point leftTopMargins, Point rightBottomMargins)
        {
            PanelSize = panelSize;
            LeftTopMargins = leftTopMargins;
            RightBottomMargins = rightBottomMargins;
        }
        public Size ChartSize
        {
            get
            {
                return new Size(
                    Math.Max((int)(PanelSize.Width - LeftTopMargins.X - RightBottomMargins.X), 0),
                    Math.Max(PanelSize.Height - LeftTopMargins.Y - RightBottomMargins.Y, 0));
            }
        }
    }
}
