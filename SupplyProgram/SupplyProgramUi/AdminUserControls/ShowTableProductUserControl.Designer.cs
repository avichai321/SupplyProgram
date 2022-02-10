namespace SupplyProgramUi.AdminUserControls
{
    partial class ShowTableProductUserControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowTableProductUserControl));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.LocationlistcomboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Sortbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(263, 45);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(534, 377);
            this.dataGridView1.TabIndex = 1;
            // 
            // LocationlistcomboBox1
            // 
            this.LocationlistcomboBox1.FormattingEnabled = true;
            this.LocationlistcomboBox1.Location = new System.Drawing.Point(101, 103);
            this.LocationlistcomboBox1.Name = "LocationlistcomboBox1";
            this.LocationlistcomboBox1.Size = new System.Drawing.Size(119, 23);
            this.LocationlistcomboBox1.TabIndex = 2;
            this.LocationlistcomboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "location list";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Sortbutton
            // 
            this.Sortbutton.Location = new System.Drawing.Point(78, 159);
            this.Sortbutton.Name = "Sortbutton";
            this.Sortbutton.Size = new System.Drawing.Size(106, 38);
            this.Sortbutton.TabIndex = 4;
            this.Sortbutton.Text = "Sort";
            this.Sortbutton.UseVisualStyleBackColor = true;
            this.Sortbutton.Click += new System.EventHandler(this.Sortbutton_Click);
            // 
            // ShowTableProductUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.Sortbutton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LocationlistcomboBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ShowTableProductUserControl";
            this.Size = new System.Drawing.Size(800, 444);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox LocationlistcomboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Sortbutton;
    }
}
