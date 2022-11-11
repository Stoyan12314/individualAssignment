using System;
using System.Collections.Generic;
using System.Text;
using Entities;
namespace DataAccessLayer
{
    public class DBChecks : DataAccess
    {
        public  bool CheckForRepeatingGames(Game game)
        {
            con.Open();
            var cmd = con.CreateCommand();
            cmd.CommandText = "SELECT game_name from game where game_name = @name";
            cmd.Parameters.AddWithValue("@name", game.title);
            if (cmd.ExecuteScalar() != null)
            {
                return false;
            }
            return true;    
        }

        public  bool CheckForRepeatingUsers(User user)
        {
            con.Open();
            var cmd = con.CreateCommand();
            cmd.CommandText = "SELECT user_name from users where user_name = @name";
            cmd.Parameters.AddWithValue("@name", user.Username());
            if (cmd.ExecuteScalar() != null)
            {
                return false;
            }
            return true;
        }
    }
}
