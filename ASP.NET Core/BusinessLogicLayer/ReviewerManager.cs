using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using DataAccessLayer;
namespace BusinessLogicLayer
{
    public class ReviewerManager : IReviewDB
    {
        DBreviews dbReviews;
        public ReviewerManager()
        {
            dbReviews = new DBreviews();
        }
        public bool CreateReview(Review review, User user, Game game)
        {
            throw new NotImplementedException();
        }

      

        public bool UpdateReview(Review review, User user, Game game)
        {
            throw new NotImplementedException();

        }

        public bool DeleteReview(Review review, User user, Game game)
        {
            throw new NotImplementedException();

        }
        public List<Review> GetReviews(Game game)
        {
            throw new NotImplementedException();

        }

        public List<Review> GetReviews(User user)
        {
            throw new NotImplementedException();
        }

        public List<Review> GetAllUserReviews(User user)
        {
            throw new NotImplementedException();
        }
    }
}
