using DataBase.SupplyData;
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
    public partial class ShowTableUserControl1 : UserControl
    {
       
        public ShowTableUserControl1()
        {
            InitializeComponent();
            using (var db = new SuplyProgramContext())
            {
                UserdataGridView1.DataSource = db.Users.ToList();
            };

        }
    }
}
