using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreditCalc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //calculate
            decimal s, p, m, f, sb, mb;

                s = Convert.ToDecimal(textBox1.Text);
                p = Convert.ToDecimal(textBox2.Text);
                m = Convert.ToDecimal(textBox3.Text);
            f = Convert.ToDecimal(textBox7.Text);
            s = s - f;
            sb = Convert.ToDecimal(textBox8.Text);
            mb = Convert.ToDecimal(textBox9.Text);
            B_fore(s, p, m, sb, mb);
            Credit(s, p, m);
        }

        private void B_fore(decimal s, decimal p, decimal m, decimal sb, decimal mb)
        {
            Credit(s, p, m);

            decimal a, b,b1,s1, per;

            a = s * (1 + mb * ((p) / 100));
            b = ((s * (1 + m * (p / 100))) / 1000) / (m * 12);
            s1 = s-(b * 12)*mb;
            b1 = (s1 * (1 + (m - mb) * (p / 100))) / ((m - mb) * 12);
            per = s1-(b1 * 12) * (m - mb);
            decimal round = Decimal.Round(s1, 3);
            decimal bround = Decimal.Round(b1, 3);
            textBox11.Text = Convert.ToString(bround);
            textBox12.Text = Convert.ToString(round);
            textBox10.Text = Convert.ToString(round - s1);
        }

        private void Credit(decimal s, decimal p, decimal m)
        {
            decimal a,b;
            a = s * (1 + m * ((p) / 100));
            decimal round = Decimal.Round(a, 3);
            b = ((s * (1 + m * (p / 100)))) / (m * 12);
            decimal bround = Decimal.Round(b, 3);
            textBox5.Text = Convert.ToString(bround);
            textBox4.Text = Convert.ToString(round);
            textBox6.Text = Convert.ToString(round-s);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //clean
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            textBox10.Text = "";
            textBox11.Text = "";
            textBox12.Text = "";
        }
    }
}
