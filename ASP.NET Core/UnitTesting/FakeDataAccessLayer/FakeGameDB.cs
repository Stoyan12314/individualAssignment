using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DataAccessLayer;
using Entities;

namespace First_ASP.UnitTests.FakeDataAccessLayer
{
    public class FakeGameDB : IGameDB
    {
        private List<Game> games;

        public FakeGameDB(List<Game> games)
        {
            this.games = games;
        }

        public FakeGameDB()
        {
            games = new List<Game>();
        }
      
        public void AddGame(Game game)
        {
            foreach (Game g in games)
            {
                if (g != game)
                {
                    games.Add(g);
                }
            }
        }

        public bool Delete(int id)
        {
            foreach (Game g in games)
            {
                if (g.gameId == id)
                {
                    games.Remove(g);
                    return true;

                }
            }
            return false;
        }

        public List<Game> GetAllGames()
        {
            return games;
        }

        public Game GetGameWith(int id)
        {
            foreach (Game g in games)
            {
                if (g.gameId == id)
                {
                    return g;
                }
            }
            return null;
        }

        public void UpdateGame(Game game)
        {
           // List<Game> games = new List<Game>();
            
            foreach (Game g in games.ToList())
            {
                if (g.gameId == game.gameId)
                {
                    games.Remove(g);
                    games.Add(game);
                }
            }
            games.ToList();
        }

        public double GetAvgScore(int game_id)
        {
            throw new NotImplementedException();
        }
    }
}
