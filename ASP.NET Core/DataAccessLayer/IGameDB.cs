using System;
using System.Collections.Generic;
using System.Text;
using Entities; 
namespace DataAccessLayer
{
    public interface IGameDB
    {
        public void AddGame(Game game);
        public List<Game> GetAllGames();

        public bool Delete(int id);

        public Game GetGameWith(int id);

        public void UpdateGame(Game game);
        public double GetAvgScore(int game_id);
    }
}
