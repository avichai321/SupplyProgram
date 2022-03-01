namespace SupplyProgramUi.AdminUserControls
{
    partial class AddLocationToDataBaseUserControl1
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
            this.removelocationcomboBox1 = new System.Windows.Forms.ComboBox();
            this.removelocationfromdatabasebutton1 = new System.Windows.Forms.Button();
            this.removeproductlabel2 = new System.Windows.Forms.Label();
            this.addlocationtodatabasebutton1 = new System.Windows.Forms.Button();
            this.NewLocationlabel1 = new System.Windows.Forms.Label();
            this.addLocationtextBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // removelocationcomboBox1
            // 
            this.removelocationcomboBox1.FormattingEnabled = true;
            this.removelocationcomboBox1.Location = new System.Drawing.Point(136, 258);
            this.removelocationcomboBox1.Name = "removelocationcomboBox1";
            this.removelocationcomboBox1.Size = new System.Drawing.Size(148, 23);
            this.removelocationcomboBox1.TabIndex = 14;
            // 
            // removelocationfromdatabasebutton1
            // 
            this.removelocationfromdatabasebutton1.Location = new System.Drawing.Point(136, 301);
            this.removelocationfromdatabasebutton1.Name = "removelocationfromdatabasebutton1";
            this.removelocationfromdatabasebutton1.Size = new System.Drawing.Size(148, 31);
            this.removelocationfromdatabasebutton1.TabIndex = 13;
            this.removelocationfromdatabasebutton1.Text = "Remove From DataBase";
            this.removelocationfromdatabasebutton1.UseVisualStyleBackColor = true;
            this.removelocationfromdatabasebutton1.Click += new System.EventHandler(this.removelocationfromdatabasebutton1_Click);
            // 
            // removeproductlabel2
            // 
            this.removeproductlabel2.AutoSize = true;
            this.removeproductlabel2.Location = new System.Drawing.Point(16, 261);
            this.removeproductlabel2.Name = "removeproductlabel2";
            this.removeproductlabel2.Size = new System.Drawing.Size(102, 15);
            this.removeproductlabel2.TabIndex = 12;
            this.removeproductlabel2.Text = "Remove Location:";
            // 
            // addlocationtodatabasebutton1
            // 
            this.addlocationtodatabasebutton1.Location = new System.Drawing.Point(136, 160);
            this.addlocationtodatabasebutton1.Name = "addlocationtodatabasebutton1";
            this.addlocationtodatabasebutton1.Size = new System.Drawing.Size(148, 31);
            this.addlocationtodatabasebutton1.TabIndex = 11;
            this.addlocationtodatabasebutton1.Text = "Add To DataBase";
            this.addlocationtodatabasebutton1.UseVisualStyleBackColor = true;
            this.addlocationtodatabasebutton1.Click += new System.EventHandler(this.addlocationtodatabasebutton1_Click);
            // 
            // NewLocationlabel1
            // 
            this.NewLocationlabel1.AutoSize = true;
            this.NewLocationlabel1.Location = new System.Drawing.Point(16, 119);
            this.NewLocationlabel1.Name = "NewLocationlabel1";
            this.NewLocationlabel1.Size = new System.Drawing.Size(118, 15);
            this.NewLocationlabel1.TabIndex = 10;
            this.NewLocationlabel1.Text = "New Location Name:";
            // 
            // addLocationtextBox1
            // 
            this.addLocationtextBox1.Location = new System.Drawing.Point(136, 119);
            this.addLocationtextBox1.Name = "addLocationtextBox1";
            this.addLocationtextBox1.Size = new System.Drawing.Size(148, 23);
            this.addLocationtextBox1.TabIndex = 9;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(333, 72);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(471, 328);
            this.dataGridView1.TabIndex = 8;
            // 
            // AddLocationToDataBaseUserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SupplyProgramUi.Properties.Resources.usercontrols_screens;
            this.Controls.Add(this.removelocationcomboBox1);
            this.Controls.Add(this.removelocationfromdatabasebutton1);
            this.Controls.Add(this.removeproductlabel2);
            this.Controls.Add(this.addlocationtodatabasebutton1);
            this.Controls.Add(this.NewLocationlabel1);
            this.Controls.Add(this.addLocationtextBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "AddLocationToDataBaseUserControl1";
            this.Size = new System.Drawing.Size(807, 491);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox removelocationcomboBox1;
        private System.Windows.Forms.Button removelocationfromdatabasebutton1;
        private System.Windows.Forms.Label removeproductlabel2;
        private System.Windows.Forms.Button addlocationtodatabasebutton1;
        private System.Windows.Forms.Label NewLocationlabel1;
        private System.Windows.Forms.TextBox addLocationtextBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
