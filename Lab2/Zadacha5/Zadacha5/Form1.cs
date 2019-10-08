using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Zadacha5
{
    
    public partial class Form1 : Form
    {
       
        List<double> pot_list = new List<double>();
        public Form1()
        {
            InitializeComponent();
        }

        public double Calc(double x1, double x2, double tarifa)
        {
            double res = 0;
            res = (x2 - x1) * tarifa;
            return res;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            try { 
            suma_lbl.Text = Calc(Double.Parse(textBox1.Text), Double.Parse(textBox2.Text), 0.34).ToString();
            pot_lbl.Text = (Double.Parse(textBox2.Text) - Double.Parse(textBox1.Text)).ToString();
          
                
            }
            catch { }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                suma_lbl.Text = Calc(Double.Parse(textBox1.Text), Double.Parse(textBox2.Text), 0.44).ToString();
                pot_lbl.Text = (Double.Parse(textBox2.Text) - Double.Parse(textBox1.Text)).ToString();
               
            }
            catch { }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                suma_lbl.Text = Calc(Double.Parse(textBox1.Text), Double.Parse(textBox2.Text), 0.54).ToString();
                pot_lbl.Text = (Double.Parse(textBox2.Text) - Double.Parse(textBox1.Text)).ToString();
              

            }
            catch { }

        }

        private void новКлиентToolStripMenuItem_Click(object sender, EventArgs e)
        {

            int num = Int32.Parse(client_n.Text);
            num++;
            client_n.Text = num.ToString();
            pot_list.Add(Double.Parse(suma_lbl.Text));
            textBox1.Clear();
            textBox2.Clear();
            pot_lbl.Text = "0";
            suma_lbl.Text = "0";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;

        }

        private void изходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pot_list.Add(Double.Parse(suma_lbl.Text));
            double x = 0;
            for(int i = 0; i < pot_list.Count; i++)
            {
                 x = x + pot_list[i];
            }
            DialogResult dialog = MessageBox.Show("Общо за всички = " + x + " лв");
            if(dialog == DialogResult.OK)
            {
                 Application.Exit();
            }

        }

        private void заПрограматаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Програма, която изчислява потреблението на ток.", "About");
        }
    }
}
