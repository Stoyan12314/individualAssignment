using System;
using System.Collections.Generic;
using System.Text;
using Entities;
namespace DataAccessLayer
{
    public interface IUserDB
    {
        public bool CreateUser(User user);
        public bool DeleteUser(User user);

        public User GetUser(string username);

    }
}
