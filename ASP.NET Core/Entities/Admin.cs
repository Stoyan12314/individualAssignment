using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Enum;
namespace Entities
{
    public class Admin: User
    {
                                                                                                                                                          //User(int id, string username, string password, DateTime creation_date, int badges, int number_written_reviews, AccountType accType)
        public Admin(int id, string username, string password, DateTime creation_date, int badges, int number_written_reviews, AccountType accType) : base(id, username, password, creation_date, badges, number_written_reviews, accType)
        {

        }

      
              


      
      

      
    }
}
