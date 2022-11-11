using System;
using System.Collections.Generic;
using System.Text;
using Entities;
namespace BusinessLogicLayer.interfacesForReviewManager
{
    public  interface IGetAllReviewsWithGame
    {
        public List<Review> GetAllReviewsWithGame(Game game);
    }
}
