using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Entities;
using BusinessLogicLayer;
using BusinessLogicLayer.InterfacesForGameManager;
using First_ASP.UnitTests.FakeDataAccessLayer;
using System.Collections.Generic;

namespace First_ASP.UnitTests
{
    [TestClass]
    public class GameManagerTest
    {
        [TestMethod]
        public void AddGame_GamesAddedSuccesfully_Void()
        {
           // List<Game> games = new List<Game>();
            FakeGameDB fakeRepo = new FakeGameDB();
            gameManager gameManager = new gameManager(fakeRepo);

            Game game = new Game(1, "testDeveloper", "testGenre", 9, DateTime.Now, "testTitle", "testDescription");

            var result1 = gameManager.AddGame(game);
           // var result2 = gameManager.AddGame(game);
           Assert.IsTrue(result1);
          //  Assert.IsFalse(result2);
            //games.Add(game);
            //gameManager.AddGame(game);
            //Game takenGame = gameManager.GetGameWith(game.gameId);
            //Assert.AreEqual(games[0], takenGame);
        }

     
        [TestMethod]
        public void DeleteGame_GamesDeletedSuccesfully_Void()
        {
            List<Game> games = new List<Game>();
           

            Game game = new Game(1, "testDeveloper", "testGenre", 9, DateTime.Now, "testTitle", "testDescription");
            games.Add(game);
            //   gameManager.AddGame(game);

            FakeGameDB fakeRepo = new FakeGameDB(games);
            gameManager gameManager = new gameManager(fakeRepo);

            games.Remove(game);
            gameManager.DeleteGame(game.gameId);
            List<Game> takenGames = gameManager.GetAllGames();
           // Assert.IsTrue(games == takenGames);
            Assert.AreEqual(games.Count, takenGames.Count);
        }
        [TestMethod]
        public void GetGame_GameFoundedSuccesfully_Void()
        {
            List<Game> games = new List<Game>();
            

            Game game = new Game(1, "testDeveloper", "testGenre", 9, DateTime.Now, "testTitle", "testDescription");
            games.Add(game);

            FakeGameDB fakeRepo = new FakeGameDB(games);
            gameManager gameManager = new gameManager(fakeRepo);



          //  gameManager.AddGame(game);

            //games.Add(game);
            //gameManager.AddGame(game);
          //  List<Game> gamesyy = gameManager.GetAllGames();
            Game takenGame = gameManager.GetGameWith(1);

            Game foundGame = games.Find(p => p.gameId == 1);

            Assert.AreEqual(foundGame.gameId, takenGame.gameId);
        }
        [TestMethod]
        public void UpdateGame_GameUpdatedSuccesfully_Void()
        {
            List<Game> games = new List<Game>();
        


            Game game = new Game(1, "testDeveloper", "testGenre", 9, DateTime.Now, "testTitle", "testDescription");
            Game UpGame = new Game(1, "testDeveloperrrr", "testGenreeeee", 30, DateTime.Now, "testTitleeeee", "testDescriptionnnnn");


            games.Add(game);
            FakeGameDB fakeRepo = new FakeGameDB(games);
            gameManager gameManager = new gameManager(fakeRepo);


            gameManager.UpdateGame(UpGame);
          //  games.Remove(game);
         //   games.Add(UpGame);
            //  gameManager.AddGame(game);





            Assert.AreNotEqual(game.developer, gameManager.GetGameWith(1).developer);
        }
    }
}
