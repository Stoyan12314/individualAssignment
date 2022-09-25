using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class Game
    {
        private int gameId;
        private string developer;
      
        private string genre;
        private int gameTime;
        private DateTime releaseDate;
        private double avgScore;
        private string title;
        private string description;
        private List<Review> reviews;

        public Game(int gameId, string developer, string genre, int gameTime, DateTime releaseDate, double avgScore, string title, string description, List<Review> reviews)
        {
            this.gameId = gameId;
            this.developer = developer;
            this.genre = genre;
            this.gameTime = gameTime;
            this.releaseDate = releaseDate;
            this.avgScore = avgScore;
            this.title = title;
            this.description = description;
            this.reviews = reviews;
        }

        public Game( string developer, string genre, int gameTime, DateTime releaseDate, double avgScore, string title, string description)
        {
            this.developer = developer;
            this.genre = genre;
            this.gameTime = gameTime;
            this.releaseDate = releaseDate;
            this.avgScore = avgScore;
            this.title = title;
            this.description = description;
            reviews = new List<Review>();
        }

        public Game( string developer, string genre, int gameTime, DateTime releaseDate,  string title, string description)
        {
            this.developer = developer;
            this.genre = genre;
            this.gameTime = gameTime;
            this.releaseDate = releaseDate;
            this.avgScore = 0;
            this.title = title;
            this.description = description;
            reviews = new List<Review>();
        }
        public string GameTitle()
        {
            return this.title;
        }
        public int GameId()
        {
            return this.gameId;
        }
        public string Developer()
        {
            return this.developer;
        }
        public string Genre()
        {
            return this.genre;
        }
        public int GameTime()
        {
            return this.gameTime;
        }
        public DateTime ReleaseDate()
        {
            return this.releaseDate;
        }
        public double AvgScore()
        {
            return this.avgScore;
        }
        public string Description()
        {
            return this.description;
        }
         //public Game(int game)
        //{
        //    reviews = new List<Review>();
        //}
    }
}
