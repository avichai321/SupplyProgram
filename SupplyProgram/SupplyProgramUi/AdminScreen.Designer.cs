namespace SupplyProgramUi
{
    partial class AdminScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminScreen));
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addItemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToProductListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToLocationTableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToPackageTableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.storageStatusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewPruductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showAllTableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.MeassgesLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::SupplyProgramUi.Properties.Resources.Manage_screen;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usersToolStripMenuItem,
            this.addItemsToolStripMenuItem,
            this.storageStatusToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewUserToolStripMenuItem,
            this.removeUserToolStripMenuItem});
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.usersToolStripMenuItem.Text = "Users";
            // 
            // addNewUserToolStripMenuItem
            // 
            this.addNewUserToolStripMenuItem.Name = "addNewUserToolStripMenuItem";
            this.addNewUserToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.addNewUserToolStripMenuItem.Text = "Users Mannger";
            this.addNewUserToolStripMenuItem.Click += new System.EventHandler(this.addNewUserToolStripMenuItem_Click);
            // 
            // removeUserToolStripMenuItem
            // 
            this.removeUserToolStripMenuItem.Name = "removeUserToolStripMenuItem";
            this.removeUserToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.removeUserToolStripMenuItem.Text = "Show Users Table";
            this.removeUserToolStripMenuItem.Click += new System.EventHandler(this.removeUserToolStripMenuItem_Click);
            // 
            // addItemsToolStripMenuItem
            // 
            this.addItemsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToProductListToolStripMenuItem,
            this.addToLocationTableToolStripMenuItem,
            this.addToPackageTableToolStripMenuItem});
            this.addItemsToolStripMenuItem.Name = "addItemsToolStripMenuItem";
            this.addItemsToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.addItemsToolStripMenuItem.Text = "DataBase";
            // 
            // addToProductListToolStripMenuItem
            // 
            this.addToProductListToolStripMenuItem.Name = "addToProductListToolStripMenuItem";
            this.addToProductListToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.addToProductListToolStripMenuItem.Text = "Manage Product Table";
            this.addToProductListToolStripMenuItem.Click += new System.EventHandler(this.addToProductListToolStripMenuItem_Click);
            // 
            // addToLocationTableToolStripMenuItem
            // 
            this.addToLocationTableToolStripMenuItem.Name = "addToLocationTableToolStripMenuItem";
            this.addToLocationTableToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.addToLocationTableToolStripMenuItem.Text = "Manage To Location Table";
            this.addToLocationTableToolStripMenuItem.Click += new System.EventHandler(this.addToLocationTableToolStripMenuItem_Click);
            // 
            // addToPackageTableToolStripMenuItem
            // 
            this.addToPackageTableToolStripMenuItem.Name = "addToPackageTableToolStripMenuItem";
            this.addToPackageTableToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.addToPackageTableToolStripMenuItem.Text = "Manage To Package Table";
            this.addToPackageTableToolStripMenuItem.Click += new System.EventHandler(this.addToPackageTableToolStripMenuItem_Click);
            // 
            // storageStatusToolStripMenuItem
            // 
            this.storageStatusToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewPruductToolStripMenuItem,
            this.editProductToolStripMenuItem,
            this.showAllTableToolStripMenuItem});
            this.storageStatusToolStripMenuItem.Name = "storageStatusToolStripMenuItem";
            this.storageStatusToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
            this.storageStatusToolStripMenuItem.Text = "StorageStatus";
            // 
            // addNewPruductToolStripMenuItem
            // 
            this.addNewPruductToolStripMenuItem.Name = "addNewPruductToolStripMenuItem";
            this.addNewPruductToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.addNewPruductToolStripMenuItem.Text = "Add product";
            this.addNewPruductToolStripMenuItem.Click += new System.EventHandler(this.addNewPruductToolStripMenuItem_Click);
            // 
            // editProductToolStripMenuItem
            // 
            this.editProductToolStripMenuItem.Name = "editProductToolStripMenuItem";
            this.editProductToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.editProductToolStripMenuItem.Text = "Edit Product";
            this.editProductToolStripMenuItem.Click += new System.EventHandler(this.editProductToolStripMenuItem_Click);
            // 
            // showAllTableToolStripMenuItem
            // 
            this.showAllTableToolStripMenuItem.Name = "showAllTableToolStripMenuItem";
            this.showAllTableToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.showAllTableToolStripMenuItem.Text = "Show All table";
            this.showAllTableToolStripMenuItem.Click += new System.EventHandler(this.showAllTableToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MeassgesLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // MeassgesLabel1
            // 
            this.MeassgesLabel1.Name = "MeassgesLabel1";
            this.MeassgesLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // AdminScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AdminScreen";
            this.Text = "Admin Menu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UserMenu_FormClosed);
            this.Load += new System.EventHandler(this.AdminScreen_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addItemsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToProductListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToLocationTableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToPackageTableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem storageStatusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewPruductToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editProductToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showAllTableToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel MeassgesLabel1;
    }
}