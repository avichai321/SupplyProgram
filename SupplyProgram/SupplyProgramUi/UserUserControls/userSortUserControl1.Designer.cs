namespace SupplyProgramUi.UserUserControls
{
    partial class userSortUserControl1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(userSortUserControl1));
            this.Sortbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.LocationcomboBox1 = new System.Windows.Forms.ComboBox();
            this.Closebutton2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Sortbutton
            // 
            this.Sortbutton.Location = new System.Drawing.Point(85, 151);
            this.Sortbutton.Name = "Sortbutton";
            this.Sortbutton.Size = new System.Drawing.Size(106, 38);
            this.Sortbutton.TabIndex = 7;
            this.Sortbutton.Text = "Sort";
            this.Sortbutton.UseVisualStyleBackColor = true;
            this.Sortbutton.Click += new System.EventHandler(this.Sortbutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "location list";
            // 
            // LocationcomboBox1
            // 
            this.LocationcomboBox1.FormattingEnabled = true;
            this.LocationcomboBox1.Location = new System.Drawing.Point(108, 95);
            this.LocationcomboBox1.Name = "LocationcomboBox1";
            this.LocationcomboBox1.Size = new System.Drawing.Size(119, 23);
            this.LocationcomboBox1.TabIndex = 5;
            // 
            // Closebutton2
            // 
            this.Closebutton2.Location = new System.Drawing.Point(85, 195);
            this.Closebutton2.Name = "Closebutton2";
            this.Closebutton2.Size = new System.Drawing.Size(106, 42);
            this.Closebutton2.TabIndex = 50;
            this.Closebutton2.Text = "Close menu";
            this.Closebutton2.UseVisualStyleBackColor = true;
            this.Closebutton2.Click += new System.EventHandler(this.button2_Click);
            // 
            // userSortUserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.Closebutton2);
            this.Controls.Add(this.Sortbutton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LocationcomboBox1);
            this.Name = "userSortUserControl1";
            this.Size = new System.Drawing.Size(269, 423);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Sortbutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox LocationcomboBox1;
        private System.Windows.Forms.Button Closebutton2;
    }
}
