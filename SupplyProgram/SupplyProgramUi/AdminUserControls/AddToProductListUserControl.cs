using DataBase.SupplyData;
using SupplyProgarmOperations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SupplyProgramUi.AdminUserControls
{
    public partial class AddToProductListUserControl : UserControl
    {
        private Action<ComboBox,DataGridView> fillcombobox=(fillbox,data)=>
        {
            using (var db = new SuplyProgramContext())
            {
                var productlist = db.Products.Select(u=> new {u.ProductId,u.ProductName}).ToList();
                data.DataSource = productlist;
                foreach (var product in productlist)
                {
                    fillbox.Items.Add(product.ProductName);
                }

            }
        };
        Adminuser adminuser = new Adminuser();
        public event Action<string> ProductChanged;
        public AddToProductListUserControl()
        {
            InitializeComponent();
            fillcombobox(removecomboBox1, ProductdataGridView1);

        }

        private void addproducttodatabasebutton1_Click(object sender, EventArgs e)
        {
            var message = adminuser.AddProductToDatabase(addProducttextBox1.Text);
            ProductChanged(message);
            fillcombobox(removecomboBox1, ProductdataGridView1);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var message = adminuser.RemoveProductfromDatabase(removecomboBox1.Text);
            ProductChanged(message);
            fillcombobox(removecomboBox1, ProductdataGridView1);
        }
    }
}
