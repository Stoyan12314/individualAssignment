using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Entities;
using BusinessLogicLayer;
using DataAccessLayer;
using BusinessLogicLayer.interfacesForReviewManager;
namespace PROJECT_FORMS
{
    public partial class EditReviews : Form
    {
        string review;
        private IUpdateReview IUpdateReview;
        private IDeleteReview IDeleteReview;
     
        User user;
        public EditReviews(string review, User user)
        {
            InitializeComponent();
            this.review = review;
            this.user = user;
            IUpdateReview = new ReviewerManager(new DBReview());
            IDeleteReview = new ReviewerManager(new DBReview());
            LoadData();
        }
        public void LoadData()
        {
            this.tbReviews.Text = review;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            IUpdateReview.UpdateReview(review, user);
            this.Close();
        }

        private void EditReviews_Load(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            IDeleteReview.DeleteReview(review, user.Id());
            this.Close();
        }
    }
}
