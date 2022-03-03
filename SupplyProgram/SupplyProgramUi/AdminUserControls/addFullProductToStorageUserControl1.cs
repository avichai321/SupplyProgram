using DataBase.SupplyData;
using SupplyProgarmOperations;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace SupplyProgramUi.UserUserControls
{
    public partial class addFullProductToStorageUserControl1 : UserControl
    {
        Adminuser adminuser = new Adminuser();
        public event Action<string> ProductChanged;
        public event Action SaveAndExit;
        private Action<ComboBox, ComboBox, ComboBox> fillcomboboxes = (locationbox, productbox, packagebox) =>
        {
            using (var db = new SuplyProgramContext())
            {
                var productlist = db.Products.Select(p => p).ToList();
                var locationlist = db.Locations.Select(l => l).ToList();
                var packagelist = db.Packages.Select(pa => pa).ToList();

                foreach (var product in productlist)
                {
                    productbox.Items.Add(product.ProductName);
                }
                foreach (var location in locationlist)
                {
                    locationbox.Items.Add(location.Location1);
                }
                foreach (var package in packagelist)
                {
                    packagebox.Items.Add(package.PackageType);
                }

            }
        };
        private Action<ComboBox, TextBox> updatescalebox = (packagebox, scaletext) =>
         {
             using (var db = new SuplyProgramContext())
             {
                 if (packagebox != null)
                 {
                 var packagelist = db.Packages.Where(p=>p.PackageType==packagebox.Text).Select(p=>p).First();
                 var scale = db.ScaleValues.Where(s => s.ScaleId == packagelist.ScaleId).Select(s => s.ScalesTypes).First();
                 scaletext.Text = scale;
                 }
                 else
                 {
                     scaletext.Text = "";
                 }
                 
             }
         };
        public addFullProductToStorageUserControl1()
        {
            InitializeComponent();
            fillcomboboxes(LocationcomboBox1,ProductcomboBox2,PackagecomboBox3);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var result=adminuser.AddProductToStorage(LocationcomboBox1.Text,ProductcomboBox2.Text,PackagecomboBox3.Text,Convert.ToInt32(UnitInStocknumericUpDown1.Value), Convert.ToInt32(UnitInOrdernumericUpDown2.Value));
            ProductChanged(result);
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            updatescalebox(PackagecomboBox3, scaletextBox1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (var db = new SuplyProgramContext())
            {
                db.SaveChanges();
                SaveAndExit();

            }
            
        }
    }
}
