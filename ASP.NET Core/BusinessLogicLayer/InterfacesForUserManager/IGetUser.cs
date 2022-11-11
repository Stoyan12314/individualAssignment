using System;
using System.Collections.Generic;
using System.Text;
using Entities;
namespace BusinessLogicLayer.InterfacesForUserManager
{
    public interface IGetUser
    {
        public User GetUser(int id);
        
    }
}
