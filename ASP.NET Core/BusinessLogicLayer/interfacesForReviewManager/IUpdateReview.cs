using System;
using System.Collections.Generic;
using System.Text;
using Entities;
namespace BusinessLogicLayer.interfacesForReviewManager
{
    public interface IUpdateReview
    {
        public bool UpdateReview(string review, User user);
    }
}
