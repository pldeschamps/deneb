using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.Windows.Forms.DataVisualization.Charting;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.RegularExpressions;

namespace Deneb
{
    public partial class Experiment : Form
    {
        const bool uranium235 =true;
        private Precursors precursors = new Precursors(uranium235);
        private CriticalityVariations criticalityVariations = new CriticalityVariations();
        private Reactor reactor;
        private Point chartAreaXAxis;
        private bool saved;
        private bool dataGridUpdate = true;
        //private List<Point> criticalityPoints;

        public Experiment()
        {
            Console.WriteLine("constructeur");
            InitializeComponent();
        }
        /*public Experiment(string fileName)
        {
            openFile(fileName);
            InitializeComponent();
        }*/
        private void Experiment_Load(object sender, EventArgs e)
        {
            Console.WriteLine("load");
            saved = true;
            reactor = new Reactor(criticalityVariations, precursors);
            UpdateDataGridViewPrecursors(precursors);
            chartPopulation.Paint += new PaintEventHandler(this.chartPopulation_Paint);
            criticalityPanel1.OnCriticalityChange += criticalityPanel1_OnCriticalityChange;
            Display();
       }


        private void UpdateDataGridViewPrecursors(Precursors precursors)
        {
            dataGridUpdate = true;
            dataGridViewPrecursors.Rows.Clear();
            foreach(Precursor p in precursors.Items)
            {

                DataGridViewRow dataGridViewRow = new DataGridViewRow();
                dataGridViewRow.CreateCells(dataGridViewPrecursors);
                dataGridViewRow.SetValues(p.Beta*100000, p.Tau, p.active);
                dataGridViewPrecursors.Rows.Add(dataGridViewRow);
            }
            buttonCalculatePopulations.Visible = false;
            displayGlobalPrecursor(precursors);
            dataGridUpdate=false;
        }
        void criticalityPanel1_OnCriticalityChange(object sender, CriticalityVariationsEventArgs e)
        {
            criticalityVariations = e.CriticalityVariationsUpdated;
            if (buttonCalculatePopulations.Visible)
                precursors = readPrecursorsGrid();
            reactor = new Reactor(criticalityVariations, precursors);
            Display();
            buttonCalculatePopulations.Visible = false;
            saved = false;
            //throw new NotImplementedException();
        }

