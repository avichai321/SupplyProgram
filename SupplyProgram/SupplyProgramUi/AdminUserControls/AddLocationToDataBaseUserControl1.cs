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
    public partial class AddLocationToDataBaseUserControl1 : UserControl
    {
        Adminuser adminuser = new Adminuser();
        public event Action<string> locationChanged;
        private Action<ComboBox, DataGridView> fillcombobox = (fillbox, data) =>
        {
            using (var db = new SuplyProgramContext())
            {
                var locationlist = db.Locations.Select(u=> new {u.LocationId,u.Location1}).ToList();
                data.DataSource = locationlist;
                foreach (var location in locationlist)
                {
                    fillbox.Items.Add(location.Location1);
                }

            }
        };
        public AddLocationToDataBaseUserControl1()
        {
            InitializeComponent();
            fillcombobox(removelocationcomboBox1, dataGridView1);
        }

        private void addlocationtodatabasebutton1_Click(object sender, EventArgs e)
        {
            var message = adminuser.AddLocationToDatabase(addLocationtextBox1.Text);
            locationChanged(message);
            fillcombobox(removelocationcomboBox1, dataGridView1);
        }

        private void removelocationfromdatabasebutton1_Click(object sender, EventArgs e)
        {
            var message = adminuser.RemoveLocationFromDatabase(removelocationcomboBox1.Text);
            locationChanged(message);
            fillcombobox(removelocationcomboBox1, dataGridView1);
        }
    }
}
