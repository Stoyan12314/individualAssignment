using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public abstract class User
    {
        protected string Name;
        protected string Email;
        protected string username;
        protected string password;
        
        public User(string name, string email, string username, string password)
        {
            this.Name = name;
            this.username = username;
            this.Email = email;
            this.password = password;
        }

        public abstract override string ToString();
       
        

    }
}
