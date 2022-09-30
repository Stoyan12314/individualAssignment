using System;
using System.Collections.Generic;
using System.Text;
using Entities; 
namespace DataAccessLayer
{
    public interface IGameDB
    {
        public bool AddGame(Game game);
        public List<Game> GetAllGames();

        public bool Delete(int id);

        public Game GetGameWith(int id);
    }
}
