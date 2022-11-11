using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccessLayer;
using Entities;
using Entities.Enum;
namespace First_ASP.UnitTests.FakeDataAccessLayer
{
    internal class FakeUserDB : IUserDB
    {
        List<User> users;

        public FakeUserDB(List<User> users)
        {
            this.users = users;
        }

        public bool CreateUser(string username, string password, DateTime creationDate)
        {
            Reviewer rev = new Reviewer(username, password, creationDate, AccountType.Reviewer);

            
            if (users.Count > 0 && !users.Contains(rev))
            {
                users.Add(new Reviewer(username, password, creationDate, AccountType.Reviewer));
                return true;
            }
            else
            {
                return false;
            }
        }

      

        public string FindUserId(string username)
        {
            foreach (User user in users)
            {
                if (user.Username() == username)
                {
                    return user.Id().ToString();
                }
            }
            return "";
        }

        public List<User> GetAllUsers()
        {
         return users;
        }

        public Reviewer GetUser(int id)
        {
            foreach (User user in users)
            {
                if (user.Id() == id)
                {
                    return (Reviewer)user;
                }
            }
            return null;
        }

        public void UpdatePassword(string username, string password)
        {
            foreach (User user in users.ToList())
            {
                if (user.Username() == username)
                {
                    users.Remove(user);
                    users.Add(new Reviewer(username, password, user.CreationDate(), user.AccountType()));
                    
                }
            }
        }

        public void UpdateUsername(string username, string oldUsername)
        {
            foreach (User user in users.ToList())
            {
                if (user.Username() == oldUsername)
                {
                    users.Remove(user);
                    users.Add(new Reviewer(username, user.Password(), user.CreationDate(), user.AccountType()));
                }
            }
        }
    }
}
