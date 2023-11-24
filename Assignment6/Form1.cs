using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment6
{
    public partial class Form1 : Form
    {
        private String Choice(int a)
        {
            if (a == 1)
            {
                return "Rock";
            }else if (a == 2)
            {
                return "Scissors";
            }
            else
            {
                return "Paper";
            }
        }

        private String Game(int choice)
        {
            //rock - 1 | scissors - 2 | paper - 3
            Random random = new Random();
            int computerChoice = random.Next(1, 3);
            String answer = "";
            String win = "You win";
            String lose = "You lose";
            String draw = "Draw";
            switch (choice)
            {
                case 1:
                    if (computerChoice == 2)
                    {
                        answer = win;
                    }else if(computerChoice == 3)
                    {
                        answer = lose;
                    }
                    else
                    {
                        answer = draw;
                    }
                    label5.Text = Choice(computerChoice);
                    break;
                case 2:
                    if (computerChoice == 3)
                    {
                        answer = win;
                    }
                    else if (computerChoice == 1)
                    {
                        answer = lose;
                    }
                    else
                    {
                        answer = draw;
                    }
                    label5.Text = Choice(computerChoice);
                    break;
                case 3:
                    if (computerChoice == 1)
                    {
                        answer = win;
                    }
                    else if (computerChoice == 2)
                    {
                        answer = lose;
                    }
                    else
                    {
                        answer = draw;
                    }
                    label5.Text = Choice(computerChoice);
                    break;
            }
            return answer;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            label6.Text = Game(1);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            label6.Text = Game(2);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            label6.Text = Game(3);
        }
    }
}
