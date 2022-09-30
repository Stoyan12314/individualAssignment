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
        public bool AddGame(Game game) 
        {
            try
            {
                con.Open();
                var cmd = con.CreateCommand();
                cmd.CommandText = "SELECT game_name from game where game_name = @name";
                cmd.Parameters.AddWithValue("@name", game.title);
                if (cmd.ExecuteScalar() != null)
                {
                    return false;
                }
                var command = con.CreateCommand();
                command.CommandText =
                    "INSERT INTO game (game_image,game_name,developer,genre,time_to_complete,release_date,avg_score,description) VALUES (@image, @name, @developer, @genre, @time_to_comp,@release_date,@avg_score,@description)";
                command.Parameters.AddWithValue("@image", game.image);
                command.Parameters.AddWithValue("@name", game.title);
                command.Parameters.AddWithValue("@developer", game.developer);
                command.Parameters.AddWithValue("@genre", game.genre);
                command.Parameters.AddWithValue("@time_to_comp", game.gameTime);
                command.Parameters.AddWithValue("@release_date", game.releaseDate);
                command.Parameters.AddWithValue("@avg_score", game.avgScore);
                command.Parameters.AddWithValue("@description", game.description);

                command.ExecuteNonQuery();
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
                //int id, string developer, string genre, int gameTime, DateTime releaseDate, string title, string description, Byte[] image
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
   
       
            
        

     
    }

}


