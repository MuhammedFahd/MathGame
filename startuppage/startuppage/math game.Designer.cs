namespace startuppage
{
    partial class math_game
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.firstnumber = new System.Windows.Forms.Label();
            this.secondnumber = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.scorelabel = new System.Windows.Forms.Label();
            this.timelabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.answerbox = new System.Windows.Forms.TextBox();
            this.donebutton = new System.Windows.Forms.Button();
            this.nextbutton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.statusbox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // firstnumber
            // 
            this.firstnumber.AutoSize = true;
            this.firstnumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstnumber.Location = new System.Drawing.Point(481, 238);
            this.firstnumber.Name = "firstnumber";
            this.firstnumber.Size = new System.Drawing.Size(47, 52);
            this.firstnumber.TabIndex = 0;
            this.firstnumber.Text = "0";
            // 
            // secondnumber
            // 
            this.secondnumber.AutoSize = true;
            this.secondnumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secondnumber.Location = new System.Drawing.Point(741, 238);
            this.secondnumber.Name = "secondnumber";
            this.secondnumber.Size = new System.Drawing.Size(47, 52);
            this.secondnumber.TabIndex = 1;
            this.secondnumber.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(619, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 52);
            this.label3.TabIndex = 2;
            this.label3.Text = "+";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Showcard Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(119, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(172, 60);
            this.label4.TabIndex = 3;
            this.label4.Text = "SCORE";
            // 
            // scorelabel
            // 
            this.scorelabel.AutoSize = true;
            this.scorelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scorelabel.ForeColor = System.Drawing.Color.Lime;
            this.scorelabel.Location = new System.Drawing.Point(171, 257);
            this.scorelabel.Name = "scorelabel";
            this.scorelabel.Size = new System.Drawing.Size(48, 52);
            this.scorelabel.TabIndex = 4;
            this.scorelabel.Text = "0";
            // 
            // timelabel
            // 
            this.timelabel.AutoSize = true;
            this.timelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timelabel.ForeColor = System.Drawing.Color.Red;
            this.timelabel.Location = new System.Drawing.Point(1058, 257);
            this.timelabel.Name = "timelabel";
            this.timelabel.Size = new System.Drawing.Size(48, 52);
            this.timelabel.TabIndex = 5;
            this.timelabel.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1007, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 60);
            this.label1.TabIndex = 6;
            this.label1.Text = "TIMER";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Cursor = System.Windows.Forms.Cursors.Default;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Snap ITC", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Image = global::startuppage.Properties.Resources.Hi_Tech_Wallpaper_14;
            this.label2.Location = new System.Drawing.Point(227, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(818, 95);
            this.label2.TabIndex = 7;
            this.label2.Text = "FUN MATH GAME";
            // 
            // answerbox
            // 
            this.answerbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answerbox.Location = new System.Drawing.Point(451, 339);
            this.answerbox.Name = "answerbox";
            this.answerbox.Size = new System.Drawing.Size(378, 57);
            this.answerbox.TabIndex = 8;
            // 
            // donebutton
            // 
            this.donebutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.donebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.donebutton.Font = new System.Drawing.Font("Hobo Std", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.donebutton.Location = new System.Drawing.Point(451, 444);
            this.donebutton.Name = "donebutton";
            this.donebutton.Size = new System.Drawing.Size(121, 56);
            this.donebutton.TabIndex = 9;
            this.donebutton.Text = "DONE";
            this.donebutton.UseVisualStyleBackColor = false;
            this.donebutton.Click += new System.EventHandler(this.donebutton_Click);
            // 
            // nextbutton
            // 
            this.nextbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.nextbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nextbutton.Font = new System.Drawing.Font("Hobo Std", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextbutton.Location = new System.Drawing.Point(609, 444);
            this.nextbutton.Name = "nextbutton";
            this.nextbutton.Size = new System.Drawing.Size(240, 56);
            this.nextbutton.TabIndex = 10;
            this.nextbutton.Text = "NEXT/START";
            this.nextbutton.UseVisualStyleBackColor = false;
            this.nextbutton.Click += new System.EventHandler(this.nextbutton_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // statusbox
            // 
            this.statusbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.statusbox.Font = new System.Drawing.Font("Elephant", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusbox.ForeColor = System.Drawing.Color.Black;
            this.statusbox.Location = new System.Drawing.Point(82, 363);
            this.statusbox.Name = "statusbox";
            this.statusbox.Size = new System.Drawing.Size(250, 44);
            this.statusbox.TabIndex = 11;
            this.statusbox.Text = "STATUS";
            this.statusbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Silver;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Hobo Std", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(21, 514);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(380, 53);
            this.button1.TabIndex = 12;
            this.button1.Text = "BACK TO MAIN MENU";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Hobo Std", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(934, 510);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(230, 49);
            this.button2.TabIndex = 13;
            this.button2.Text = "PLAY AGAIN";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // math_game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Silver;
            this.BackgroundImage = global::startuppage.Properties.Resources.background1;
            this.ClientSize = new System.Drawing.Size(1251, 821);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.statusbox);
            this.Controls.Add(this.nextbutton);
            this.Controls.Add(this.donebutton);
            this.Controls.Add(this.answerbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.timelabel);
            this.Controls.Add(this.scorelabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.secondnumber);
            this.Controls.Add(this.firstnumber);
            this.Name = "math_game";
            this.Text = "math_game";
            this.Load += new System.EventHandler(this.math_game_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label firstnumber;
        private System.Windows.Forms.Label secondnumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label scorelabel;
        private System.Windows.Forms.Label timelabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox answerbox;
        private System.Windows.Forms.Button donebutton;
        private System.Windows.Forms.Button nextbutton;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox statusbox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}