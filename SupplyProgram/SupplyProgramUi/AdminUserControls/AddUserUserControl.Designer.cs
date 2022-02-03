namespace SupplyProgramUi
{
    partial class AddUserUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddUserUserControl));
            this.Usernamelabel1 = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.UsernametextBox1 = new System.Windows.Forms.TextBox();
            this.PasswordtextBox2 = new System.Windows.Forms.TextBox();
            this.AdmincomboBox1 = new System.Windows.Forms.ComboBox();
            this.AddUserBtn = new System.Windows.Forms.Button();
            this.SearchUserbutton1 = new System.Windows.Forms.Button();
            this.RemoveUserBtn = new System.Windows.Forms.Button();
            this.SaveUserChangesBtn = new System.Windows.Forms.Button();
            this.Emaillabel2 = new System.Windows.Forms.Label();
            this.emailtextBox1 = new System.Windows.Forms.TextBox();
            this.SaveeditedUserChangesbutton1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Usernamelabel1
            // 
            this.Usernamelabel1.AutoSize = true;
            this.Usernamelabel1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Usernamelabel1.Location = new System.Drawing.Point(80, 123);
            this.Usernamelabel1.Name = "Usernamelabel1";
            this.Usernamelabel1.Size = new System.Drawing.Size(67, 17);
            this.Usernamelabel1.TabIndex = 0;
            this.Usernamelabel1.Text = "Username";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PasswordLabel.Location = new System.Drawing.Point(83, 153);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(64, 17);
            this.PasswordLabel.TabIndex = 1;
            this.PasswordLabel.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(102, 210);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Admin";
            // 
            // UsernametextBox1
            // 
            this.UsernametextBox1.Location = new System.Drawing.Point(153, 122);
            this.UsernametextBox1.Name = "UsernametextBox1";
            this.UsernametextBox1.Size = new System.Drawing.Size(121, 23);
            this.UsernametextBox1.TabIndex = 4;
            // 
            // PasswordtextBox2
            // 
            this.PasswordtextBox2.Location = new System.Drawing.Point(153, 151);
            this.PasswordtextBox2.Name = "PasswordtextBox2";
            this.PasswordtextBox2.Size = new System.Drawing.Size(121, 23);
            this.PasswordtextBox2.TabIndex = 5;
            // 
            // AdmincomboBox1
            // 
            this.AdmincomboBox1.FormattingEnabled = true;
            this.AdmincomboBox1.Items.AddRange(new object[] {
            "TRUE",
            "FALSE"});
            this.AdmincomboBox1.Location = new System.Drawing.Point(153, 209);
            this.AdmincomboBox1.Name = "AdmincomboBox1";
            this.AdmincomboBox1.Size = new System.Drawing.Size(121, 23);
            this.AdmincomboBox1.TabIndex = 7;
            // 
            // AddUserBtn
            // 
            this.AddUserBtn.Location = new System.Drawing.Point(587, 156);
            this.AddUserBtn.Name = "AddUserBtn";
            this.AddUserBtn.Size = new System.Drawing.Size(164, 47);
            this.AddUserBtn.TabIndex = 8;
            this.AddUserBtn.Text = "Add User";
            this.AddUserBtn.UseVisualStyleBackColor = true;
            this.AddUserBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // SearchUserbutton1
            // 
            this.SearchUserbutton1.Location = new System.Drawing.Point(587, 209);
            this.SearchUserbutton1.Name = "SearchUserbutton1";
            this.SearchUserbutton1.Size = new System.Drawing.Size(164, 47);
            this.SearchUserbutton1.TabIndex = 20;
            this.SearchUserbutton1.Text = "Search User";
            this.SearchUserbutton1.UseVisualStyleBackColor = true;
            this.SearchUserbutton1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // RemoveUserBtn
            // 
            this.RemoveUserBtn.Location = new System.Drawing.Point(587, 262);
            this.RemoveUserBtn.Name = "RemoveUserBtn";
            this.RemoveUserBtn.Size = new System.Drawing.Size(164, 47);
            this.RemoveUserBtn.TabIndex = 19;
            this.RemoveUserBtn.Text = "Remove User";
            this.RemoveUserBtn.UseVisualStyleBackColor = true;
            this.RemoveUserBtn.Click += new System.EventHandler(this.RemoveUserBtn_Click);
            // 
            // SaveUserChangesBtn
            // 
            this.SaveUserChangesBtn.Location = new System.Drawing.Point(587, 368);
            this.SaveUserChangesBtn.Name = "SaveUserChangesBtn";
            this.SaveUserChangesBtn.Size = new System.Drawing.Size(164, 47);
            this.SaveUserChangesBtn.TabIndex = 21;
            this.SaveUserChangesBtn.Text = "Save Changes And Exit";
            this.SaveUserChangesBtn.UseVisualStyleBackColor = true;
            this.SaveUserChangesBtn.Click += new System.EventHandler(this.SaveUserChangesBtn_Click);
            // 
            // Emaillabel2
            // 
            this.Emaillabel2.AutoSize = true;
            this.Emaillabel2.Location = new System.Drawing.Point(102, 180);
            this.Emaillabel2.Name = "Emaillabel2";
            this.Emaillabel2.Size = new System.Drawing.Size(39, 15);
            this.Emaillabel2.TabIndex = 22;
            this.Emaillabel2.Text = "Email:";
            // 
            // emailtextBox1
            // 
            this.emailtextBox1.Location = new System.Drawing.Point(153, 180);
            this.emailtextBox1.Name = "emailtextBox1";
            this.emailtextBox1.Size = new System.Drawing.Size(121, 23);
            this.emailtextBox1.TabIndex = 23;
            // 
            // SaveeditedUserChangesbutton1
            // 
            this.SaveeditedUserChangesbutton1.Location = new System.Drawing.Point(587, 315);
            this.SaveeditedUserChangesbutton1.Name = "SaveeditedUserChangesbutton1";
            this.SaveeditedUserChangesbutton1.Size = new System.Drawing.Size(164, 47);
            this.SaveeditedUserChangesbutton1.TabIndex = 24;
            this.SaveeditedUserChangesbutton1.Text = "Save Edited User";
            this.SaveeditedUserChangesbutton1.UseVisualStyleBackColor = true;
            this.SaveeditedUserChangesbutton1.Click += new System.EventHandler(this.SaveeditedUserChangesbutton1_Click);
            // 
            // AddUserUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.SaveeditedUserChangesbutton1);
            this.Controls.Add(this.emailtextBox1);
            this.Controls.Add(this.Emaillabel2);
            this.Controls.Add(this.SaveUserChangesBtn);
            this.Controls.Add(this.SearchUserbutton1);
            this.Controls.Add(this.RemoveUserBtn);
            this.Controls.Add(this.AddUserBtn);
            this.Controls.Add(this.AdmincomboBox1);
            this.Controls.Add(this.PasswordtextBox2);
            this.Controls.Add(this.UsernametextBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.Usernamelabel1);
            this.Name = "AddUserUserControl";
            this.Size = new System.Drawing.Size(851, 484);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Usernamelabel1;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox UsernametextBox1;
        private System.Windows.Forms.TextBox PasswordtextBox2;
        private System.Windows.Forms.ComboBox AdmincomboBox1;
        private System.Windows.Forms.Button AddUserBtn;
        private System.Windows.Forms.Button SearchUserbutton1;
        private System.Windows.Forms.Button RemoveUserBtn;
        private System.Windows.Forms.Button SaveUserChangesBtn;
        private System.Windows.Forms.Label Emaillabel2;
        private System.Windows.Forms.TextBox emailtextBox1;
        private System.Windows.Forms.Button SaveeditedUserChangesbutton1;
    }
}
