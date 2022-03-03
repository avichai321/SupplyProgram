using DataBase.SupplyData;
using System.Linq;
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
