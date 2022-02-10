
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
                var admin = UserStatus.AdminOrUser(UsernametextBox1.Text,PasswordtextBox2.Text);
                if (admin)
                {
                    var adminScreen = new AdminScreen();
                    adminScreen.Show();
                   
                }
                else
                {
                    var userScreen = new UserScreen();
                    userScreen.Show();
                    
                }
                Openform.ThisForm.Hide();
                this.Close();
            }
            else
            {
                MessageBox.Show("Wrong username or password");
            }
     
        }
    }
}

