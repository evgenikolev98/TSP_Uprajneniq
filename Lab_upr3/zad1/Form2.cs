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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double val1, val2;
            try
            {
                val1 = Double.Parse(textBox1.Text);
                val2 = Double.Parse(textBox2.Text);
                Step(val1, val2);
            }
            catch
            {
            }
        }

        private void Step(double a, double b)
        {
            double res = Math.Pow(a, b);
            textBox3.Text = res.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }
    }
}
