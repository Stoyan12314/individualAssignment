using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PROJECT_FORMS
{
    public partial class EntryPoint : Form
    {
        public EntryPoint()
        {
            InitializeComponent();
        }

        private void btnGames_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
        
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            Users form = new Users();
            form.Show();
        }

        private void btn_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