        void chartPopulation_Paint(object sender, PaintEventArgs e)
        {
            ChartArea neutronsChart = chartPopulation.ChartAreas[0];
            chartAreaXAxis.X = (int)neutronsChart.AxisX.ValueToPixelPosition(neutronsChart.AxisX.Minimum);
            chartAreaXAxis.Y = (int)neutronsChart.AxisX.ValueToPixelPosition(neutronsChart.AxisX.Maximum);
            criticalityPanel1.LoadCriticality(criticalityVariations, chartAreaXAxis);

            // How to get precursors color ?
            
            int count = chartPopulation.Series.Count;
            if (count > 2)
            {
                for (int i = 3; i < count; i++)
                {
                //DataGridViewPrecursors.Rows[i - 3].Cells[3].Value = chartPopulation.Palette;
                }
            }
            criticalityPanel1.Refresh();
        }
        private void Display()
        {
            // Labels
            labelLength.Text = criticalityVariations.TimeSpan.ToString();
            labelInitial.Text = criticalityVariations.CharacteristicValues.initial.ToString();
            labelFinal.Text = criticalityVariations.CharacteristicValues.final.ToString();
            labelMax.Text = criticalityVariations.CharacteristicValues.max.ToString();
            labelMin.Text = criticalityVariations.CharacteristicValues.min.ToString();
            
            int count = chartPopulation.Series.Count;
            for (int serie = 0; serie<count ; serie++ )
                chartPopulation.Series[serie].Points.Clear();
            if (count > 2)
            {
                for (int i = count-1; i > 1; i--)
                    chartPopulation.Series.Remove(chartPopulation.Series[i]);
            }

            // Diagramme de réactivité passif
            /*double time = 0;
            double rho = criticalityVariations.CharacteristicValues.initial;
            chartPopulation.Series[2].Points.Add(new DataPoint(time,rho));
            foreach (CriticalityVariation cv in criticalityVariations)
            {
                time += cv.length;
                rho += cv.variation;
                chartPopulation.Series[2].Points.Add(new DataPoint(time, rho));
            }*/

            // Réglage des striplines sur la valeur de beta /2 et -beta/2
            /*chartPopulation.ChartAreas[2].AxisY.StripLines[0].IntervalOffset = precursors.GlobalPrecursor.Beta * 50000;
            chartPopulation.ChartAreas[2].AxisY.StripLines[1].IntervalOffset = -precursors.GlobalPrecursor.Beta * 50000;*/
            try
            {
                // Population neutronique
                foreach (DataPoint dp in reactor.populationAtEveryStep)
                    chartPopulation.Series[0].Points.Add(dp);

                // Population des précurseurs
                string legend;
                foreach (DataPoint dp in precursors.GlobalPrecursor.populationAtEveryStep)
                    chartPopulation.Series[1].Points.Add(dp);

                for (int i = 0; i < precursors.Items.Count; i++)
                {
                    if (precursors.Items[i].active)
                    {
                        legend = "β" + i;
                        chartPopulation.Series.Add(new Series(legend));
                        chartPopulation.Series[legend].ChartArea = "Precursors";
                        chartPopulation.Series[legend].ChartType = SeriesChartType.Line;
                        foreach (DataPoint dp in precursors.Items[i].populationAtEveryStep)
                            chartPopulation.Series[legend].Points.Add(dp);
                    }
                }
                // Diagramme timeStep
                /*foreach (DataPoint dp in reactor.timeSteps)
                    chartPopulation.Series[1].Points.Add(dp);*/
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            save();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            open();
            /*
            BinaryFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(@"criticalityvariations.criticality", FileMode.Open);
            criticalityVariations = (CriticalityVariations)formatter.Deserialize(stream);
            stream.Close();
            stream.Dispose();

            reactor = new Reactor(criticalityVariations, precursors);
            Display();
            */
       }

        private void criticalityPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void chartPopulation_Click(object sender, EventArgs e)
        {

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void closeExperimentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void closeExperimentToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddVariationToolStripMenu_Click(object sender, EventArgs e)
        {
            criticalityPanel1.AddVariationToolStripMenu_Click(this, e);
        }

        private void DeleteVariationToolStripMenu_Click(object sender, EventArgs e)
        {
            criticalityPanel1.DeleteVariationToolStripMenu_Click(this, e);
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void toolStripContainer2_TopToolStripPanel_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked_2(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Open");
        }

        private void saveToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            save();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saved)
            {
                this.Close();
            }
            else
            {
                var result = MessageBox.Show("Do you want to save changes?", "Confirmation",MessageBoxButtons.YesNoCancel);
                if (result == System.Windows.Forms.DialogResult.No)
                {
                    this.Close();
                }
                else if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    save();
                }
            }
        }
        private void save()
        {
            if(saveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
             /* System.IO.StreamReader sr = new 
                 System.IO.StreamReader(openFileDialog1.FileName);
              MessageBox.Show(sr.ReadToEnd());
              sr.Close(); */
                ExperimentSerializedData esd = new ExperimentSerializedData(criticalityVariations, precursors);
                BinaryFormatter formatter = new BinaryFormatter();
                Stream stream = new FileStream(saveFileDialog.FileName, FileMode.Create);
                try
                {
                    formatter.Serialize(stream, esd);
                    saved = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex+" File could not be saved. Please Retry.");
                }
                stream.Close();
                stream.Dispose();
            }
        }
        private void open()
        {
            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                openFile(openFileDialog.FileName);
            }
        }

        private void openFile(string fileName)
        {
            Stream stream = new FileStream(fileName, FileMode.Open);
            BinaryFormatter formatter = new BinaryFormatter();
            ExperimentSerializedData esd = (ExperimentSerializedData)formatter.Deserialize(stream);
            criticalityVariations = new CriticalityVariations(esd.criticalityVariations);
            precursors = new Precursors(esd.precursors);
            stream.Close();
            stream.Dispose();
            reactor = new Reactor(criticalityVariations, precursors);
            UpdateDataGridViewPrecursors(precursors);
            Display();
            buttonCalculatePopulations.Visible = false;
        }

        private void buttonCalculatePopulations_Click(object sender, EventArgs e)
        {
            precursors=readPrecursorsGrid();
            reactor = new Reactor(criticalityVariations, precursors);
            Display();
            buttonCalculatePopulations.Visible = false;
        }
        private Precursors readPrecursorsGrid()
        {
            Precursors precursors = new Precursors();
            bool atLeastOnePrecursorActive = false;
            foreach(DataGridViewRow r in dataGridViewPrecursors.Rows)
            {
                if (r.Cells[2].Value != null)
                {
                    bool active = bool.Parse(r.Cells[2].Value.ToString());
                    if (active) atLeastOnePrecursorActive = true;
                    try
                    {
                        double beta = double.Parse(r.Cells[0].Value.ToString());
                        double tau = double.Parse(r.Cells[1].Value.ToString());
                        Precursor p = new Precursor(beta, tau, active);
                        precursors.add(p);
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }   
                }
            }
            if (!atLeastOnePrecursorActive)
                MessageBox.Show("At least one precursor must be active");
            displayGlobalPrecursor(precursors);
            return precursors;

        }

        private void displayGlobalPrecursor(Precursors precursors)
        {
            if (precursors.Items.Count >= 1)
            {
                labelGloBalPrecursorBeta.Text = (precursors.GlobalPrecursor.Beta * 100000).ToString();
                labelGlobalPrecursorTau.Text = precursors.GlobalPrecursor.Tau.ToString();
            }
            else
            {
                labelGloBalPrecursorBeta.Text = "0";
                labelGlobalPrecursorTau.Text = "0";
            }
        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridViewPrecursors_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (!dataGridUpdate)
            {
                buttonCalculatePopulations.Visible = true;
                precursors = readPrecursorsGrid();
                saved = false;
            }
#if DEBUG
            //Console.WriteLine("CellValueChanged");
#endif

        }

        private void dataGridViewPrecursors_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            buttonCalculatePopulations.Visible = true;
        }

        private void dataGridViewPrecursors_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            buttonCalculatePopulations.Visible = true;
            labelGloBalPrecursorBeta.Text = "";
            labelGlobalPrecursorTau.Text = "";
            saved = false;
#if DEBUG
            //Console.WriteLine("CellContentClick");
#endif
        }

        private void dataGridViewPrecursors_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
#if DEBUG
            //Console.WriteLine("CellValidated");
#endif
        }

        private void dataGridViewPrecursors_Validated(object sender, EventArgs e)
        {
#if DEBUG
            Console.WriteLine("DataGrid Validated");
#endif
        }

        private void buttonCalculateGlobalPrecursor_Click(object sender, EventArgs e)
        {
            precursors = readPrecursorsGrid();
        }

        private void dataGridViewPrecursors_KeyPress(object sender, KeyPressEventArgs e)
        {
            MatchCollection matches = Regex.Matches(e.KeyChar.ToString(), @"\d");
            if (matches.Count != 0 || e.KeyChar == (char)Keys.Delete || e.KeyChar == (char)Keys.Back)
                e.Handled = false;
            else
                e.Handled = true;

        }

        private void splitContainer3_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}
