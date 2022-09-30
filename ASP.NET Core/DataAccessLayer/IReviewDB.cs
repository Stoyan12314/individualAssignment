using System;
using System.Collections.Generic;
using System.Text;
using Entities;
namespace DataAccessLayer
{
    public interface IReviewDB
    {
        public bool CreateReview(Review review, User user, Game game);
        public bool UpdateReview(Review review, User user, Game game);

        public bool DeleteReview(Review review, User user, Game game);
        public List<Review> GetReviews(Game game);
        public List<Review> GetReviews(User user);

        public List<Review> GetAllUserReviews(User user);
    }
}
