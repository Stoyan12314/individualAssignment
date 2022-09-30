using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Review
    {
        private string review;
        private int score;
        private User user;

        public Review(string review, int score, User user)
        {
            this.review = review;
            this.score = score;
            this.user = user;   
        }

        public int GetScore()
        {
            return this.score;
        }

        public User GetReviewer()
        {
            return this.user;
        }

        public string GetReview()
        {
            return this.review;
        }

    }
}
