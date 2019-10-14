using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zad1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

       

       

        private void button2_Click(object sender, EventArgs e)
        {
            double val1 = Double.Parse(textBox1.Text);
            double val2 = Double.Parse(textBox2.Text);

            try
            {
                Sukrateno_umn(val1, val2);
            }
            catch{ }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                Uncheck();
            } 
            catch { }
        }

        private void Sukrateno_umn(double a, double b)
        {
            a = Double.Parse(textBox1.Text);
            b = Double.Parse(textBox2.Text);
            if (radioButton1.Checked == true)
            {
                double res = Math.Pow(a, 2) + 2 * a * b + Math.Pow(b, 2);
                textBox3.Text = res.ToString();
            }
            else if (radioButton2.Checked == true)
            {
                double res = Math.Pow(a, 2) - 2 * a * b + Math.Pow(b, 2);
                textBox3.Text = res.ToString();
            }
            else if (radioButton3.Checked == true)
            {
               double res = Math.Pow(a, 2) - Math.Pow(b, 2);
               textBox3.Text = res.ToString();

            }
            else if (radioButton4.Checked == true)
            {
                double res = Math.Pow(a,3) + 3 * Math.Pow(a,2) * b + 3 * a * Math.Pow(b,2) + Math.Pow(b,3);
                textBox3.Text = res.ToString();
            }
            else if (radioButton5.Checked == true)
            {
                double res = Math.Pow(a, 3) - 3 * Math.Pow(a, 2) * b + 3 * a * Math.Pow(b, 2) - Math.Pow(b, 3);
                textBox3.Text = res.ToString();
            }
            else if (radioButton6.Checked == true)
            {
                double res = (a + b) * (Math.Pow(a,2) - a * b + Math.Pow(b,2));
                textBox3.Text = res.ToString();
            }
            else if (radioButton7.Checked == true)
            {
                double res = (a - b) * (Math.Pow(a, 2) + a * b + Math.Pow(b, 2));
                textBox3.Text = res.ToString();
            }
        }

        private bool Uncheck()
        {
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            radioButton5.Checked = false;
            radioButton6.Checked = false;
            radioButton7.Checked = false;

            return false;
        }
    }
}
