using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class Admin: User
    {
        public Admin(string name, string email, string username, string password) : base( name,  email,  username, password)
        {

        }

      

        public override void DeleteReview()
        {
            
        }

        public void DeleteReviewer(Reviewer r)
        {
            
        }

        public override string ToString()
        {
            throw new NotImplementedException();
        }

        public override void UpdateReview()
        {
            throw new NotImplementedException();
        }

        public override void WriteReview()
        {
            throw new NotImplementedException();
        }
    }
}
