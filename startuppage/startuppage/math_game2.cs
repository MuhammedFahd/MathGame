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
    public partial class math_game2 : Form
    {
        public int N1, N2, timeleft, score,total;
        public math_game2()
        {
            InitializeComponent();
        }

        private void nextbutton_Click(object sender, EventArgs e)
        {
            timeleft = 6;
            timer2.Start();
            Random an = new Random();
        
            N1 = an.Next(20);
            N2 = an.Next(20);

            if(N1>N2)
            {
                firstnumber.Text = N1.ToString();
                secondnumber.Text = N2.ToString();
            }else
            {
                firstnumber.Text = N2.ToString();
                secondnumber.Text = N1.ToString();
            }


            donebutton.Enabled = true;
            nextbutton.Enabled = false;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
             if (timeleft > 0)
            {
                timeleft--;
                timelabel.Text = timeleft.ToString();
            }
             if (timeleft == 0)
             {
                 timer2.Stop();
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
            timer2.Stop();

        if(N1>N2)
        {
            total = N1 - N2;
        }else
        {
             total= N2 - N1;
        }
            if (answerbox.Text == total.ToString())
            {
                answerbox.Text = "";
                statusbox.Text = "Correct answer";

                score = score + 1;
                scorelabel.Text = score.ToString();
            }
            else
            {
                answerbox.Text = "";
                statusbox.Text = "incorrect answer";

                score = score - 1;
                scorelabel.Text = score.ToString();
            }
        }

        private void backbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            login lg = new login();
            lg.Show();
      
        }

        private void button2_Click(object sender, EventArgs e)
        {
            score = 0;
            scorelabel.Text = score.ToString();
            timer2.Stop();
            nextbutton.Enabled = true;
            donebutton.Enabled = false;
        }

      
        

        

       
        

        

       
        
           
        
       
            
            
            
        
    }
}
