using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Review
    {
        public string review { private set; get; }
        public int score { private set; get; }
        public User user { private set; get; }
        public Game game { private set; get; }
        public Review(string review, int score, User user, Game game)
        {
            this.review = review;
            this.score = score;
            this.user = user;
            this.game = game;   
        }
        public Review(string review, int score, Game game)
        {
            this.review=review;
            this.score = score;
            this.game = game;
        }
        
    }
}
