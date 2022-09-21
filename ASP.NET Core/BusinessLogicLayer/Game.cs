using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class Game
    {
        private string title;
        private double score;
        private List<Review> reviews;
        public Game()
        {
            reviews = new List<Review>();
        }
    }
}
