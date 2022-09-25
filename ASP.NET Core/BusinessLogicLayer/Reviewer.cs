using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class Reviewer : User, IUserAction
    {
        private List<Review> writtenReviews;
        public Reviewer(string name, string email, string username, string password) : base(name, email, username, password)
        {
            writtenReviews = new List<Review>();
        }

        public void DeleteReview(Review review)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            throw new NotImplementedException();
        }

        public void UpdateReview(Review review)
        {
            throw new NotImplementedException();
        }

        public void WriteReview(Review review)
        {
            throw new NotImplementedException();
        }
    }
}
