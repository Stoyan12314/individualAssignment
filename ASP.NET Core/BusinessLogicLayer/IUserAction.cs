using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public interface IUserAction
    {
        public void WriteReview(Review review);
        public void DeleteReview(Review review);

        public void UpdateReview(Review review);
    }
}
