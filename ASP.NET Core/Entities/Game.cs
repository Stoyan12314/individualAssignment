using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Entities
{
    public class Game
    {
        public int gameId { get; private set; }
        [Required]
        public string developer { get; private set; }
        [Required]
        public Byte[] image { get; private set; }
        [Required]
        [StringLength(15, MinimumLength = 2)]
        public string genre { get; private set; }
        [Required]
        public int gameTime { get; private set; }
        [Required]
        public DateTime releaseDate { get; private set; }
        [Required]
        public double avgScore { get; private set; }
        [Required]
        public string title { get; private set; }
        [Required]

        public string description { get; private set; }

        public List<Review> reviews { get; private set; }
        public Game(int gameId, string developer, string genre, int gameTime, DateTime releaseDate, double avgScore, string title, string description, List<Review> reviews, Byte[] image)
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
            this.image = image;
        }

        public Game( string developer, string genre, int gameTime, DateTime releaseDate, double avgScore, string title, string description, Byte[] image)
        {
            this.developer = developer;
            this.genre = genre;
            this.gameTime = gameTime;
            this.releaseDate = releaseDate;
            this.avgScore = avgScore;
            this.title = title;
            this.description = description;
            reviews = new List<Review>();
            this.image = image;
        }

        public Game( string developer, string genre, int gameTime, DateTime releaseDate,  string title, string description, Byte[] image)
        {
            this.developer = developer;
            this.genre = genre;
            this.gameTime = gameTime;
            this.releaseDate = releaseDate;
            this.avgScore = 0;
            this.title = title;
            this.description = description;
            reviews = new List<Review>();
            this.image = image;
        }
        public Game(int id, string developer, string genre, int gameTime, DateTime releaseDate, string title, string description, Byte[] image)
        {
            this.gameId = id;
            this.developer = developer;
            this.genre = genre;
            this.gameTime = gameTime;
            this.releaseDate = releaseDate;
            this.avgScore = 0;
            this.title = title;
            this.description = description;
            this.image = image;
            reviews = new List<Review>();
           
        }

     

        //public Game(int game)
        //{
        //    reviews = new List<Review>();
        //}
    }
}
