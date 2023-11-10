using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int rndn, counter;

        private void rndNumber(bool a)
        {
            Random rnd = new Random();

            if (a)
            {
                label1.Text = $"Congratilations! You win!\nNumber of guesses: {counter}";
                rndn = rnd.Next(1, 100);
                counter = 0;
            }
            else
            {
                if (int.Parse(textBox1.Text) > rndn)
                {
                    label1.Text = "Too high, try again.";
                    counter += 1;
                    label2.Text = $"Attempts: {counter}";
                }
                else
                {
                    label1.Text = "Too low, try again.";
                    counter += 1;
                    label2.Text = $"Attempts: {counter}";
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random rnd = new Random();

            rndn = rnd.Next(1,100);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.Parse(textBox1.Text) == rndn)
            {
                rndNumber(true);
            }
            else
            {
                rndNumber(false);
            }
        }
    }
}
