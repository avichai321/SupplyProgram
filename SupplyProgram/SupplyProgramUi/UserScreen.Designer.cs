namespace SupplyProgramUi
{
    partial class UserScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserScreen));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Exitbutton1 = new System.Windows.Forms.Button();
            this.Editbutton4 = new System.Windows.Forms.Button();
            this.ChangeStoragebutton3 = new System.Windows.Forms.Button();
            this.Addbutton1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.MeassgesLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(150, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(269, 423);
            this.panel1.TabIndex = 0;
            // 
            // Exitbutton1
            // 
            this.Exitbutton1.Location = new System.Drawing.Point(12, 165);
            this.Exitbutton1.Name = "Exitbutton1";
            this.Exitbutton1.Size = new System.Drawing.Size(132, 45);
            this.Exitbutton1.TabIndex = 4;
            this.Exitbutton1.Text = "Save and Exit";
            this.Exitbutton1.UseVisualStyleBackColor = true;
            this.Exitbutton1.Click += new System.EventHandler(this.Exitbutton1_Click);
            // 
            // Editbutton4
            // 
            this.Editbutton4.Location = new System.Drawing.Point(12, 63);
            this.Editbutton4.Name = "Editbutton4";
            this.Editbutton4.Size = new System.Drawing.Size(132, 45);
            this.Editbutton4.TabIndex = 3;
            this.Editbutton4.Text = "Edit Products";
            this.Editbutton4.UseVisualStyleBackColor = true;
            this.Editbutton4.Click += new System.EventHandler(this.Editbutton4_Click);
            // 
            // ChangeStoragebutton3
            // 
            this.ChangeStoragebutton3.Location = new System.Drawing.Point(12, 114);
            this.ChangeStoragebutton3.Name = "ChangeStoragebutton3";
            this.ChangeStoragebutton3.Size = new System.Drawing.Size(132, 45);
            this.ChangeStoragebutton3.TabIndex = 2;
            this.ChangeStoragebutton3.Text = "Sort Storage";
            this.ChangeStoragebutton3.UseVisualStyleBackColor = true;
            this.ChangeStoragebutton3.Click += new System.EventHandler(this.ChangeStoragebutton3_Click);
            // 
            // Addbutton1
            // 
            this.Addbutton1.Location = new System.Drawing.Point(12, 12);
            this.Addbutton1.Name = "Addbutton1";
            this.Addbutton1.Size = new System.Drawing.Size(132, 45);
            this.Addbutton1.TabIndex = 0;
            this.Addbutton1.Text = "Add New Product";
            this.Addbutton1.UseVisualStyleBackColor = true;
            this.Addbutton1.Click += new System.EventHandler(this.Addbutton1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(425, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(504, 423);
            this.dataGridView1.TabIndex = 1;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MeassgesLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 438);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(941, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // MeassgesLabel1
            // 
            this.MeassgesLabel1.Name = "MeassgesLabel1";
            this.MeassgesLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // UserScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(941, 460);
            this.Controls.Add(this.Exitbutton1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.Editbutton4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ChangeStoragebutton3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Addbutton1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UserScreen";
            this.Text = "User Screen";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainScreen_FormClosed);
            this.Load += new System.EventHandler(this.UserScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Editbutton4;
        private System.Windows.Forms.Button ChangeStoragebutton3;
        private System.Windows.Forms.Button Addbutton1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel MeassgesLabel1;
        private System.Windows.Forms.Button Exitbutton1;
    }
}