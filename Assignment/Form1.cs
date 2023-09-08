using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Text = "";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            label1.Text = "Diamonds 2";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            label1.Text = "Diamonds A";
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            label1.Text = "Diamonds 10";
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            label1.Text = "Diamonds 7";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
