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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           double val1 = Double.Parse(textBox1.Text);
           double val2 = Double.Parse(textBox2.Text);
           double val3 = Double.Parse(textBox3.Text);

            try
            {

                Disc(val1, val2, val3);
            } catch { }
        }

        private void Disc(double a, double b, double c)
        {
            double discriminant = Math.Pow(b, 2) - 4 * a * c;
            double x1, x2;

            if (a == 0)
            {
                MessageBox.Show(" 'a' трябва да е различно от '0' ", "");
            }
            else
            {
                textBox4.Text = discriminant.ToString();
                if (discriminant > 0)
                {
                   
                    x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                    x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
                    textBox5.Text = x1.ToString();
                    textBox6.Text = x1.ToString();
                }
                else if (discriminant == 0)
                {
                    x1 = -b / (2 * a);
                    textBox5.Text = x1.ToString();
                }
                else if (discriminant < 0)
                {
                    MessageBox.Show(" Няма реални корени ", "");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try 
            {
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
            } catch { }
        }
    }
}
