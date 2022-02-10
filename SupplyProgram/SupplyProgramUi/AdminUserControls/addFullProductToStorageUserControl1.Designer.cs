namespace SupplyProgramUi.UserUserControls
{
    partial class addFullProductToStorageUserControl1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addFullProductToStorageUserControl1));
            this.LocationLabel1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.LocationcomboBox1 = new System.Windows.Forms.ComboBox();
            this.ProductcomboBox2 = new System.Windows.Forms.ComboBox();
            this.PackagecomboBox3 = new System.Windows.Forms.ComboBox();
            this.UnitInStocknumericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.UnitInOrdernumericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.AddProductbutton1 = new System.Windows.Forms.Button();
            this.Exitbutton2 = new System.Windows.Forms.Button();
            this.scaletextBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.UnitInStocknumericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UnitInOrdernumericUpDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // LocationLabel1
            // 
            this.LocationLabel1.AutoSize = true;
            this.LocationLabel1.Location = new System.Drawing.Point(47, 73);
            this.LocationLabel1.Name = "LocationLabel1";
            this.LocationLabel1.Size = new System.Drawing.Size(56, 15);
            this.LocationLabel1.TabIndex = 0;
            this.LocationLabel1.Text = "Location:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Product:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Package:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Scale:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "UnitInStock:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "Unit In Order:";
            // 
            // LocationcomboBox1
            // 
            this.LocationcomboBox1.FormattingEnabled = true;
            this.LocationcomboBox1.Location = new System.Drawing.Point(122, 73);
            this.LocationcomboBox1.Name = "LocationcomboBox1";
            this.LocationcomboBox1.Size = new System.Drawing.Size(121, 23);
            this.LocationcomboBox1.TabIndex = 6;
            // 
            // ProductcomboBox2
            // 
            this.ProductcomboBox2.FormattingEnabled = true;
            this.ProductcomboBox2.Location = new System.Drawing.Point(122, 102);
            this.ProductcomboBox2.Name = "ProductcomboBox2";
            this.ProductcomboBox2.Size = new System.Drawing.Size(121, 23);
            this.ProductcomboBox2.TabIndex = 7;
            // 
            // PackagecomboBox3
            // 
            this.PackagecomboBox3.FormattingEnabled = true;
            this.PackagecomboBox3.Location = new System.Drawing.Point(122, 135);
            this.PackagecomboBox3.Name = "PackagecomboBox3";
            this.PackagecomboBox3.Size = new System.Drawing.Size(121, 23);
            this.PackagecomboBox3.TabIndex = 8;
            this.PackagecomboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // UnitInStocknumericUpDown1
            // 
            this.UnitInStocknumericUpDown1.Location = new System.Drawing.Point(123, 194);
            this.UnitInStocknumericUpDown1.Name = "UnitInStocknumericUpDown1";
            this.UnitInStocknumericUpDown1.Size = new System.Drawing.Size(120, 23);
            this.UnitInStocknumericUpDown1.TabIndex = 10;
            // 
            // UnitInOrdernumericUpDown2
            // 
            this.UnitInOrdernumericUpDown2.Location = new System.Drawing.Point(122, 222);
            this.UnitInOrdernumericUpDown2.Name = "UnitInOrdernumericUpDown2";
            this.UnitInOrdernumericUpDown2.Size = new System.Drawing.Size(121, 23);
            this.UnitInOrdernumericUpDown2.TabIndex = 11;
            // 
            // AddProductbutton1
            // 
            this.AddProductbutton1.Location = new System.Drawing.Point(503, 258);
            this.AddProductbutton1.Name = "AddProductbutton1";
            this.AddProductbutton1.Size = new System.Drawing.Size(138, 42);
            this.AddProductbutton1.TabIndex = 12;
            this.AddProductbutton1.Text = "Add Product";
            this.AddProductbutton1.UseVisualStyleBackColor = true;
            this.AddProductbutton1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Exitbutton2
            // 
            this.Exitbutton2.Location = new System.Drawing.Point(503, 306);
            this.Exitbutton2.Name = "Exitbutton2";
            this.Exitbutton2.Size = new System.Drawing.Size(138, 42);
            this.Exitbutton2.TabIndex = 13;
            this.Exitbutton2.Text = "Save And Exit";
            this.Exitbutton2.UseVisualStyleBackColor = true;
            this.Exitbutton2.Click += new System.EventHandler(this.button2_Click);
            // 
            // scaletextBox1
            // 
            this.scaletextBox1.Location = new System.Drawing.Point(122, 164);
            this.scaletextBox1.Name = "scaletextBox1";
            this.scaletextBox1.ReadOnly = true;
            this.scaletextBox1.Size = new System.Drawing.Size(121, 23);
            this.scaletextBox1.TabIndex = 14;
            // 
            // addFullProductToStorageUserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.scaletextBox1);
            this.Controls.Add(this.Exitbutton2);
            this.Controls.Add(this.AddProductbutton1);
            this.Controls.Add(this.UnitInOrdernumericUpDown2);
            this.Controls.Add(this.UnitInStocknumericUpDown1);
            this.Controls.Add(this.PackagecomboBox3);
            this.Controls.Add(this.ProductcomboBox2);
            this.Controls.Add(this.LocationcomboBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LocationLabel1);
            this.Name = "addFullProductToStorageUserControl1";
            this.Size = new System.Drawing.Size(835, 475);
            ((System.ComponentModel.ISupportInitialize)(this.UnitInStocknumericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UnitInOrdernumericUpDown2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LocationLabel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox LocationcomboBox1;
        private System.Windows.Forms.ComboBox ProductcomboBox2;
        private System.Windows.Forms.ComboBox PackagecomboBox3;
        private System.Windows.Forms.NumericUpDown UnitInStocknumericUpDown1;
        private System.Windows.Forms.NumericUpDown UnitInOrdernumericUpDown2;
        private System.Windows.Forms.Button AddProductbutton1;
        private System.Windows.Forms.Button Exitbutton2;
        private System.Windows.Forms.TextBox scaletextBox1;
    }
}
