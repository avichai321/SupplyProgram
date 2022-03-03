using DataBase.SupplyData;
using SupplyProgarmOperations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SupplyProgramUi.AdminUserControls
{
    public partial class AddPackageUserControl1 : UserControl
    {
        Adminuser adminuser = new Adminuser();
        public event Action<string> packageChanged;
        private Action<ComboBox,ComboBox, DataGridView> fillcombobox = (fillbox,scalebox, data) =>
        {
            using (var db = new SuplyProgramContext())
            {
                var packagelist = db.Packages.Join(db.ScaleValues, p => p.ScaleId, s => s.ScaleId, (p, s) => 
                new { PackageId = p.PackageId, PackageType=p.PackageType, scalevalue=s.ScalesTypes }).ToList();
                var scalelist= db.ScaleValues.ToList();
                data.DataSource = packagelist;
                foreach (var package in packagelist)
                {
                    fillbox.Items.Add(package.PackageType);   
                }
                foreach (var scale in scalelist)
                {
                    scalebox.Items.Add(scale.ScalesTypes);
                }

            }
        };
        public AddPackageUserControl1()
        {
            InitializeComponent();
            fillcombobox(removePackagecomboBox1, scalecomboBox2, PackagesdataGridView1);
  
        }

        private void addPackagetodatabasebutton1_Click(object sender, EventArgs e)
        {
            var message = adminuser.AddPackageToDatabase(addPackagetextBox1.Text,scalecomboBox2.Text);
            packageChanged(message);
            fillcombobox(removePackagecomboBox1, scalecomboBox2, PackagesdataGridView1);

        }

        private void removePackagebutton1_Click(object sender, EventArgs e)
        {
            var message = adminuser.RemovePackageFromDatabase(removePackagebutton1.Text);
            packageChanged(message);
            fillcombobox(removePackagecomboBox1, scalecomboBox2, PackagesdataGridView1);
        }
    }
}
