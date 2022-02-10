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
            this.Userpanel1 = new System.Windows.Forms.Panel();
            this.Exitbutton1 = new System.Windows.Forms.Button();
            this.Editbutton4 = new System.Windows.Forms.Button();
            this.SortStoragebutton3 = new System.Windows.Forms.Button();
            this.Addbutton1 = new System.Windows.Forms.Button();
            this.OperationsdataGridView1 = new System.Windows.Forms.DataGridView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.MeassgesLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.OperationsdataGridView1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Userpanel1
            // 
            this.Userpanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Userpanel1.BackgroundImage")));
            this.Userpanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Userpanel1.Location = new System.Drawing.Point(150, 12);
            this.Userpanel1.Name = "Userpanel1";
            this.Userpanel1.Size = new System.Drawing.Size(269, 423);
            this.Userpanel1.TabIndex = 0;
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
            // SortStoragebutton3
            // 
            this.SortStoragebutton3.Location = new System.Drawing.Point(12, 114);
            this.SortStoragebutton3.Name = "SortStoragebutton3";
            this.SortStoragebutton3.Size = new System.Drawing.Size(132, 45);
            this.SortStoragebutton3.TabIndex = 2;
            this.SortStoragebutton3.Text = "Sort Storage";
            this.SortStoragebutton3.UseVisualStyleBackColor = true;
            this.SortStoragebutton3.Click += new System.EventHandler(this.ChangeStoragebutton3_Click);
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
            // OperationsdataGridView1
            // 
            this.OperationsdataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OperationsdataGridView1.Location = new System.Drawing.Point(425, 12);
            this.OperationsdataGridView1.Name = "OperationsdataGridView1";
            this.OperationsdataGridView1.RowTemplate.Height = 25;
            this.OperationsdataGridView1.Size = new System.Drawing.Size(504, 423);
            this.OperationsdataGridView1.TabIndex = 1;
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
            this.Controls.Add(this.OperationsdataGridView1);
            this.Controls.Add(this.SortStoragebutton3);
            this.Controls.Add(this.Userpanel1);
            this.Controls.Add(this.Addbutton1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UserScreen";
            this.Text = "User Screen";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainScreen_FormClosed);
            this.Load += new System.EventHandler(this.UserScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.OperationsdataGridView1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Userpanel1;
        private System.Windows.Forms.Button Editbutton4;
        private System.Windows.Forms.Button SortStoragebutton3;
        private System.Windows.Forms.Button Addbutton1;
        private System.Windows.Forms.DataGridView OperationsdataGridView1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel MeassgesLabel1;
        private System.Windows.Forms.Button Exitbutton1;
    }
}