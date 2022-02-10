namespace SupplyProgramUi
{
    partial class ShowTableUserControl1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowTableUserControl1));
            this.UserdataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.UserdataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // UserdataGridView1
            // 
            this.UserdataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UserdataGridView1.Location = new System.Drawing.Point(3, 25);
            this.UserdataGridView1.Name = "UserdataGridView1";
            this.UserdataGridView1.RowTemplate.Height = 25;
            this.UserdataGridView1.Size = new System.Drawing.Size(794, 400);
            this.UserdataGridView1.TabIndex = 0;
            // 
            // ShowTableUserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.UserdataGridView1);
            this.Name = "ShowTableUserControl1";
            this.Size = new System.Drawing.Size(800, 444);
            ((System.ComponentModel.ISupportInitialize)(this.UserdataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView UserdataGridView1;
    }
}
