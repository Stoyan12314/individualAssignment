using System;
using System.Collections.Generic;
using System.Text;
using DataAccessLayer;
using Entities;
namespace BusinessLogicLayer
{
    public class gameManager
    {
        private DBgame gameDB;
        
        public gameManager()
        {
            gameDB = new DBgame();
        }

        public bool AddGame(Game game)
        {
           bool check = gameDB.AddGame(game);
            if (check)
            {
               return true;
            }
            return false;
        }
        public List<Game> GetAllGames()
        {
            return this.gameDB.GetAllGames();
        }
        public bool DeleteGame(int id)
        {
            bool check = gameDB.Delete(id);
            if (check)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public Game GetGameWith(int id)
        {
            return gameDB.GetGameWith(id);   
        }
    }
}
