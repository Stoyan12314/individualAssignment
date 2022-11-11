using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Enum;
namespace Entities
{
    public class Reviewer : User
    {
        private DateTime creationDate;
        private AccountType reviewer;

        public Reviewer(int id, string username, string password, DateTime creation_date, int badges, int number_written_reviews, AccountType accType) : base(id , username, password, creation_date, badges, number_written_reviews, accType)
        {
            
        }
         //int id, string username, string password, DateTime creation_date, int badges, int number_written_reviews
        public Reviewer(int id, string username, string password, DateTime creation_date, int badges, int number_written_reviews) : base(id, username, password, creation_date, badges, number_written_reviews)
        {
          
        }

        public Reviewer(string username, string password) : base(username, password)
        {
            
        }

        public Reviewer(int id, string username) : base(id,username)
        {
            
        }

        public Reviewer(string username, string password, DateTime creationDate, AccountType reviewer) : base(username, password)
        {
            this.creationDate = creationDate;
            this.reviewer = reviewer;
        }
    }
}
