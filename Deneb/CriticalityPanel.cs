using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Deneb
{
    public partial class CriticalityPanel : Panel
    {
        CriticalityVariationsPoints criticalityVariationsPoints;
        private CriticalityChartSize chartSize;
        Point draggingPoint;
        PhysicalAndPanelPoint selectedPoint;

        public CriticalityVariation VariationToInsert { get; set; }

        bool draging = false;

        bool onePointIsClose;

        public delegate void CriticalityChangeHandler(Object sender, CriticalityVariationsEventArgs e);
        public event CriticalityChangeHandler OnCriticalityChange;

        public CriticalityPanel()
        {
            onePointIsClose = false;
            InitializeComponent();
        }

        protected override void OnResize(EventArgs eventargs)
        {
            base.OnResize(eventargs);
            if (criticalityVariationsPoints != null)
                criticalityVariationsPoints.setSize(new Size(this.Width, this.Height));
        }

        public void LoadCriticality(CriticalityVariations criticalityVariations, Point xAxis)
        {
            chartSize = new CriticalityChartSize(new Size(this.Width, this.Height),
                                        new Point(xAxis.X, 10), new Point(this.Width-xAxis.Y, 30));
            criticalityVariationsPoints = new CriticalityVariationsPoints(criticalityVariations, chartSize);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            PhysicalAndPanelPoint previousPoint;
            Graphics g = this.CreateGraphics();
            if (criticalityVariationsPoints != null)
            {
                previousPoint = criticalityVariationsPoints.Points.First();
                foreach (PhysicalAndPanelPoint criticalityPoint in criticalityVariationsPoints.Points)
                {
                    DrawVerticalLine(g, Pens.DarkGray, previousPoint.PanelPoint.X);
                    DrawHorizontalLine(g, Pens.DarkGray, previousPoint.PanelPoint.Y);
                    g.DrawLine(new Pen(Color.Black, 3), previousPoint.PanelPoint, criticalityPoint.PanelPoint);
                    g.FillEllipse(Brushes.Black, new Rectangle(criticalityPoint.PanelPoint.X - 4,
                        criticalityPoint.PanelPoint.Y - 4, 8, 8));
                    WriteXYAxis(g, criticalityPoint);
                    previousPoint = criticalityPoint;
                }
                if (onePointIsClose || draging)
                {
                    g.FillEllipse(Brushes.Orange, new Rectangle(selectedPoint.PanelPoint.X - 4,
                        selectedPoint.PanelPoint.Y - 4, 8, 8));
                    // g.DrawEllipse(Pens.Red, new Rectangle(selectedPoint.X - 4, selectedPoint.Y - 4, 8, 8));
                }

                if (draging)
                {
                    previousPoint = criticalityVariationsPoints.MovingPoints.First();
                    foreach (PhysicalAndPanelPoint criticalityPoint in criticalityVariationsPoints.MovingPoints)
                    {
                        DrawVerticalLine(g, Pens.LightBlue, previousPoint.PanelPoint.X);
                        DrawHorizontalLine(g, Pens.LightBlue, previousPoint.PanelPoint.Y);

                        g.DrawLine(new Pen(Color.DarkBlue, 2), previousPoint.PanelPoint, criticalityPoint.PanelPoint);
                        g.FillEllipse(Brushes.DarkBlue,
                            new Rectangle(criticalityPoint.PanelPoint.X - 4, criticalityPoint.PanelPoint.Y - 4, 8, 8));
                        previousPoint = criticalityPoint;
                    }
                }


            }
        }

        private void WriteXYAxis(Graphics g, PhysicalAndPanelPoint criticalityPoint)
        {

            const int LegendXMargin = 6;
            string legend = ((int)criticalityPoint.PhysicalY).ToString();
            SizeF legendSizeF = g.MeasureString(legend, SystemFonts.DefaultFont);
            //legendSizeF.Height trop élevé, réduit de 25
            g.DrawString(legend,
                SystemFonts.DefaultFont, Brushes.Black,
                new Point(chartSize.LeftTopMargins.X - (int)(legendSizeF.Width) - LegendXMargin,
                    criticalityPoint.PanelPoint.Y + (int)((legendSizeF.Height - 25) / 2)));

            legend = (criticalityPoint.PhysicalX).ToString("0.0");
            legendSizeF = g.MeasureString(legend, SystemFonts.DefaultFont);
            //legendSizeF.Height trop élevé, réduit de 7
            const int LegendYMargin = -7;
            g.DrawString(legend,
                SystemFonts.DefaultFont, Brushes.Black,
                new Point(criticalityPoint.PanelPoint.X - (int)(legendSizeF.Width / 2),
                    this.Height - chartSize.RightBottomMargins.Y + (int)legendSizeF.Height + LegendYMargin));
        }
        private void DrawVerticalLine(Graphics g, Pen pen, int x)
        {
            g.DrawLine(pen, x, chartSize.LeftTopMargins.Y,
                        x, this.Height - chartSize.RightBottomMargins.Y);
        }
        private void DrawHorizontalLine(Graphics g, Pen pen, int y)
        {
            g.DrawLine(pen, chartSize.LeftTopMargins.X, y,
                         this.Width - chartSize.RightBottomMargins.X, y);
        }
        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);

            if (criticalityVariationsPoints != null)
            {
                if (draging)
                {
                    draggingPoint = e.Location;
                    criticalityVariationsPoints.calculateMovingPoints(selectedPoint, e.Location);
                    this.Refresh();
                }
                else
                {
                    double range;
                    double shorterRange = this.Height + this.Width;
                    const double rangeDetection = 8;
                    PhysicalAndPanelPoint closestPoint = new PhysicalAndPanelPoint(0, 0, new Point(0, 0));
                    bool onePointWasClose;

                    onePointWasClose = onePointIsClose;
                    onePointIsClose = false;
                    foreach (PhysicalAndPanelPoint point in criticalityVariationsPoints.Points)
                    {
                        range = Math.Sqrt(Math.Pow(e.X - point.PanelPoint.X, 2) + Math.Pow(e.Y - point.PanelPoint.Y, 2));
                        if (range < rangeDetection && range < shorterRange)
                        {
                            shorterRange = range;
                            closestPoint = point;
                            onePointIsClose = true;
                        }
                    }
                    if ((onePointIsClose != onePointWasClose) || (selectedPoint != closestPoint))
                    {
                        selectedPoint = closestPoint;
                        this.Refresh();
                    }
                }
            }
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            if (onePointIsClose && (e.Button == MouseButtons.Left))
            {
                draging = true;
            }
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);
            if (draging)
            {
                draging = false;
                criticalityVariationsPoints.updateVariations(selectedPoint);
                this.Refresh();
                CriticalityVariationsEventArgs cve =
                    new CriticalityVariationsEventArgs((CriticalityVariations)(criticalityVariationsPoints));

                OnCriticalityChange(this, cve);
                onePointIsClose = false;
            }


        }

        protected override void OnMouseClick(MouseEventArgs e)
        {
            if (onePointIsClose && e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                //base.OnMouseClick(e); //ContextMenuStrip1 will be shown
                contextMenuStrip1.Show(Cursor.Position);
            }
        }

        public void DeleteVariationToolStripMenu_Click(object sender, EventArgs e)
        {
            criticalityVariationsPoints.deleteVariation(selectedPoint);
            this.Refresh();
            CriticalityVariationsEventArgs cve =
                    new CriticalityVariationsEventArgs((CriticalityVariations)(criticalityVariationsPoints));
            OnCriticalityChange(this, cve);
        }
        public void AddVariationToolStripMenu_Click(object sender, EventArgs e)
        {
            VariationToInsert = null;
            AddVariationForm subForm = new AddVariationForm(this);
            
            subForm.ShowDialog();
            if (VariationToInsert != null)
            {
                criticalityVariationsPoints.InsertVariation(selectedPoint, VariationToInsert);
                this.Refresh();
                CriticalityVariationsEventArgs cve =
                        new CriticalityVariationsEventArgs((CriticalityVariations)(criticalityVariationsPoints));
                OnCriticalityChange(this, cve);
            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }
    }
}
