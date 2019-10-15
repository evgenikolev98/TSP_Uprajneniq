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
        private void text_salary_KeyPress(object sender, KeyPressEventArgs e)
        {           
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)44)
            {
                e.Handled = true; text_salary.Focus();
            }
        }
       


        private void btn_calc_Click(object sender, EventArgs e)
        {
            
        
            double salary = Double.Parse(text_salary.Text);
            double DOO = 0;
            double DZPO = 0;
            double zdravni_osig = 0.032 * salary;
            double sum = 0;

            if (radioButton1.Checked)
            {
                DOO = 0.089 * salary;
                DZPO = 0 * salary;
                sum = DOO + DZPO + zdravni_osig;
            }else if (radioButton2.Checked)
            {
                DOO = 0.067 * salary;
                DZPO = 0.022 * salary;
                sum = DOO + DZPO + zdravni_osig;
            }
            label_dzpo.Text = Math.Round(DZPO, 2).ToString() + " лв " ;
            label_zdravno.Text = Math.Round(zdravni_osig, 2).ToString() + " лв ";
            label_doo.Text = Math.Round(DOO, 2).ToString() + " лв ";
            label_sum.Text = Math.Round(sum, 2).ToString() + " лв ";
            }
          
        }

   

}

