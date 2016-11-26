using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Deneb
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            this.nouvelleExpérienceToolStripMenuItem_Click(this,  new EventArgs());

        }

        private void nouvelleExpérienceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Experiment experiment = new Experiment();
            experiment.MdiParent = this;
            experiment.Show();
        }

        private void fichierToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void saveExperimentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 aboutBox = new AboutBox1();
            aboutBox.ShowDialog();
        }

        private void aboutStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 aboutBox = new AboutBox1();
            aboutBox.ShowDialog();
        }

        private void helpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Help helpBox = new Help();
            helpBox.MdiParent = this;
            helpBox.Show();
        }

        
    }
}
