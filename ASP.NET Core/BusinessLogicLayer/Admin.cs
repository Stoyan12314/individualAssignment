using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class Admin: User, IUserAction
    {
        public Admin(string name, string email, string username, string password) : base( name,  email,  username, password)
        {

        }

      
              


        public void DeleteReviewer(Reviewer r)
        {
            
        }

        public override string ToString()
        {
            throw new NotImplementedException();
        }

        void IUserAction.DeleteReview(Review review)
        {
            throw new NotImplementedException();
        }

        void IUserAction.UpdateReview(Review review)
        {
            throw new NotImplementedException();
        }

        void IUserAction.WriteReview(Review review)
        {
            throw new NotImplementedException();
        }
    }
}
