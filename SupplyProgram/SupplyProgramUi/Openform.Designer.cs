namespace SupplyProgramUi
{
    partial class Openform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Openform));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Usernamelabel2 = new System.Windows.Forms.Label();
            this.UsernametextBox1 = new System.Windows.Forms.TextBox();
            this.Passwordlabel2 = new System.Windows.Forms.Label();
            this.PasswordtextBox2 = new System.Windows.Forms.TextBox();
            this.Loginbutton1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(197, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(297, 71);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(199, 349);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(295, 29);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // Usernamelabel2
            // 
            this.Usernamelabel2.AutoSize = true;
            this.Usernamelabel2.Location = new System.Drawing.Point(234, 128);
            this.Usernamelabel2.Name = "Usernamelabel2";
            this.Usernamelabel2.Size = new System.Drawing.Size(60, 15);
            this.Usernamelabel2.TabIndex = 5;
            this.Usernamelabel2.Text = "Username";
            // 
            // UsernametextBox1
            // 
            this.UsernametextBox1.Location = new System.Drawing.Point(346, 125);
            this.UsernametextBox1.Name = "UsernametextBox1";
            this.UsernametextBox1.Size = new System.Drawing.Size(121, 23);
            this.UsernametextBox1.TabIndex = 6;
            // 
            // Passwordlabel2
            // 
            this.Passwordlabel2.AutoSize = true;
            this.Passwordlabel2.Location = new System.Drawing.Point(234, 158);
            this.Passwordlabel2.Name = "Passwordlabel2";
            this.Passwordlabel2.Size = new System.Drawing.Size(57, 15);
            this.Passwordlabel2.TabIndex = 7;
            this.Passwordlabel2.Text = "Password";
            // 
            // PasswordtextBox2
            // 
            this.PasswordtextBox2.Location = new System.Drawing.Point(346, 154);
            this.PasswordtextBox2.Name = "PasswordtextBox2";
            this.PasswordtextBox2.PasswordChar = '*';
            this.PasswordtextBox2.Size = new System.Drawing.Size(121, 23);
            this.PasswordtextBox2.TabIndex = 8;
            // 
            // Loginbutton1
            // 
            this.Loginbutton1.Location = new System.Drawing.Point(277, 221);
            this.Loginbutton1.Name = "Loginbutton1";
            this.Loginbutton1.Size = new System.Drawing.Size(152, 41);
            this.Loginbutton1.TabIndex = 9;
            this.Loginbutton1.Text = "Login";
            this.Loginbutton1.UseVisualStyleBackColor = true;
            this.Loginbutton1.Click += new System.EventHandler(this.Loginbutton1_Click);
            // 
            // Openform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(506, 390);
            this.Controls.Add(this.Loginbutton1);
            this.Controls.Add(this.PasswordtextBox2);
            this.Controls.Add(this.Passwordlabel2);
            this.Controls.Add(this.UsernametextBox1);
            this.Controls.Add(this.Usernamelabel2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Openform";
            this.Text = "Supply Program";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label Usernamelabel2;
        private System.Windows.Forms.TextBox UsernametextBox1;
        private System.Windows.Forms.Label Passwordlabel2;
        private System.Windows.Forms.TextBox PasswordtextBox2;
        private System.Windows.Forms.Button Loginbutton1;
    }
}