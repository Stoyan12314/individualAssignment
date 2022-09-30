using System;
using System.Collections.Generic;
using System.Text;
using DataAccessLayer;
using Entities;
namespace BusinessLogicLayer
{
    public class UserManager 
    {
        DBusers dBusers;
        public UserManager(DBusers dBusers)
        {
            this.dBusers = dBusers; 
        }
        public bool CheckLogin(string password, string username)
        {
            return true;
        }

        public bool Register(string password, string username)
        {
            return true;
        }
        public bool CreateUser(User user)
        {
            throw new NotImplementedException();
        }

        public bool DeleteUser(User user)
        {
            throw new NotImplementedException();
        }

        public User GetUser(string username)
        {
            throw new NotImplementedException();
        }
    }
}
