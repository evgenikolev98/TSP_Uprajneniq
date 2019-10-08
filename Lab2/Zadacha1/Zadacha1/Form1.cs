using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadacha1
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
            double val1, val2, val3;
            try
            {
                val1 = Double.Parse(textBox1.Text);
                val2 = Double.Parse(textBox2.Text);
                val3 = Double.Parse(textBox3.Text);
                Disc(val1, val2, val3);
            }
            catch
            {
            }

        }

        // Diskriminanta
        private void Disc(double a, double b, double c)
        {
            double discriminant = Math.Pow(b,2) - 4*a*c;
            double x1, x2;

            if (a == 0) {
                MessageBox.Show(" 'а' трябва да бъде различно от нула", "Задача 1");
            }
            else
            {
            
            if (discriminant == 0)
            { 
                x1 = -b / (2*a);
                label6.Text = x1.ToString();
                label7.Text = x1.ToString();
                
            }
            else if (discriminant > 0)
            {
                x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
                
                label6.Text =  x1.ToString();
                label7.Text =  x2.ToString();
            }
            else
            {
                label6.Text = "Няма реални корени";
                label7.Text = "Няма реални корени";
            }
        }
       }
    }
}
