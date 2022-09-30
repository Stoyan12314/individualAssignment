using System;
using System.Collections.Generic;
using System.Text;
using Entities;
namespace DataAccessLayer
{
    public interface Ilogin
    {
        public bool CheckLogin(string password, string username);

        public bool Register(string password, string username);
    }
}
