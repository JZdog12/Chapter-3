using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Excersice_3_CarRentalInteractiveGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void clcPay_Click(object sender, EventArgs e)
        {
            double day;
            double mil;
            double product1;
            double product2;
            double dis=1.25;
            double tim=20;
            double sum;
            day = Convert.ToDouble(amaDays.Text);
            mil = Convert.ToDouble(nfnMiles.Text);

            product1 = day * tim;
            product2 = mil * dis;
            sum = product1 + product2;
            apaPay.Text = "The amount you need to pay in total is $" + sum;
        }
    }
}
