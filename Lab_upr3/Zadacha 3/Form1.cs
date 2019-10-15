using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int year = Int32.Parse(textBox1.Text);
            int month = Int32.Parse(textBox2.Text);
            bool t = DateTime.IsLeapYear(year);
            try 
            {
                validate(year, month);
                if (t)
                {
                    MessageBox.Show(" Годината е високосна ", "");
                }
                else
                {
                    MessageBox.Show(" Годината не е високосна ", "");
                }
            }
            catch { }
        }

        private void validate(int y, int m)
        {
            if (m < 1 || m > 12)
            {
                MessageBox.Show("Въведете месец от 1-ви до 12-ти ", "");
                textBox1.Clear();
                textBox2.Clear();
            }
            else if (y < 1900)
            {
                MessageBox.Show(" Въведете година след 1900 ","");
                textBox1.Clear();
                textBox2.Clear();
            }
        }
    }
}
