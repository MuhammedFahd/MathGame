using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace startuppage
{
    public partial class math_game : Form
    {
        public int N1, N2, timeleft, score;

        public math_game()
        {
            InitializeComponent();
        }

        private void math_game_Load(object sender, EventArgs e)
        {

        }

        private void nextbutton_Click(object sender, EventArgs e)
        {
            timeleft = 6;
            timer1.Start();
            Random an = new Random();
            N1=an.Next(20);
            N2 = an.Next(20);

            firstnumber.Text = N1.ToString();
            secondnumber.Text = N2.ToString();

            donebutton.Enabled = true;
            nextbutton.Enabled = false;

            }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timeleft > 0)
            {
                timeleft--;
                timelabel.Text = timeleft.ToString();
            }
            if (timeleft == 0) 
            {
                timer1.Stop();
                donebutton.Enabled = false;
                nextbutton.Enabled = true;
                timelabel.Text = "";
                statusbox.Text = "Time Out";

                score = score - 1;
                scorelabel.Text = score.ToString();

            }
        }

        private void donebutton_Click(object sender, EventArgs e)
        {
            donebutton.Enabled = false;
            nextbutton.Enabled = true;
            timer1.Stop();

            int total = N1 + N2;
            if (answerbox.Text == total.ToString())
            {
                answerbox.Text = "";
                statusbox.Text = "Correct answer";

                score = score + 1;
                scorelabel.Text = score.ToString();
            }else
            {
                answerbox.Text = "";
                statusbox.Text = "incorrect answer";

                score = score - 1;
                scorelabel.Text = score.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            
                this.Hide();
                login lg = new login();
                lg.Show();
      
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            score = 0;
            scorelabel.Text = score.ToString();
            timer1.Stop();
            nextbutton.Enabled = true;
            donebutton.Enabled = false;
        } 
    }
}
