using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DataAccessLayer;
using BusinessLogicLayer;
using BusinessLogicLayer.InterfacesForUserManager;
namespace PROJECT_FORMS
{
    public partial class Login : Form
    {
        private readonly ILogin Ilogin; 
        public Login()
        {
            InitializeComponent();
            Ilogin = new UserManager(new DBUser()); 


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
           
                string username = tbUsername.Text;
                string password = tbPassword.Text;

                if (Ilogin.CheckLogin(password, username))
                {

                    EntryPoint newForm = new EntryPoint();
                    newForm.Show();
                    this.Hide();

                }
                else 
                {
                    MessageBox.Show("Incorect credentials");
                }
       


        }

      
    }
}
