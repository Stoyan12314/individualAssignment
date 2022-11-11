using System;
using System.Collections.Generic;
using System.Text;
using Entities;
using DataAccessLayer;
namespace BusinessLogicLayer.InterfacesForUserManager
{
    public interface IRegister
    {
        public bool Register(string username, string password);
    }
}
