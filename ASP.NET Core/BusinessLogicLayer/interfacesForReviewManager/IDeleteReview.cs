using System;
using System.Collections.Generic;
using System.Text;
using Entities;
namespace BusinessLogicLayer.interfacesForReviewManager
{
    public interface IDeleteReview
    {
        public bool DeleteReview(string review, int user_id);
    }
}
