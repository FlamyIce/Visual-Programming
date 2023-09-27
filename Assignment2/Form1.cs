using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int num1 = int.Parse(textBox1.Text) * 15;
                int num2 = int.Parse(textBox2.Text) * 12;
                int num3 = int.Parse(textBox3.Text) * 9;

                int total = num1 + num2 + num3;

                label10.Text = "$" + num1.ToString();
                label11.Text = "$" + num2.ToString();
                label12.Text = "$" + num3.ToString();
                label13.Text = "$" + total.ToString();
            }catch (Exception ex)
            {
                MessageBox.Show("Input string was not in a correct format");
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";

            label10.Text = "";
            label11.Text = "";
            label12.Text = "";
            label13.Text = "";
        }
    }
}
