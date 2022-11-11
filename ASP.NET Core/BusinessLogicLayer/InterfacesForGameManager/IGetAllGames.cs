using System;
using System.Collections.Generic;
using System.Text;
using Entities;
namespace BusinessLogicLayer.InterfacesForGameManager
{
    public interface IGetAllGames
    {
        public List<Game> GetAllGames();
    }
}
