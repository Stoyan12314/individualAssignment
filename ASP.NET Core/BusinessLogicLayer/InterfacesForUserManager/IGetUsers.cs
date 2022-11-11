using System;
using System.Collections.Generic;
using System.Text;
using Entities;
namespace BusinessLogicLayer.InterfacesForUserManager
{
    public interface IGetAllUsers
    {
        public List<User> GetAllUsers();
      
    }
}
