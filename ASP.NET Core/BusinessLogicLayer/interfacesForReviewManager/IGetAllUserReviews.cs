using System;
using System.Collections.Generic;
using System.Text;
using Entities;
namespace BusinessLogicLayer.interfacesForReviewManager
{
    public interface IGetAllUserReviews
    {
        public List<Review> GetAllUserReviews(User user);
    }
}
