using System;
using System.Collections.Generic;
using System.Text;
using Entities;
namespace DataAccessLayer
{
    public class DBLogin : Ilogin
    {
        public bool CheckLogin(string password, string username)
        {
            return true;
        }

        public bool Register(string password, string username)
        {
            return true;
           

        }
    }
}
