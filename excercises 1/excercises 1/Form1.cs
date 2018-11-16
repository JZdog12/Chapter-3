using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace excercises_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void qtqChicken2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int chi1;
            int chi2;
            int chi3;
            int chi4;
            int chi5;
            int sum;
            int div;
            int mod;
            chi1 = Convert.ToInt32(qtqChicken1.Text);
            chi2 = Convert.ToInt32(qtqChicken2.Text);
            chi3 = Convert.ToInt32(qtqChicken3.Text);
            chi4 = Convert.ToInt32(qtqChicken4.Text);
            chi5 = Convert.ToInt32(qtqChicken5.Text);

            sum = chi1 + chi2 + chi3 + chi4 + chi5;
            div = sum / 12;
            mod = sum % 12;
            abaResult.Text = sum +" eggs is "+ div + " dozen with "+ mod + " left over";
        }
    }
}
