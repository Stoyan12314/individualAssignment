using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using DataAccessLayer;
using BusinessLogicLayer.interfacesForReviewManager;
namespace BusinessLogicLayer
{
    public class ReviewerManager : ICreateReview, IUpdateReview, IDeleteReview, IGetAllUserReviews, IGetAllReviewsWithGame
    {
        private IReviewDB reviewDB;
        
        public ReviewerManager(IReviewDB reviewDB)
        {
            this.reviewDB = reviewDB;
            //dbReviews = new DBreviews();
        }
        public bool CreateReview(Review review)
        {
            bool output = reviewDB.CreateReview(review);
            if (output == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool UpdateReview(string review, User user)
        {
            return reviewDB.UpdateReview(review, user);
        }
        public List<Review> GetAllReviewsWithGame(Game game)
        {
            return reviewDB.GetAllUserReviewsGame(game);
        }
        public List<Review> GetAllUserReviews(User user)
        {
            List<Review> reviews = reviewDB.GetAllUserReviews(user);
            return reviews;
        }
        public bool DeleteReview(string review, int user_id)
        {
            if (reviewDB.DeleteReview(review, user_id))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
