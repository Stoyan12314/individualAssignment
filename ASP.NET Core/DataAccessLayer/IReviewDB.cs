using System;
using System.Collections.Generic;
using System.Text;
using Entities;
namespace DataAccessLayer
{
    public interface IReviewDB
    {
        public bool CreateReview(Review review);
        public bool UpdateReview(string review, User user);

        public bool DeleteReview(string review, int user_id);

        public List<Review> GetAllUserReviews(User user);

        public List<Review> GetAllUserReviewsGame(Game game);
    }
}
