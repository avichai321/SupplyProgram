namespace SupplyProgramUi.AdminUserControls
{
    partial class AddPackageUserControl1
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
            this.removePackagecomboBox1 = new System.Windows.Forms.ComboBox();
            this.removePackagebutton1 = new System.Windows.Forms.Button();
            this.removePackagelabel2 = new System.Windows.Forms.Label();
            this.addPackagetodatabasebutton1 = new System.Windows.Forms.Button();
            this.PackageNamelabel1 = new System.Windows.Forms.Label();
            this.addPackagetextBox1 = new System.Windows.Forms.TextBox();
            this.PackagesdataGridView1 = new System.Windows.Forms.DataGridView();
            this.scalecomboBox2 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PackagesdataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // removePackagecomboBox1
            // 
            this.removePackagecomboBox1.FormattingEnabled = true;
            this.removePackagecomboBox1.Location = new System.Drawing.Point(149, 254);
            this.removePackagecomboBox1.Name = "removePackagecomboBox1";
            this.removePackagecomboBox1.Size = new System.Drawing.Size(148, 23);
            this.removePackagecomboBox1.TabIndex = 14;
            // 
            // removePackagebutton1
            // 
            this.removePackagebutton1.Location = new System.Drawing.Point(149, 297);
            this.removePackagebutton1.Name = "removePackagebutton1";
            this.removePackagebutton1.Size = new System.Drawing.Size(148, 31);
            this.removePackagebutton1.TabIndex = 13;
            this.removePackagebutton1.Text = "Remove From DataBase";
            this.removePackagebutton1.UseVisualStyleBackColor = true;
            this.removePackagebutton1.Click += new System.EventHandler(this.RemovePackagebutton_Click);
            // 
            // removePackagelabel2
            // 
            this.removePackagelabel2.AutoSize = true;
            this.removePackagelabel2.Location = new System.Drawing.Point(29, 257);
            this.removePackagelabel2.Name = "removePackagelabel2";
            this.removePackagelabel2.Size = new System.Drawing.Size(100, 15);
            this.removePackagelabel2.TabIndex = 12;
            this.removePackagelabel2.Text = "Remove Package:";
            // 
            // addPackagetodatabasebutton1
            // 
            this.addPackagetodatabasebutton1.Location = new System.Drawing.Point(149, 177);
            this.addPackagetodatabasebutton1.Name = "addPackagetodatabasebutton1";
            this.addPackagetodatabasebutton1.Size = new System.Drawing.Size(148, 31);
            this.addPackagetodatabasebutton1.TabIndex = 11;
            this.addPackagetodatabasebutton1.Text = "Add To DataBase";
            this.addPackagetodatabasebutton1.UseVisualStyleBackColor = true;
            this.addPackagetodatabasebutton1.Click += new System.EventHandler(this.AddPackagetodatabasebutton_Click);
            // 
            // PackageNamelabel1
            // 
            this.PackageNamelabel1.AutoSize = true;
            this.PackageNamelabel1.Location = new System.Drawing.Point(29, 115);
            this.PackageNamelabel1.Name = "PackageNamelabel1";
            this.PackageNamelabel1.Size = new System.Drawing.Size(116, 15);
            this.PackageNamelabel1.TabIndex = 10;
            this.PackageNamelabel1.Text = "New Package Name:";
            // 
            // addPackagetextBox1
            // 
            this.addPackagetextBox1.Location = new System.Drawing.Point(149, 115);
            this.addPackagetextBox1.Name = "addPackagetextBox1";
            this.addPackagetextBox1.Size = new System.Drawing.Size(148, 23);
            this.addPackagetextBox1.TabIndex = 9;
            // 
            // PackagesdataGridView1
            // 
            this.PackagesdataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PackagesdataGridView1.Location = new System.Drawing.Point(377, 43);
            this.PackagesdataGridView1.Name = "PackagesdataGridView1";
            this.PackagesdataGridView1.RowTemplate.Height = 25;
            this.PackagesdataGridView1.Size = new System.Drawing.Size(416, 357);
            this.PackagesdataGridView1.TabIndex = 8;
            // 
            // scalecomboBox2
            // 
            this.scalecomboBox2.FormattingEnabled = true;
            this.scalecomboBox2.Location = new System.Drawing.Point(149, 144);
            this.scalecomboBox2.Name = "scalecomboBox2";
            this.scalecomboBox2.Size = new System.Drawing.Size(148, 23);
            this.scalecomboBox2.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 15);
            this.label2.TabIndex = 16;
            this.label2.Text = "Choose Scale:";
            // 
            // AddPackageUserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SupplyProgramUi.Properties.Resources.usercontrols_screens;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.scalecomboBox2);
            this.Controls.Add(this.removePackagecomboBox1);
            this.Controls.Add(this.removePackagebutton1);
            this.Controls.Add(this.removePackagelabel2);
            this.Controls.Add(this.addPackagetodatabasebutton1);
            this.Controls.Add(this.PackageNamelabel1);
            this.Controls.Add(this.addPackagetextBox1);
            this.Controls.Add(this.PackagesdataGridView1);
            this.Name = "AddPackageUserControl1";
            this.Size = new System.Drawing.Size(820, 487);
            ((System.ComponentModel.ISupportInitialize)(this.PackagesdataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox removePackagecomboBox1;
        private System.Windows.Forms.Button removePackagebutton1;
        private System.Windows.Forms.Label removePackagelabel2;
        private System.Windows.Forms.Button addPackagetodatabasebutton1;
        private System.Windows.Forms.Label PackageNamelabel1;
        private System.Windows.Forms.TextBox addPackagetextBox1;
        private System.Windows.Forms.DataGridView PackagesdataGridView1;
        private System.Windows.Forms.ComboBox scalecomboBox2;
        private System.Windows.Forms.Label label2;
    }
}
