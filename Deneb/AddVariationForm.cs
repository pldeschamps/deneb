using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;


namespace Deneb
{
    public partial class AddVariationForm : Form
    {
        CriticalityPanel mainPanel;

        public AddVariationForm(CriticalityPanel mainPanel)
        {
            this.mainPanel   = mainPanel;
            InitializeComponent();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if ((textBoxTime.Text != string.Empty) && (textBoxVariation.Text != string.Empty))
            {
                mainPanel.VariationToInsert = new CriticalityVariation(double.Parse(textBoxTime.Text), double.Parse(textBoxVariation.Text));
            }
            this.Close();
        }

        private void textBoxTime_KeyPress(object sender, KeyPressEventArgs e)
        {
            MatchCollection matches = Regex.Matches(e.KeyChar.ToString(), @"\d");
            if (matches.Count != 0 || e.KeyChar == (char)Keys.Delete || e.KeyChar == (char)Keys.Back)
                e.Handled=false;
            else
                e.Handled=true;
        }

        private void textBoxVariation_KeyDown(object sender, KeyEventArgs e)
        {
        }

        private void textBoxVariation_KeyPress(object sender, KeyPressEventArgs e)
        {
            MatchCollection matches = Regex.Matches(e.KeyChar.ToString(), @"\d");
            if (matches.Count != 0 || e.KeyChar == (char)Keys.Delete || e.KeyChar == (char)Keys.Back
                || (e.KeyChar == '-' && textBoxVariation.SelectionStart==0))
                e.Handled = false;
            else
                e.Handled = true;

        }
    }
}
