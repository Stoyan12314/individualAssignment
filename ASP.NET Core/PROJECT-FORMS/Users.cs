using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BusinessLogicLayer;
using DataAccessLayer;
using Entities;
using Entities.Enum;
using BusinessLogicLayer.InterfacesForUserManager;
namespace PROJECT_FORMS
{
    public partial class Users : Form
    {
        private IGetAllUsers IGetUsers;
      //  UserManager userManager;
        public Users()
        {
            InitializeComponent();
            IGetUsers = new UserManager(new DBUser());
            UpdateDataSet();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }
        public void UpdateDataSet()
        {
            dataGridView.Rows.Clear();
            foreach (User user in IGetUsers.GetAllUsers())
            {
                if (user.AccountType() == AccountType.Admin)
                {

                }
                else
                {
                    dataGridView.Rows.Add(user.Id(), user.Username(), user.Password(), user.CreationDate().ToString("dd/MM/yyyy"), user.Badges(), user.NumberWrittenReviews());
                }
               
            }
        }
        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = dataGridView.Rows[index];
            int id = (int)selectedRow.Cells[0].Value;

            EditUsers newForm = new EditUsers(id);
            newForm.ShowDialog();


        }

        private void Users_Load(object sender, EventArgs e)
        {

        }
    }
}
