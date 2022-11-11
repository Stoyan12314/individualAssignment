using System;
using System.Collections.Generic;
using System.Text;
using Entities;
namespace BusinessLogicLayer.InterfacesForGameManager
{
    public interface IGetGameWith
    {
        public Game GetGameWith(int id);
    }
}
