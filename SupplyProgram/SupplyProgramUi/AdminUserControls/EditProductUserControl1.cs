using DataBase.SupplyData;
using SupplyProgarmOperations;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace SupplyProgramUi.UserUserControls
{
    public partial class EditProductUserControl1 : UserControl
    {
        Adminuser adminuser = new Adminuser();
        private Action<ComboBox> updateLocationbox = (locate) =>
         {

             using (var db = new SuplyProgramContext())
             {
                 var qur = db.Locations.Select(l => l.Location1).ToList();
                 foreach (var location in qur)
                 {
                     locate.Items.Add(location);
                 }
             }
         };
        private Action<ComboBox, ComboBox, List<FullProductclass>> updateproductbox = (locate, product, list) =>
           {
               using (var db = new SuplyProgramContext())
               {
                   if (locate.Text != "")
                   {
                       foreach (var item in list)
                       {
                           if (item.Location == locate.Text)
                           {
                               if (!product.Items.Contains(item.Product))
                               {
                                   product.Items.Add(item.Product);
                               }
                           }
                       }
                   }
                   else
                   {
                       product.Items.Clear();
                   }

               }
           };
        private Action<ComboBox, ComboBox, List<FullProductclass>> updatepackagebox = (product, package, list) =>
        {
            using (var db = new SuplyProgramContext())
            {
                if (product.Text != "")
                {
                    foreach (var item in list)
                    {
                        if (item.Product == product.Text)
                        {
                            package.Items.Add(item.Package);
                        }
                    }
                }
                else
                {
                    package.Items.Clear();
                }

            }
        };
        private Action<ComboBox, TextBox> updatescalebox = (packagebox, scaletext) =>
        {
            using (var db = new SuplyProgramContext())
            {
                if (packagebox != null)
                {
                    var packagelist = db.Packages.Where(p => p.PackageType == packagebox.Text).Select(p => p).First();
                    var scale = db.ScaleValues.Where(s => s.ScaleId == packagelist.ScaleId).Select(s => s.ScalesTypes).First();
                    scaletext.Text = scale;
                }
                else
                {
                    scaletext.Text = "";
                }

            }
        };
        public event Action<string> ProductChanged;
        public EditProductUserControl1()
        {
            InitializeComponent();
            EditProductdataGridView1.DataSource = adminuser.GetFullProductStorageTable();
            updateLocationbox(LocationcomboBox1);


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ProductcomboBox2.Items.Clear();
            PackagecomboBox3.Items.Clear();
            updateproductbox(LocationcomboBox1, ProductcomboBox2, adminuser.GetFullProductStorageTable());
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            PackagecomboBox3.Items.Clear();
            updatepackagebox(ProductcomboBox2, PackagecomboBox3, adminuser.GetFullProductStorageTable()); ;
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            var stock = 0;
            var order = 0;
            updatescalebox(PackagecomboBox3, scaletextBox1);
           var result = adminuser.SearchinProductStockfull(ProductcomboBox2.Text, LocationcomboBox1.Text, PackagecomboBox3.Text, ref stock, ref order);
            UnitInStocktextBox1.Text = stock.ToString();
            UnitInOrdertextBox2.Text = order.ToString();
            ProductChanged(result);


        }

        private void Savebutton1_Click(object sender, EventArgs e)
        {
            try
            {
                var result = adminuser.SaveEditedChanges(ProductcomboBox2.Text, LocationcomboBox1.Text, PackagecomboBox3.Text, Convert.ToInt32(UnitInStocktextBox1.Text), Convert.ToInt32(UnitInOrdertextBox2.Text));
                EditProductdataGridView1.DataSource = adminuser.GetFullProductStorageTable();
                ProductChanged(result);

            }
            catch
            {
                MessageBox.Show("Check your details");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                var result = adminuser.RemoveProductfromStorage(ProductcomboBox2.Text, LocationcomboBox1.Text, PackagecomboBox3.Text);
                EditProductdataGridView1.DataSource = adminuser.GetFullProductStorageTable();
                ProductChanged(result);
            }
            catch
            {
                MessageBox.Show("Check your details");
            }
        }
    }
}
