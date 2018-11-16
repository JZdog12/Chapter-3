using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GreenvillerevenueGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double product1;
            double product2;
            double estan;
            double Tcon2;
            double fee = 25;
            estan = Convert.ToDouble(lylContestants.Text);
            Tcon2 = Convert.ToDouble(tytContestants.Text);

            product1 = estan * fee;
            product2 = Tcon2 * fee;
            if (product1 > product2) {
                lblFrfMost.Text = "The contestants from last year has more contestants than this year";
            }
            else (product2 > product1) {
                lblFrfMost.Text = "The contestants from this year has more contestants than last year";
            }

        }
    }
}
