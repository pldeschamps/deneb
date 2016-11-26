using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deneb
{
    [Serializable]
    class CriticalityVariationsPoints : CriticalityVariations
    {
        [NonSerialized]
        private List<PhysicalAndPanelPoint> points;
        public List<PhysicalAndPanelPoint> Points
        {
            get { return points; }
        }
        [NonSerialized]
        private List<PhysicalAndPanelPoint> movingPoints;
        public List<PhysicalAndPanelPoint> MovingPoints
        {
            get { return movingPoints; }
        }
        [NonSerialized]
        private CriticalityChartSize chartSize;
        double widthScale;
        double heigthScale;
        Point offset;


        public CriticalityVariationsPoints(CriticalityVariations criticalityVariations, CriticalityChartSize criticalityChartSize)
            : base(criticalityVariations)
        {
            chartSize = criticalityChartSize;
            CalculatePoints();
        }

        public void setSize(Size panelSize)
        {
            this.chartSize.PanelSize = panelSize;
            this.CalculatePoints();
        }

        public void CalculatePoints()
        {

            widthScale = chartSize.ChartSize.Width / this.TimeSpan;
            heigthScale = chartSize.ChartSize.Height / (this.CharacteristicValues.max - this.CharacteristicValues.min);
            points = new List<PhysicalAndPanelPoint>();
            double rho = this.CharacteristicValues.initial;
            double time = 0;
            int x = chartSize.LeftTopMargins.X;
            int y = chartSize.LeftTopMargins.Y +
                (int)((this.CharacteristicValues.max - this.CharacteristicValues.initial) * heigthScale);
            points.Add(new PhysicalAndPanelPoint(time, rho, new Point(x, y)));

            foreach (CriticalityVariation v in this)
            {
                time += v.length;
                rho += v.variation;
                x += (int)(v.length * widthScale);
                y -= (int)(v.variation * heigthScale);
                points.Add(new PhysicalAndPanelPoint(time, rho, new Point(x, y)));
            }
        }

        public void calculateMovingPoints(PhysicalAndPanelPoint selectedPoint, Point mouse)
        {

            PhysicalAndPanelPoint previousPoint;
            Point offsetPoint;
            movingPoints = new List<PhysicalAndPanelPoint>();

            int selectedPointIndex = points.IndexOf(selectedPoint);

            offset.Y = mouse.Y - selectedPoint.PanelPoint.Y;

            if (selectedPointIndex <= 0)
            {
                previousPoint = points[0];
                offset.X = 0;
            }
            else
            {
                previousPoint = points[selectedPointIndex - 1];
                offset.X = Math.Max(mouse.X - selectedPoint.PanelPoint.X,
                    previousPoint.PanelPoint.X - selectedPoint.PanelPoint.X);
            }


            foreach (PhysicalAndPanelPoint p in points)
            {
                if (points.IndexOf(p) < selectedPointIndex)
                {
                    movingPoints.Add(p);
                }
                else
                {
                    offsetPoint = new Point(p.PanelPoint.X + offset.X,
                        p.PanelPoint.Y + mouse.Y - selectedPoint.PanelPoint.Y);
                    movingPoints.Add(new PhysicalAndPanelPoint(offsetPoint));
                }
                previousPoint = p;

            }



        }

        public void updateVariations(PhysicalAndPanelPoint selectedPoint)
        {

            int selectedPointIndex = points.IndexOf(selectedPoint);
            if (selectedPointIndex >= 0)
            {
                if (selectedPointIndex == 0)
                {
                    this.CalculateCharacteristicValues(CharacteristicValues.initial - offset.Y / heigthScale);
                }
                else  //selectedPointIndex > 0
                {
                    CriticalityVariation selectedCv = this[selectedPointIndex - 1];
                    selectedCv.length += offset.X / widthScale;
                    selectedCv.variation -= offset.Y / heigthScale;
                    this.CalculateCharacteristicValues();
                }
                this.CalculatePoints();
            }

        }
        public void deleteVariation(PhysicalAndPanelPoint selectedPoint)
        {

            int selectedPointIndex = points.IndexOf(selectedPoint);
            if (selectedPointIndex == 0)
            {

            }
            else
            {
                this.RemoveAt(selectedPointIndex - 1);
                this.CalculateCharacteristicValues();
            }

            this.CalculatePoints();

        }

        public void InsertVariation(PhysicalAndPanelPoint selectedPoint, CriticalityVariation variationToInsert)
        {
            int selectedPointIndex = points.IndexOf(selectedPoint);
            this.Insert(selectedPointIndex, variationToInsert);
            this.CalculateCharacteristicValues();
            this.CalculatePoints();
        }



    }
}
