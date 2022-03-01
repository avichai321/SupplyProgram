namespace SupplyProgramUi.AdminUserControls
{
    partial class AddToProductListUserControl
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
            this.ProductdataGridView1 = new System.Windows.Forms.DataGridView();
            this.addProducttextBox1 = new System.Windows.Forms.TextBox();
            this.Productlabel1 = new System.Windows.Forms.Label();
            this.addproducttodatabasebutton1 = new System.Windows.Forms.Button();
            this.removeproductlabel2 = new System.Windows.Forms.Label();
            this.RemoveProductbutton1 = new System.Windows.Forms.Button();
            this.removecomboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.ProductdataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ProductdataGridView1
            // 
            this.ProductdataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductdataGridView1.Location = new System.Drawing.Point(332, 48);
            this.ProductdataGridView1.Name = "ProductdataGridView1";
            this.ProductdataGridView1.RowTemplate.Height = 25;
            this.ProductdataGridView1.Size = new System.Drawing.Size(479, 328);
            this.ProductdataGridView1.TabIndex = 1;
            // 
            // addProducttextBox1
            // 
            this.addProducttextBox1.Location = new System.Drawing.Point(135, 109);
            this.addProducttextBox1.Name = "addProducttextBox1";
            this.addProducttextBox1.Size = new System.Drawing.Size(148, 23);
            this.addProducttextBox1.TabIndex = 2;
            // 
            // Productlabel1
            // 
            this.Productlabel1.AutoSize = true;
            this.Productlabel1.Location = new System.Drawing.Point(15, 109);
            this.Productlabel1.Name = "Productlabel1";
            this.Productlabel1.Size = new System.Drawing.Size(114, 15);
            this.Productlabel1.TabIndex = 3;
            this.Productlabel1.Text = "New Product Name:";
            // 
            // addproducttodatabasebutton1
            // 
            this.addproducttodatabasebutton1.Location = new System.Drawing.Point(135, 150);
            this.addproducttodatabasebutton1.Name = "addproducttodatabasebutton1";
            this.addproducttodatabasebutton1.Size = new System.Drawing.Size(148, 31);
            this.addproducttodatabasebutton1.TabIndex = 4;
            this.addproducttodatabasebutton1.Text = "Add To DataBase";
            this.addproducttodatabasebutton1.UseVisualStyleBackColor = true;
            this.addproducttodatabasebutton1.Click += new System.EventHandler(this.addproducttodatabasebutton1_Click);
            // 
            // removeproductlabel2
            // 
            this.removeproductlabel2.AutoSize = true;
            this.removeproductlabel2.Location = new System.Drawing.Point(15, 251);
            this.removeproductlabel2.Name = "removeproductlabel2";
            this.removeproductlabel2.Size = new System.Drawing.Size(98, 15);
            this.removeproductlabel2.TabIndex = 5;
            this.removeproductlabel2.Text = "Remove Product:";
            // 
            // RemoveProductbutton1
            // 
            this.RemoveProductbutton1.Location = new System.Drawing.Point(135, 291);
            this.RemoveProductbutton1.Name = "RemoveProductbutton1";
            this.RemoveProductbutton1.Size = new System.Drawing.Size(148, 31);
            this.RemoveProductbutton1.TabIndex = 6;
            this.RemoveProductbutton1.Text = "Remove From DataBase";
            this.RemoveProductbutton1.UseVisualStyleBackColor = true;
            this.RemoveProductbutton1.Click += new System.EventHandler(this.button1_Click);
            // 
            // removecomboBox1
            // 
            this.removecomboBox1.FormattingEnabled = true;
            this.removecomboBox1.Location = new System.Drawing.Point(135, 248);
            this.removecomboBox1.Name = "removecomboBox1";
            this.removecomboBox1.Size = new System.Drawing.Size(148, 23);
            this.removecomboBox1.TabIndex = 7;
            // 
            // AddToProductListUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SupplyProgramUi.Properties.Resources.usercontrols_screens;
            this.Controls.Add(this.removecomboBox1);
            this.Controls.Add(this.RemoveProductbutton1);
            this.Controls.Add(this.removeproductlabel2);
            this.Controls.Add(this.addproducttodatabasebutton1);
            this.Controls.Add(this.Productlabel1);
            this.Controls.Add(this.addProducttextBox1);
            this.Controls.Add(this.ProductdataGridView1);
            this.Name = "AddToProductListUserControl";
            this.Size = new System.Drawing.Size(814, 476);
            ((System.ComponentModel.ISupportInitialize)(this.ProductdataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ProductdataGridView1;
        private System.Windows.Forms.TextBox addProducttextBox1;
        private System.Windows.Forms.Label Productlabel1;
        private System.Windows.Forms.Button addproducttodatabasebutton1;
        private System.Windows.Forms.Label removeproductlabel2;
        private System.Windows.Forms.Button RemoveProductbutton1;
        private System.Windows.Forms.ComboBox removecomboBox1;
    }
}
