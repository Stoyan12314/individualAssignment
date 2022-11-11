using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using MySql.Data.MySqlClient;
using System.Data;
using static System.Net.Mime.MediaTypeNames;
using Entities;

namespace DataAccessLayer
{
    public class DBgame: DataAccess, IGameDB
    {

        public DBgame()
        {

        }
        public void AddGame(Game game) 
        {
            try
            {
                con.Open();
                var command = con.CreateCommand();
                command.CommandText =
                    "INSERT INTO game (game_image,game_name,developer,genre,time_to_complete,release_date,description) VALUES (@image, @name, @developer, @genre, @time_to_comp,@release_date,@description)";
                command.Parameters.AddWithValue("@image", game.image);
                command.Parameters.AddWithValue("@name", game.title);
                command.Parameters.AddWithValue("@developer", game.developer);
                command.Parameters.AddWithValue("@genre", game.genre);
                command.Parameters.AddWithValue("@time_to_comp", game.gameTime);
                command.Parameters.AddWithValue("@release_date", game.releaseDate);
                command.Parameters.AddWithValue("@description", game.description);

                command.ExecuteNonQuery();
               
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                con.Close();
            }
            
        }

        
        public List<Game> GetAllGames()
        {

            try
            {
                List<Game> games = new List<Game>();
                con.Open();
                var cmd = con.CreateCommand();
                cmd.CommandText = "SELECT * from game";
                MySqlDataReader dr = cmd.ExecuteReader();
                byte[] picture = null;
                while (dr.Read())
                {
                    picture = (byte[])dr["game_image"];
                    games.Add(new Game(dr.GetInt32("game_id"), dr.GetString("developer"), dr.GetString("genre"), dr.GetInt32("time_to_complete"), dr.GetDateTime("release_date"), dr.GetString("game_name"), dr.GetString("description"), picture));
                }
                return games;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                con.Close();
            }
           
        }

        public bool Delete(int id)
        {
            try
            {
                con.Open();
                var cmd = con.CreateCommand();
                cmd.CommandText = "DELETE from game where game_id=@id";
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception)
            {

                throw;
            }
            finally 
            { 
                con.Close(); 
            }
        }
        public Game GetGameWith(int id)
        {
            try
            {
                con.Open();
                Game game = null;
                var cmd = con.CreateCommand();
                cmd.CommandText = "Select * from game where game_id = @id";
                cmd.Parameters.AddWithValue("@id", id);
                MySqlDataReader dr = cmd.ExecuteReader();
                byte[] picture = null;
                if (dr.Read())
                {
                    picture = (byte[])dr["game_image"];
                    game = new Game(dr.GetInt32("game_id"), dr.GetString("developer"), dr.GetString("genre"), dr.GetInt32("time_to_complete"), dr.GetDateTime("release_date"), dr.GetString("game_name"), dr.GetString("description"), picture);
                }
                return game;
            }
            catch (Exception)
            {

                throw;
            }
            finally 
            {
                con.Close(); 
            }
        }
        public double GetAvgScore(int game_id)
        {
            try
            {

                //SELECT AVG(score) AS avgScore FROM review where game_id = @game_id;
                con.Open();
                double avgScore= 0;
                var cmd = con.CreateCommand();
                cmd.CommandText = "SELECT AVG(score) AS avgScore FROM review where game_id = @game_id";
                cmd.Parameters.AddWithValue("@game_id", game_id);
                MySqlDataReader dr = cmd.ExecuteReader();
              
                if (dr.Read())
                {
                            avgScore = dr.GetDouble("avgScore");
                }
                return avgScore;
            }
            catch (Exception)
            {
                return 0;
               // throw;
            }
            finally 
            {
                this.con.Clone();
            }
        }

        public void UpdateGame(Game game)
        {
            try
            {
               // game_image,game_name,developer,genre,time_to_complete,release_date,avg_score,description
                con.Open();
                var cmd = new MySqlCommand("UPDATE game SET game_image = @game_image, game_name = @game_name, developer = @developer, genre = @genre, time_to_complete = @time_to_complete, release_date = @release_date, description = @description WHERE game_id = @id", con);
                cmd.Parameters.AddWithValue("@id", game.gameId);
                cmd.Parameters.AddWithValue("@game_image", game.image);
                cmd.Parameters.AddWithValue("@game_name", game.title);
                cmd.Parameters.AddWithValue("@developer", game.developer);
                cmd.Parameters.AddWithValue("@genre", game.genre);
                cmd.Parameters.AddWithValue("@time_to_complete", game.gameTime);
                cmd.Parameters.AddWithValue("@release_date", game.releaseDate);
                cmd.Parameters.AddWithValue("@description", game.description);
                
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}


