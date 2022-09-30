using System;
using System.Collections.Generic;
using System.Text;
using Entities;
namespace DataAccessLayer
{
    public class DBreviews : IReviewDB
    {
        public bool CreateReview(Review review, User user, Game game)
        {
            throw new NotImplementedException();
        }

        public bool DeleteReview(Review review, User user, Game game)
        {
            throw new NotImplementedException();
        }

        public List<Review> GetAllUserReviews(User user)
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

        public bool UpdateReview(Review review, User user, Game game)
        {
            throw new NotImplementedException();
        }
    }
}
