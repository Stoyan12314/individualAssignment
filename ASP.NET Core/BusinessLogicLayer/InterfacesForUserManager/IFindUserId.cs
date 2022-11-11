using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogicLayer.InterfacesForUserManager
{
    public interface IFindUserId
    {
        public string FindUserId(string username);
    }
}
