using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadacha3
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

        private void button1_Click(object sender, EventArgs e)
        {
            double val1 = Double.Parse(textBox1.Text);
            try {
                // feet to yards
                if (comboBox1.SelectedIndex == 0 && comboBox2.SelectedIndex == 1)
                {
                    Feet_to_Yards(val1);
                }
                // feet to inches
                else if (comboBox1.SelectedIndex == 0 && comboBox2.SelectedIndex == 2)
                {
                    Feet_to_Inches(val1);
                }
                // feet to miles
                else if (comboBox1.SelectedIndex == 0 && comboBox2.SelectedIndex == 3)
                {
                    Feet_to_Miles(val1);
                }
                //yards to feet
                else if (comboBox1.SelectedIndex == 1 && comboBox2.SelectedIndex == 0)
                {
                    Yards_to_Feet(val1);
                }

                //yards to inches
                else if (comboBox1.SelectedIndex == 1 && comboBox2.SelectedIndex == 2)
                {
                    Yards_to_Inches(val1);
                }

                //yards to miles
                else if (comboBox1.SelectedIndex == 1 && comboBox2.SelectedIndex == 3)
                {
                    Yards_to_Miles(val1);
                }

                //inches to feet
                else if (comboBox1.SelectedIndex == 2 && comboBox2.SelectedIndex == 0)
                {
                    Inches_to_Feet(val1);
                }

                //inches to yards
                else if (comboBox1.SelectedIndex == 2 && comboBox2.SelectedIndex == 1)
                {
                    Inches_to_Yards(val1);
                }

                //inches to miles
                else if (comboBox1.SelectedIndex == 2 && comboBox2.SelectedIndex == 3)
                {
                    Inches_to_Miles(val1);
                }
                
                //miles to feet
                else if (comboBox1.SelectedIndex == 3 && comboBox2.SelectedIndex == 0)
                {
                    Miles_to_Feet(val1);
                }

                //miles to yards
                else if (comboBox1.SelectedIndex == 3 && comboBox2.SelectedIndex == 1)
                {
                    Miles_to_Yards(val1);
                }

                //miles to inches
                else if (comboBox1.SelectedIndex == 3 && comboBox2.SelectedIndex == 2)
                {
                    Miles_to_Inches(val1);
                }

            }
            catch
            {
            }
            
        }

        //feet
        private void Feet_to_Yards(double f)
        {
            double res = f / 3;
            textBox2.Text = res.ToString();
        }

        private void Feet_to_Inches(double f)
        {
            double res = f * 12;
            textBox2.Text = res.ToString();
        }

        private void Feet_to_Miles(double f)
        {
            double res = f / 5280.0;
            textBox2.Text = res.ToString();
        }

        //yards
        private void Yards_to_Feet(double y)
        {
            double res = y * 3;
            textBox2.Text = res.ToString();
        }

        private void Yards_to_Inches(double y)
        {
            double res = y * 36;
            textBox2.Text = res.ToString();
        }

        private void Yards_to_Miles(double y)
        {
            double res = y * 0.000568;
            textBox2.Text = res.ToString();
        }

        //inches
        private void Inches_to_Feet(double i)
        {
            double res = i * 0.0833333333;
            textBox2.Text = res.ToString();
        }

        private void Inches_to_Yards(double i)
        {
            double res = i / 36;
            textBox2.Text = res.ToString();
        }

        private void Inches_to_Miles(double i)
        {
            double res = i / 63360;
            textBox2.Text = res.ToString();
        }

        //miles
        private void Miles_to_Feet(double m)
        {
            double res = m * 5280.0;
            textBox2.Text = res.ToString();
        }

        private void Miles_to_Yards(double m)
        {
            double res = m * 1760;
            textBox2.Text = res.ToString();
        }

        private void Miles_to_Inches(double m)
        {
            double res = m * 63360;
            textBox2.Text = res.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Are you sure you want to exit","",MessageBoxButtons.YesNo);

            if (res == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if (res == DialogResult.No) { }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
        }
    }
}
