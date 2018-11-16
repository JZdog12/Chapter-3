using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuUIcalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BTNADD_Click(object sender, EventArgs e)
        {
            int num1;
            int num2;
            int sum;
            num1 = Convert.ToInt32(txtNumber1.Text);
            num2 = Convert.ToInt32(txtNumber2.Text);

            sum = num1 + num2;
            lblResult.Text = "The sum is " + sum;
        }

        private void TXTnumber1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1;
            int num2;
            int sub;
            num1 = Convert.ToInt32(txtNumber1.Text);
            num2 = Convert.ToInt32(txtNumber2.Text);

            sub = num1 - num2;
            lblResult.Text = "The remaining is " + sub;
        }

        private void qytDivision_Click(object sender, EventArgs e)
        {
            int num1;
            int num2;
            int div;
            num1 = Convert.ToInt32(txtNumber1.Text);
            num2 = Convert.ToInt32(txtNumber2.Text);

            div = num1 / num2;
            lblResult.Text = "The total is " + div;
        }

        private void btnmultiplication_Click(object sender, EventArgs e)
        {
            int num1;
            int num2;
            int product;
            num1 = Convert.ToInt32(txtNumber1.Text);
            num2 = Convert.ToInt32(txtNumber2.Text);

            product = num1 * num2;
            lblResult.Text = "The amount is " + product;
        }

        private void btnMod_Click(object sender, EventArgs e)
        {
            int num1;
            int num2;
            int mod;
            num1 = Convert.ToInt32(txtNumber1.Text);
            num2 = Convert.ToInt32(txtNumber2.Text);

            mod = num1 % num2;
            lblResult.Text = "The mod is " + mod;
        }

        private void lblResult_Click(object sender, EventArgs e)
        {

        }
    }
}
