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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        //Степенуване
        private void степенуванеToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Form2 secondForm = new Form2();
            secondForm.Show();
        }

        private void съкратеноУмножениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 thirdForm = new Form3();
            thirdForm.Show();
        }

        private void квадратноУравнениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 fourthForm = new Form4();
            fourthForm.Show();
        }
    }
}
