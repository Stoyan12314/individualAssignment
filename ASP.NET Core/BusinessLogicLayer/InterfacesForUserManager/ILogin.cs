using System;
using System.Collections.Generic;
using System.Text;
using DataAccessLayer;
namespace BusinessLogicLayer.InterfacesForUserManager
{
    public interface ILogin
    {
        public bool CheckLogin(string password, string username);
    }
}
