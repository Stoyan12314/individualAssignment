using System;
using System.Collections.Generic;
using System.Text;
using DataAccessLayer;
using Entities;
namespace First_ASP.UnitTests.FakeDataAccessLayer
{
    public class FakeReviewDB : IReviewDB
    {
        List<Review> reviews;
        public FakeReviewDB(List<Review> reviews)
        {
            this.reviews = reviews;
        }
        public bool CreateReview(Review review)
        {
            reviews.Add(review);
            return true;
        }

        public bool DeleteReview(string review, int user_id)
        {
            foreach (Review rev in reviews)
            {
                if (rev.user.Id() == user_id && rev.review == review)
                {
                    reviews.Remove(rev);
                    return true;
                }
            }
            return false;
        }

        public List<Review> GetAllUserReviews(User user)
        {
            List<Review> returnRev = new List<Review>();
            foreach (Review rev in reviews)
            {
                if (rev.user.Id() == user.Id())
                {
                    returnRev.Add(rev);
                   
                }
            }
            return returnRev;
        }

        public List<Review> GetAllUserReviewsGame(Game game)
        {
            List<Review> returnRev = new List<Review>();
            foreach (Review rev in reviews)
            {
                if (rev.game.gameId == game.gameId)
                {
                    returnRev.Add(rev);

                }
            }
            return returnRev;
        }


        //public Review(string review, int score, User user, Game game)
        //{
        //    this.review = review;
        //    this.score = score;
        //    this.user = user;
        //    this.game = game;
        //}

        public bool UpdateReview(string review, User user)
        {
            foreach (Review rev in reviews)
            {
                if (rev.user.Id() == user.Id() && rev.review == review)
                {
                    reviews.Remove(rev);
                    reviews.Add(new Review(review, 1, user, rev.game));
                    return true;
                }
            }
            return false;
        }
    }
}
