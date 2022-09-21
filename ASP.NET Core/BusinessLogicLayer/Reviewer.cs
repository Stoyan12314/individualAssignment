using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class Reviewer : User
    {
        private List<Review> writtenReviews;
        public Reviewer(string name, string email, string username, string password) : base(name, email, username, password)
        {
            writtenReviews = new List<Review>();
        }

    }
}
