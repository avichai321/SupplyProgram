using SupplyProgramUi.AdminUserControls;
using SupplyProgramUi.UserUserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SupplyProgramUi
{
    public partial class AdminScreen : Form
    {
        public AdminScreen()
        {
            InitializeComponent();
        }
        Timer timer = new Timer();
        private void UserMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Openform.ThisForm.Visible = true;
        }

        private void AdminScreen_Load(object sender, EventArgs e)
        {
            timer.Interval = 5000;
            timer.Tick += (object ms, EventArgs argss) =>
            {
                MeassgesLabel1.Text = "";
                timer.Stop();
            };
        }

        private void addNewUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            AddUserUserControl addUserControl = new AddUserUserControl();
            addUserControl.Parent = panel1;
            addUserControl.UserChanged += (newuser) =>
            {
                MeassgesLabel1.Text = newuser;
                timer.Start();
            };
            addUserControl.SaveAndExit += () =>
            {
                panel1.Controls.Clear();
                MeassgesLabel1.Text = "Saved Succefully";
                timer.Start();
            };
        }

        private void removeUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            ShowTableUserControl1 showTableUserControl = new ShowTableUserControl1();
            showTableUserControl.Parent = panel1;
        }

        private void addToProductListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            AddToProductListUserControl addToProductListUserControl1 = new AddToProductListUserControl();
            addToProductListUserControl1.Parent = panel1;
            addToProductListUserControl1.ProductChanged += (newproduct) =>
             {
                 MeassgesLabel1.Text = newproduct;
                 timer.Start();
             };

        }

        private void addToLocationTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            AddLocationToDataBaseUserControl1 addLocationToDataBaseUserControl1 = new AddLocationToDataBaseUserControl1();
            addLocationToDataBaseUserControl1.Parent = panel1;
            addLocationToDataBaseUserControl1.locationChanged += (newlocation) =>
            {
                MeassgesLabel1.Text = newlocation;
                timer.Start();
            };
        }

        private void addToPackageTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            AddPackageUserControl1 addPackageUserControl1 = new AddPackageUserControl1();
            addPackageUserControl1.Parent = panel1;
            addPackageUserControl1.packageChanged += (newpackage) =>
             {
                 MeassgesLabel1.Text = newpackage;
                 timer.Start();
             };
        }

        private void addNewPruductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            addFullProductToStorageUserControl1 addFullProduct = new addFullProductToStorageUserControl1();
            addFullProduct.Parent = panel1;
            addFullProduct.ProductChanged += (newproduct) =>
              {
                  MeassgesLabel1.Text = newproduct;
                  timer.Start();
              };
            addFullProduct.SaveAndExit += () =>
            {
                panel1.Controls.Clear();
                MeassgesLabel1.Text = "Saved Succefully";
                timer.Start();
            };

        }

        private void showAllTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            ShowTableProductUserControl showTableProductUserControl = new ShowTableProductUserControl();
            showTableProductUserControl.Parent = panel1;
            showTableProductUserControl.sortTable += (list,storage,data) =>
             {
                 MeassgesLabel1.Text = $"Sorted by {storage.Text}";
                 timer.Start();
             };
        }

        private void editProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            EditProductUserControl1 editProductUserControl1 =new EditProductUserControl1();
            editProductUserControl1.Parent = panel1;
            editProductUserControl1.ProductChanged += (newproduct) =>
             {
                 MeassgesLabel1.Text = newproduct;
                 timer.Start();
             };
        }
    }
}
