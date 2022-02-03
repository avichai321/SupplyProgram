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

namespace SupplyProgramUi.UserUserControls
{
    public partial class userSortUserControl1 : UserControl
    {
        public event Action SaveAndExit;
        private Func<ComboBox, List<FullProductclass>, List<FullProductclass>> sortTable = (sortterm, listofproducts) =>
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
                 return sortedlist;
             }
             else
             {

                 return listofproducts;
             }


         };
        public event Action<ComboBox, List<FullProductclass>> sortedtable = (sortterm,sortlist) =>
            {

            };

        private Action<ComboBox> storageslist = (storage) =>
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
        Normaluser normaluser = new Normaluser();
        public userSortUserControl1()
        {
            InitializeComponent();
            storageslist(comboBox1);
        }

        private void Sortbutton_Click(object sender, EventArgs e)
        {
            var table = normaluser.GetFullProductStorageTable();
            sortedtable(comboBox1,sortTable(comboBox1, table));
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
