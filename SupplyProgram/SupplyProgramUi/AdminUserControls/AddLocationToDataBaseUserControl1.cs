using DataBase.SupplyData;
using SupplyProgarmOperations;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace SupplyProgramUi.AdminUserControls
{
    public partial class AddLocationToDataBaseUserControl1 : UserControl
    {
        Adminuser adminuser = new Adminuser();
        public event Action<string> LocationChanged;
        private Action<ComboBox, DataGridView> Fillcombobox = (fillbox, data) =>
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
            Fillcombobox(removelocationcomboBox1, dataGridView1);
        }

        private void Addlocationtodatabasebutton_Click(object sender, EventArgs e)
        {
            var message = adminuser.AddLocationToDatabase(addLocationtextBox1.Text);
            LocationChanged(message);
            Fillcombobox(removelocationcomboBox1, dataGridView1);
        }

        private void Removelocationfromdatabasebutton_Click(object sender, EventArgs e)
        {
            var message = adminuser.RemoveLocationFromDatabase(removelocationcomboBox1.Text);
            LocationChanged(message);
            Fillcombobox(removelocationcomboBox1, dataGridView1);
        }
    }
}
