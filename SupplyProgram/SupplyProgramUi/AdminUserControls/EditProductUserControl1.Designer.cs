namespace SupplyProgramUi.UserUserControls
{
    partial class EditProductUserControl1
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
            this.EditProductdataGridView1 = new System.Windows.Forms.DataGridView();
            this.PackagecomboBox3 = new System.Windows.Forms.ComboBox();
            this.ProductcomboBox2 = new System.Windows.Forms.ComboBox();
            this.LocationcomboBox1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LocationLabel1 = new System.Windows.Forms.Label();
            this.Savebutton1 = new System.Windows.Forms.Button();
            this.removebutton2 = new System.Windows.Forms.Button();
            this.scaletextBox1 = new System.Windows.Forms.TextBox();
            this.UnitInStocktextBox1 = new System.Windows.Forms.TextBox();
            this.UnitInOrdertextBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.EditProductdataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // EditProductdataGridView1
            // 
            this.EditProductdataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EditProductdataGridView1.Location = new System.Drawing.Point(254, 46);
            this.EditProductdataGridView1.Name = "EditProductdataGridView1";
            this.EditProductdataGridView1.RowTemplate.Height = 25;
            this.EditProductdataGridView1.Size = new System.Drawing.Size(534, 377);
            this.EditProductdataGridView1.TabIndex = 2;
            // 
            // PackagecomboBox3
            // 
            this.PackagecomboBox3.FormattingEnabled = true;
            this.PackagecomboBox3.Location = new System.Drawing.Point(101, 165);
            this.PackagecomboBox3.Name = "PackagecomboBox3";
            this.PackagecomboBox3.Size = new System.Drawing.Size(121, 23);
            this.PackagecomboBox3.TabIndex = 23;
            this.PackagecomboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // ProductcomboBox2
            // 
            this.ProductcomboBox2.FormattingEnabled = true;
            this.ProductcomboBox2.Location = new System.Drawing.Point(101, 132);
            this.ProductcomboBox2.Name = "ProductcomboBox2";
            this.ProductcomboBox2.Size = new System.Drawing.Size(121, 23);
            this.ProductcomboBox2.TabIndex = 22;
            this.ProductcomboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // LocationcomboBox1
            // 
            this.LocationcomboBox1.FormattingEnabled = true;
            this.LocationcomboBox1.Location = new System.Drawing.Point(101, 103);
            this.LocationcomboBox1.Name = "LocationcomboBox1";
            this.LocationcomboBox1.Size = new System.Drawing.Size(121, 23);
            this.LocationcomboBox1.TabIndex = 21;
            this.LocationcomboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 254);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 15);
            this.label5.TabIndex = 20;
            this.label5.Text = "Unit In Order:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 15);
            this.label4.TabIndex = 19;
            this.label4.Text = "UnitInStock:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 18;
            this.label3.Text = "Scale:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 15);
            this.label2.TabIndex = 17;
            this.label2.Text = "Package:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 16;
            this.label1.Text = "Product:";
            // 
            // LocationLabel1
            // 
            this.LocationLabel1.AutoSize = true;
            this.LocationLabel1.Location = new System.Drawing.Point(26, 103);
            this.LocationLabel1.Name = "LocationLabel1";
            this.LocationLabel1.Size = new System.Drawing.Size(56, 15);
            this.LocationLabel1.TabIndex = 15;
            this.LocationLabel1.Text = "Location:";
            // 
            // Savebutton1
            // 
            this.Savebutton1.Location = new System.Drawing.Point(60, 297);
            this.Savebutton1.Name = "Savebutton1";
            this.Savebutton1.Size = new System.Drawing.Size(123, 38);
            this.Savebutton1.TabIndex = 30;
            this.Savebutton1.Text = "Save changes";
            this.Savebutton1.UseVisualStyleBackColor = true;
            this.Savebutton1.Click += new System.EventHandler(this.Savebutton1_Click);
            // 
            // removebutton2
            // 
            this.removebutton2.Location = new System.Drawing.Point(60, 341);
            this.removebutton2.Name = "removebutton2";
            this.removebutton2.Size = new System.Drawing.Size(123, 38);
            this.removebutton2.TabIndex = 31;
            this.removebutton2.Text = "Remove Product";
            this.removebutton2.UseVisualStyleBackColor = true;
            this.removebutton2.Click += new System.EventHandler(this.button2_Click);
            // 
            // scaletextBox1
            // 
            this.scaletextBox1.Location = new System.Drawing.Point(101, 195);
            this.scaletextBox1.Name = "scaletextBox1";
            this.scaletextBox1.ReadOnly = true;
            this.scaletextBox1.Size = new System.Drawing.Size(121, 23);
            this.scaletextBox1.TabIndex = 32;
            // 
            // UnitInStocktextBox1
            // 
            this.UnitInStocktextBox1.Location = new System.Drawing.Point(101, 223);
            this.UnitInStocktextBox1.Name = "UnitInStocktextBox1";
            this.UnitInStocktextBox1.Size = new System.Drawing.Size(121, 23);
            this.UnitInStocktextBox1.TabIndex = 33;
            // 
            // UnitInOrdertextBox2
            // 
            this.UnitInOrdertextBox2.Location = new System.Drawing.Point(101, 251);
            this.UnitInOrdertextBox2.Name = "UnitInOrdertextBox2";
            this.UnitInOrdertextBox2.Size = new System.Drawing.Size(121, 23);
            this.UnitInOrdertextBox2.TabIndex = 34;
            // 
            // EditProductUserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SupplyProgramUi.Properties.Resources.usercontrols_screens;
            this.Controls.Add(this.UnitInOrdertextBox2);
            this.Controls.Add(this.UnitInStocktextBox1);
            this.Controls.Add(this.scaletextBox1);
            this.Controls.Add(this.removebutton2);
            this.Controls.Add(this.Savebutton1);
            this.Controls.Add(this.PackagecomboBox3);
            this.Controls.Add(this.ProductcomboBox2);
            this.Controls.Add(this.LocationcomboBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LocationLabel1);
            this.Controls.Add(this.EditProductdataGridView1);
            this.Name = "EditProductUserControl1";
            this.Size = new System.Drawing.Size(800, 444);
            ((System.ComponentModel.ISupportInitialize)(this.EditProductdataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView EditProductdataGridView1;
        private System.Windows.Forms.ComboBox PackagecomboBox3;
        private System.Windows.Forms.ComboBox ProductcomboBox2;
        private System.Windows.Forms.ComboBox LocationcomboBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LocationLabel1;
        private System.Windows.Forms.Button Savebutton1;
        private System.Windows.Forms.Button removebutton2;
        private System.Windows.Forms.TextBox scaletextBox1;
        private System.Windows.Forms.TextBox UnitInStocktextBox1;
        private System.Windows.Forms.TextBox UnitInOrdertextBox2;
    }
}
