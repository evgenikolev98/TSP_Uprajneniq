using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadacha4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int year, day, month;
             month = Int32.Parse(textBox1.Text);
             day = Int32.Parse(textBox2.Text);
             year = Int32.Parse(textBox3.Text);
            Calc(year, month);
       
        }

        int  Calc(int y, int m)
        {
            int result_year, result_month, year_today, month_today;
            year_today = DateTime.Today.Year;
            month_today = DateTime.Today.Month;
            result_year = year_today - y;
            result_month = month_today - m;

            if (month_today < m)
            {
                result_year -= 1;
                result_month += 12;
            }
            MessageBox.Show(result_year + " Years and " + result_month + " Months","");
            return 0;
        }
    }
}
