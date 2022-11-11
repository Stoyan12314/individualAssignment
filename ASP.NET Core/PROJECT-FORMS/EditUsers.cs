using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BusinessLogicLayer;
using BusinessLogicLayer.InterfacesForUserManager;
using DataAccessLayer;
using BusinessLogicLayer.interfacesForReviewManager;
using Entities;
namespace PROJECT_FORMS
{
    public partial class EditUsers : Form
    {
        private IGetUser IGetUser;
        private IUpdatePassword IUpdatePass;
        private IUpdateUsername IUpdateUser;
        private IGetAllUserReviews IGetAllUserReviews;
      
        int id;
       
        public EditUsers(int id)
        {
            InitializeComponent();
            IGetUser = new UserManager(new DBUser());
            IGetAllUserReviews = new ReviewerManager(new DBReview());
         
            IUpdatePass = new UserManager(new DBUser());
            IUpdateUser = new UserManager(new DBUser());
            this.id = id;
            
            UpdateDataSet();
        }
       
        public void UpdateDataSet()
        {
            User user = IGetUser.GetUser(id);
            List<Review> reviews = IGetAllUserReviews.GetAllUserReviews(user);
            dataGridView1.Rows.Clear();
            if (reviews.Count>0)
            {
                foreach (Review review in IGetAllUserReviews.GetAllUserReviews(user))
                {
                    dataGridView1.Rows.Add(review.game.title, review.score, review.review);
                }
            }
           
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            User user = IGetUser.GetUser(id);
            int index = e.RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[0]; 
            string review = (string)selectedRow.Cells[2].Value;

            EditReviews newForm = new EditReviews(review, user);
            newForm.ShowDialog();
            UpdateDataSet();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            User user = IGetUser.GetUser(id);

            if (String.IsNullOrEmpty(tbPassword.Text))
            {
                IUpdateUser.UpdateUsername(tbUsername.Text, user.Username());
            }
            else if (String.IsNullOrEmpty(tbUsername.Text))
            {
                IUpdatePass.UpdatePassword(user.Username(), PasswordHash.Hash(tbPassword.Text));
            }
            else 
            {
                IUpdateUser.UpdateUsername(tbUsername.Text, user.Username());
                IUpdatePass.UpdatePassword(user.Username(),  PasswordHash.Hash(tbPassword.Text));
            }
         
        }
    }
}
