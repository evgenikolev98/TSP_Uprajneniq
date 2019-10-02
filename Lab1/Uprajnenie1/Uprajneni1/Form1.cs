using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uprajneni1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "Click one of the buttons bellow \n to see the magic working...";
            label1.Font = new Font("Arial", 14);
            label1.ForeColor = Color.White;
            this.BackColor = Color.Black;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("\t Hello students! \n \n \t \t THIS IS YOUR FIRST C# PROGRAM... \n\n \t\t\t Be Happy! :))))"); 

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
            ChangeFormColor(sender, e);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Blue;
            ChangeFormColor(sender, e);
        }

        // Стъпка 5
        private void ChangeFormColor(object sender, EventArgs e)
        {
            if (sender is Button) {
                this.BackColor = (sender as Button).BackColor;
                this.Text = sender.ToString();
            }
        }

        
    }
}
