using System;
using System.Collections.Generic;
using System.Text;
using Entities;
namespace BusinessLogicLayer.interfacesForReviewManager
{
    public interface ICreateReview
    {
        public bool CreateReview(Review review);
    }
}
