using System;
using System.Collections.Generic;
using System.Text;
using Entities;
namespace BusinessLogicLayer.InterfacesForUserManager
{
    public interface IUpdateUsername
    {
        public void UpdateUsername(string username,  string oldUsername);

    }
}
