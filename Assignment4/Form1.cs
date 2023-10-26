using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int number;
            
            try
            {
                number = int.Parse(textBox1.Text);
                
                int factorial = 1;

                for (int i = 1; i < number+1; i++)
                {
                    factorial *= i;
                }

                label3.Text = factorial.ToString();
            }
            catch
            {
                label3.Text = "Enter INTEGER!";
            }
        }
    }
}
