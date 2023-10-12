using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double ind = Math.Round((float.Parse(textBox1.Text) / (float.Parse(textBox2.Text) * float.Parse(textBox2.Text)) * 703), 2);
            label3.Text = "BMI: " + ind.ToString()+ "\nStatus: ";
            if (ind >= 18.5 && ind <= 25)
            {
                label3.Text += "optimal"; 
            }else if (ind < 18.5)
            {
                label3.Text += "underweight";
            }else if(ind > 25)
            {
                label3.Text += "overweight";
            }
        }
    }
}
