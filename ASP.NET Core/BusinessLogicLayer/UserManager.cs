using System;
using System.Collections.Generic;
using System.Text;
using DataAccessLayer;
using Entities;
using BusinessLogicLayer;
using BusinessLogicLayer.InterfacesForUserManager;
namespace BusinessLogicLayer
{
    public class UserManager : ILogin, IGetUser, IGetAllUsers, IRegister, IUpdateUsername, IFindUserId, IUpdatePassword
    {
        private IUserDB dBusers;
    
        public UserManager(IUserDB dBusers)
        {
            this.dBusers = dBusers;
        }


        public string FindUserId(string username)
        {
            return dBusers.FindUserId(username);
        }
        public bool CheckLogin(string password, string username)
        {
            List<User> users = dBusers.GetAllUsers();
            string hashedPass = null;
            if (users.Count > 0)
            {
                foreach (User user in users)
                {
                    if (user.AccountType() == Entities.Enum.AccountType.Admin)
                    {
                        if (user.Username() == username)
                        {
                            return true;
                            //  hashedPass = user.Password();
                        }
                    }
                    else if(user.AccountType() == Entities.Enum.AccountType.Reviewer)
                    {
                        if (user.Username() == username)
                        {
                            hashedPass = user.Password();
                            return PasswordHash.Validate(password, hashedPass);
                        }
                       
                    }
                    
                        
                }
            }
            return false;
        
        }
     
            
        public void UpdateUsername(string username,  string oldUsername)
        {
            dBusers.UpdateUsername(username,  oldUsername);
        
        }
        public void UpdatePassword(string username, string password)
        {
            dBusers.UpdatePassword(username, PasswordHash.Hash(password));
        }
        public bool Register(string password, string username)
        {
            List<User> users = dBusers.GetAllUsers();
            if (users.Count > 0)
            {
                foreach (User u in users)
                {
                    if (u.Username() == username)
                        return false;
                }
            }
          
            password = PasswordHash.Hash(password);
            dBusers.CreateUser(username, password, DateTime.Now);
            return true;
        }
        public List<User> GetAllUsers()
        {
            return dBusers.GetAllUsers();
        }
   

        public User GetUser(int id)
        {
           return dBusers.GetUser(id);
        }

    }
}
