using SupplyProgarmOperations;
using System;
using System.Windows.Forms;

namespace SupplyProgramUi
{
    public partial class AddUserUserControl : UserControl
    {
        Adminuser adminuser= new Adminuser();
        public event Action<string> UserChanged;
        public event Action SaveAndExit;
        public AddUserUserControl()
        {
            InitializeComponent();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string message = adminuser.AddUserToDataBase(UsernametextBox1.Text, PasswordtextBox2.Text,emailtextBox1.Text,AdmincomboBox1.Text);
            UserChanged(message);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string email = "";
            string pass = "";
            string admin = "";
            string message = adminuser.SearchUserinDataBase(UsernametextBox1.Text,ref email, ref pass, ref admin);
            UserChanged(message);
            PasswordtextBox2.Text = pass;
            emailtextBox1.Text = email;
            AdmincomboBox1.Text =admin.ToUpper();

        }

        private void RemoveUserBtn_Click(object sender, EventArgs e)
        {
            var message = adminuser.DeleteUserToDataBase(UsernametextBox1.Text);
            UserChanged(message);
        }

        private void SaveUserChangesBtn_Click(object sender, EventArgs e)
        {
            SaveAndExit();
        }

        private void SaveeditedUserChangesbutton1_Click(object sender, EventArgs e)
        {
            var message= adminuser.SaveEditedUserChanges(UsernametextBox1.Text,emailtextBox1.Text,PasswordtextBox2.Text,AdmincomboBox1.Text);
            UserChanged(message);
        }
    }
}
