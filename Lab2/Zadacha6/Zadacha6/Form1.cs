using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadacha6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            label1.Text = "";
            width_lbl.Text = "width: ";
            height_lbl.Text = "height: ";
            area_lbl.Text = "AREA: ";
            width2.Text = hScrollBar1.Value.ToString();
            double a = hScrollBar1.Value;
            double b = vScrollBar1.Value;
            area2.Text = (a * b).ToString();
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            label1.Text = "";
            width_lbl.Text = "width: ";
            height_lbl.Text = "height: ";
            area_lbl.Text = "AREA: ";
            height2.Text = vScrollBar1.Value.ToString();
            double a = hScrollBar1.Value;
            double b = vScrollBar1.Value;
            area2.Text = (a * b).ToString();
        }
    }
}
