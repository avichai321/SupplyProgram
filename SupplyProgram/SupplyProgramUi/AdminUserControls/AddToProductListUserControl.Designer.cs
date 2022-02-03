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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddToProductListUserControl));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.addProducttextBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.addproducttodatabasebutton1 = new System.Windows.Forms.Button();
            this.removeproductlabel2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.removecomboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(332, 48);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(479, 328);
            this.dataGridView1.TabIndex = 1;
            // 
            // addProducttextBox1
            // 
            this.addProducttextBox1.Location = new System.Drawing.Point(135, 109);
            this.addProducttextBox1.Name = "addProducttextBox1";
            this.addProducttextBox1.Size = new System.Drawing.Size(148, 23);
            this.addProducttextBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "New Product Name:";
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(135, 291);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 31);
            this.button1.TabIndex = 6;
            this.button1.Text = "Remove From DataBase";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.removecomboBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.removeproductlabel2);
            this.Controls.Add(this.addproducttodatabasebutton1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addProducttextBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "AddToProductListUserControl";
            this.Size = new System.Drawing.Size(814, 476);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox addProducttextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addproducttodatabasebutton1;
        private System.Windows.Forms.Label removeproductlabel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox removecomboBox1;
    }
}
