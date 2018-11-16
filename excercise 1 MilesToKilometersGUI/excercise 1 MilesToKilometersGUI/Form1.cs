using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace excercise_1_MilesToKilometersGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btbCalculate_Click(object sender, EventArgs e)
        {
            double mil;
            double amo=1.6;
            double div;
            double mod;
            mil = Convert.ToDouble(mlmMiles.Text);

            div = mil / amo;
            mod = div % 1.6;
            frfKilometer.Text = "The kilometers are " + div + " and the miles left over are " + mod;
        }
    }
}
