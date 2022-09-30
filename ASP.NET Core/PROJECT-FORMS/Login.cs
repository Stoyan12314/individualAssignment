using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DataAccessLayer;
namespace PROJECT_FORMS
{
    public partial class Login : Form
    {
        DBusers userManager;
        public Login()
        {
            InitializeComponent();
            userManager = new DBusers();    
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {

        }
    }
}
