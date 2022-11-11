using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Enum;
using System.ComponentModel.DataAnnotations;

namespace Entities
{
    public abstract class User
    {
       
        protected int id;
       
        protected string username;
        
        protected string password;
        protected DateTime creation_date;
        
        protected int badges;
        
        protected int number_written_reviews;
       
        protected AccountType accType;
       
       
      
        
        public User(int id, string username, string password, DateTime creation_date, int badges, int number_written_reviews, AccountType accType)
        {
            this.id = id;
            this.username = username;
            this.password = password;
            this.creation_date = creation_date;
            this.badges = badges;
            this.number_written_reviews = number_written_reviews;
            this.accType = accType;
        }
        //user_id, user_name, password, creation date, badges, number written reviews

        public User(int id, string username, string password, DateTime creation_date, int badges, int number_written_reviews)
        {
            this.id=id;
            this.username = username;
            this.password = password;
            this.creation_date = creation_date;
            this.badges = badges;
            this.number_written_reviews = number_written_reviews;
        }

        protected User(string username, string password)
        {
            this.username = username;
            this.password = password;
        }
        protected User(int id, string username)
        {
            this.username = username;
            this.id = id;
        }

        public DateTime CreationDate()
        {
            return this.creation_date;
        }
        public int NumberWrittenReviews()
        {
            return this.number_written_reviews;
        }
        public int Badges()
        {
            return badges;
        }
        public int Id()
        {
            return this.id;
        }
        public string Username()
        {
            return this.username;
        }
        public string Password()
        {
            return this.password;
        }
        public AccountType AccountType()
        {
            return this.accType;
        }
      
       
        

    }
}
