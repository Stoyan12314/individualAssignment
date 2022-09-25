using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using BusinessLogicLayer;

namespace DataAccessLayer
{
    public class DBgame: DataAccess
    {
       

        public bool AddGame(Game game, Byte[] image) 
        {
            con.Open();
            var cmd = con.CreateCommand();
            cmd.CommandText = "SELECT game_name from game where game_name = @name";
            cmd.Parameters.AddWithValue("@name", game.GameTitle());
            if (cmd.ExecuteScalar() != null)
            {
                return false;
            }
            var command = con.CreateCommand();
            command.CommandText =
                "INSERT INTO game (game_image,game_name,developer,genre,time_to_complete,release_date,avg_score,description) VALUES (@image, @name, @developer, @genre, @time_to_comp,@release_date,@avg_score,@description)";
            command.Parameters.AddWithValue("@image", image);
            command.Parameters.AddWithValue("@name", game.GameTitle());
            command.Parameters.AddWithValue("@developer", game.Developer());
            command.Parameters.AddWithValue("@genre", game.Genre());
            command.Parameters.AddWithValue("@time_to_comp", game.GameTime());
            command.Parameters.AddWithValue("@release_date", game.ReleaseDate());
            command.Parameters.AddWithValue("@avg_score", game.AvgScore());
            command.Parameters.AddWithValue("@description", game.Description());

            command.ExecuteNonQuery();
            return true;    
        }


    }
}
