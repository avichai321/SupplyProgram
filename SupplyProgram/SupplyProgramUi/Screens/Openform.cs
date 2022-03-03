using SupplyProgarmOperations;
using System;
using System.Windows.Forms;


namespace SupplyProgramUi
{

    public partial class Openform : Form
    {
        public static Form ThisForm;
        public Openform()
        {
            ThisForm = this;       
            InitializeComponent();        
        }

       

        private void Loginbutton1_Click(object sender, EventArgs e)
        {
            bool login = UserStatus.UserLogin(UsernametextBox1.Text,PasswordtextBox2.Text);
            if (login)
            {
                Openform.ThisForm.Hide();
                var admin = UserStatus.AdminOrUser(UsernametextBox1.Text,PasswordtextBox2.Text);
                if (admin)
                {
                    var adminScreen = new AdminScreen();
                    adminScreen.ShowDialog();
                   
                }
                else
                {
                    var userScreen = new UserScreen();
                    userScreen.ShowDialog();
                    
                }
                this.Close();
            }
            else
            {
                MessageBox.Show("Wrong username or password");
            }
     
        }
    }
}

