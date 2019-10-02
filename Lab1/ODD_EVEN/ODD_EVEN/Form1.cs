using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ODD_EVEN
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("This is an application that shows if the number is odd or even.", "ODD/Even");
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double var1 = Double.Parse(textBox1.Text);
                if (var1 % 2 == 0)
                {
                    label1.Text = "Even";
                }
                else
                {
                    label1.Text = "Odd";
                }
            }
            catch
            {
                MessageBox.Show("Input string is not in correct format");
                textBox1.Clear();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Exiting Application?", "Demo", MessageBoxButtons.YesNo);

            if (res == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if (res == DialogResult.No)
            {

            }
        }
    }
}
