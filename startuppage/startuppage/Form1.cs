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
    
  
    public partial class login : Form
    {
        string firstname;
        public login()
        {
            InitializeComponent();
        }

        private void startbutton_Click(object sender, EventArgs e)
        {
           
            firstname=textBox1.Text;
            MessageBox.Show("hello!"+firstname,"welcome",MessageBoxButtons.OK,MessageBoxIcon.Information);
            this.Hide();
            math_game mg = new math_game();
            mg.Show();
            
            
        }

        private void sub_Click(object sender, EventArgs e)
        {
            
            firstname = textBox1.Text;
            MessageBox.Show("hello!" + firstname, "welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Hide();
            math_game2 mg2 = new math_game2();
            mg2.Show();

        }
    }
}
