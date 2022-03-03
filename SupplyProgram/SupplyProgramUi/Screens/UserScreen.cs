using System;
using DataBase.SupplyData;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using SupplyProgramUi.UserUserControls;
using SupplyProgarmOperations;

namespace SupplyProgramUi
{
    public partial class UserScreen : Form
    {
        Normaluser normalUser = new Normaluser();
        public Action<DataGridView> GetFullProductTable = (data) =>
        {
            using (var db = new SuplyProgramContext())
            {

                var qur = from l in db.ProductStatus1s
                          join l1 in db.Locations on l.LocationId equals l1.LocationId
                          join l2 in db.Products on l.ProductId equals l2.ProductId
                          join l3 in db.Packages on l.PackageId equals l3.PackageId
                          join l4 in db.ScaleValues on l3.ScaleId equals l4.ScaleId
                          select new FullProductclass
                          {
                              Id = l.StatusId,
                              Location = l1.Location1,
                              Product = l2.ProductName,
                              Package = l3.PackageType,
                              Scale = l4.ScalesTypes,
                              UnitInStock = l.UnitInstock,
                              UnitInOrder = l.UnitinOrder
                          };
                data.DataSource = qur.ToList();

            };
        };
        public UserScreen()
        {
            InitializeComponent();
            GetFullProductTable(OperationsdataGridView1);

        }
        Timer timer = new Timer();
        private void UserScreen_Load(object sender, EventArgs e)
        {
            timer.Interval = 5000;
            timer.Tick += (object ms, EventArgs argss) =>
            {
                MeassgesLabel1.Text = "";
                timer.Stop();
            };
        }





        private void MainScreen_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            var openform = new Openform();
            openform.ShowDialog();
            this.Close();
        }

        private void Addbutton1_Click(object sender, EventArgs e)
        {
            Userpanel1.Controls.Clear();
            useraddfullproductUserControl1 useraddfullproductUserControl1 = new useraddfullproductUserControl1();
            useraddfullproductUserControl1.Parent = Userpanel1;
            useraddfullproductUserControl1.ProductChanged += (newproduct) =>
            {
                MeassgesLabel1.Text = newproduct;
                timer.Start();
                OperationsdataGridView1.DataSource = normalUser.GetFullProductStorageTable();

            };
            useraddfullproductUserControl1.SaveAndExit += () =>
             {
                 Userpanel1.Controls.Clear();
                 MeassgesLabel1.Text = "Saved Successfuly";
                 timer.Start();
             };
        }

        private void Editbutton4_Click(object sender, EventArgs e)
        {
            Userpanel1.Controls.Clear();
            userEditProductsUserControl1 userEditProducts = new userEditProductsUserControl1();
            userEditProducts.Parent = Userpanel1;
            userEditProducts.ProductChanged += (newproduct) =>
             {
                 MeassgesLabel1.Text = newproduct;
                 timer.Start();
                 OperationsdataGridView1.DataSource = normalUser.GetFullProductStorageTable();
             };
            userEditProducts.SaveAndExit += () =>
             {
                 Userpanel1.Controls.Clear();
                 MeassgesLabel1.Text = "Saved Successfuly";
                 timer.Start();
             };

        }

        private void ChangeStoragebutton3_Click(object sender, EventArgs e)
        {
            Userpanel1.Controls.Clear();
            userSortUserControl1 userSortUserControl1 = new userSortUserControl1();
            userSortUserControl1.Parent = Userpanel1;
            userSortUserControl1.sortedtable += (term, list) =>
             {
                 OperationsdataGridView1.DataSource = list;
                 MeassgesLabel1.Text = $"Sorted by {term.Text}";
                 timer.Start();


             };
            userSortUserControl1.SaveAndExit += () =>
             {
                 Userpanel1.Controls.Clear();
                 MeassgesLabel1.Text = "Saved Successfuly";
                 timer.Start();
             };

        }

        private void Exitbutton1_Click(object sender, EventArgs e)
        {
            Openform.ThisForm.Visible = true;
            this.Close();
        }
    }
}
