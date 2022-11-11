using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogicLayer.InterfacesForUserManager
{
    public interface IUpdatePassword
    {
        public void UpdatePassword(string username, string password);
    }
}
