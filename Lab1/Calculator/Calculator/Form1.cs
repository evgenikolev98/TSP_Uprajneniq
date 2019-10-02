using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
        }


        Calculator Calc = new Calculator();
        

        // Add
        private void button2_Click(object sender, EventArgs e)
        {
            double val1, val2;
            try
            {
                Calcu(sender, e);
            }
            catch
            {
                MessageBox.Show("Въведете коректни данни, преди да натиснете бутона!");
                textBox1.Clear();textBox2.Clear();textBox3.Clear();
            }
        }

        // Sub
        private void button3_Click(object sender, EventArgs e)
        {
            double val1, val2;
            try
            {

                Calcu(sender, e);
            }
            catch
            {
                MessageBox.Show("Въведете коректни данни, преди да натиснете бутона!");
                textBox1.Clear();textBox2.Clear();textBox3.Clear();
            }
        }

        //Multiply
        private void button4_Click(object sender, EventArgs e)
        {
            double val1, val2;
            try
            {
                Calcu(sender, e);
            }
            catch
            {
                MessageBox.Show("Въведете коректни данни, преди да натиснете бутона!");
                textBox1.Clear();textBox2.Clear();textBox3.Clear();
            }
        }

        //Divide
        private void button5_Click(object sender, EventArgs e)
        {
            double val1, val2;
            try
            {
                Calcu(sender, e);
            }
            catch
            {
                MessageBox.Show("Въведете коректни данни, преди да натиснете бутона!");
                textBox1.Clear();textBox2.Clear();textBox3.Clear();
            }
        }

        private void Calcu(object sender, EventArgs e)
        {
            double val1, val2;
            string s = (sender as Button).Text;
            try
            {
                val1 = Double.Parse(textBox1.Text);
                val2 = Double.Parse(textBox2.Text);

                if (s == "+")
                {
                    textBox3.Text = Calc.AddNumbers(val1, val2).ToString();
                }
                else if (s == "-")
                {
                    textBox3.Text = Calc.SubNumbers(val1, val2).ToString();
                }
                else if (s == "X")
                {
                    textBox3.Text = Calc.MulNumbers(val1, val2).ToString();
                }
                else if (s == "/")
                {
                    textBox3.Text = Calc.DivNumbers(val1, val2).ToString();
                }

            }
            catch
            {
                MessageBox.Show("Въведете коректни данни, преди да натиснете бутона!");
                textBox1.Clear(); textBox2.Clear(); textBox3.Clear();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double val1 = double.Parse(textBox1.Text);
            double val2 = double.Parse(textBox1.Text);

            if (comboBox1.Text == "Add")
            {
                textBox3.Text = Calc.AddNumbers(val1, val2).ToString();
            } 
            else if (comboBox1.Text =="Sub")
            {
                textBox3.Text = Calc.SubNumbers(val1, val2).ToString();
            }
            else if (comboBox1.Text == "Multiply")
            {
                textBox3.Text = Calc.MulNumbers(val1, val2).ToString();
            }
            else if (comboBox1.Text == "Divide")
            {
                textBox3.Text = Calc.DivNumbers(val1, val2).ToString();
            }
        }
    }
}
