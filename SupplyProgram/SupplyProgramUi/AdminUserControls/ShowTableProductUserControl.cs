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
    public partial class ShowTableProductUserControl : UserControl
    {
        Adminuser adminuser = new Adminuser();

        public event Action<DataGridView, ComboBox, List<FullProductclass>> sortTable = (data, sortterm, listofproducts) =>
         {
             var sortedlist = new List<FullProductclass>();
             if (sortterm.Text != "")
             {

                 foreach (FullProductclass item in listofproducts)
                 {                    
                         if (item.Location == sortterm.Text)
                         {
                             sortedlist.Add(item);
                         }  
                 }
             data.DataSource = sortedlist;
             }
             else
             {

                 data.DataSource = listofproducts;
             }
             

         };
        public Action<ComboBox> storageslist = (storage) =>
        {
            using (var db = new SuplyProgramContext())
            {
                var locationlist = db.Locations.ToList();
                foreach (var location in locationlist)
                {
                    storage.Items.Add(location.Location1);
                }
            }
        };


        public ShowTableProductUserControl()
        {
            InitializeComponent();
            dataGridView1.DataSource = adminuser.GetFullProductStorageTable();
            storageslist(LocationlistcomboBox1);
        }

        private void Sortbutton_Click(object sender, EventArgs e)
        {
            var table = adminuser.GetFullProductStorageTable();
            sortTable(dataGridView1, LocationlistcomboBox1, table);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
