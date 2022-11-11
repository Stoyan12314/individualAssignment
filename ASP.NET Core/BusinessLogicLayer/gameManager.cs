using System;
using System.Collections.Generic;
using System.Text;
using DataAccessLayer;
using Entities;
using BusinessLogicLayer.InterfacesForGameManager;
namespace BusinessLogicLayer
{
    public class gameManager : IAddGame, IDeleteGame, IUpdateGame, IGetAllGames, IGetGameWith, IGetAvgScore
    {
        private IGameDB gameDB;
        private DBChecks checks;
        
        public gameManager(IGameDB gameDB)
        {
            this.gameDB = gameDB;
            checks = new DBChecks();
        }

        public bool AddGame(Game game)
        {

           bool check = checks.CheckForRepeatingGames(game);
            if (check)
            {
               gameDB.AddGame(game);
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
        public double GetAvgScore(int game_id)
        {
            return gameDB.GetAvgScore(game_id);
        }
        public Game GetGameWith(int id)
        {
            return gameDB.GetGameWith(id);   
        }
        public void UpdateGame(Game game)
        {
            gameDB.UpdateGame(game);
        }
    }
}
