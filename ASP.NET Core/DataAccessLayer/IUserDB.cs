using System;
using System.Collections.Generic;
using System.Text;
using Entities;
namespace DataAccessLayer
{
    public interface IUserDB
    {
       
        public bool CreateUser(string username, string password, DateTime creationDate);
      

        public Reviewer GetUser(int id);

        public List<User> GetAllUsers();

     
        public string FindUserId(string username);
        public void UpdateUsername(string username,  string oldUsername);
        public void UpdatePassword(string username, string password);

    }
}
