using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadacha2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            double val1 = Double.Parse(textBox1.Text);
            try
            {
                if (comboBox1.SelectedIndex == 0)
                {
                    Cel_to_Fah(val1);
                    label4.Text = val1.ToString() + " From C to F";
                }
                else if (comboBox1.SelectedIndex == 1)
                {
                    Fah_to_Cel(val1);
                    label4.Text = val1.ToString() + " From F to C";

                }
            }
            catch
            {
            }
            
            
        }

        private void Cel_to_Fah(double c)
        {
            double res = (c * 9 / 5) + 32;
            textBox2.Text = res.ToString();
        }

        private void Fah_to_Cel(double f)
        {
            double res = (f - 32) / 1.8000;
            textBox2.Text = res.ToString();
        }
    }
}
