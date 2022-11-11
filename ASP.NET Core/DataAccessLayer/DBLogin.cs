using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using Entities;
using Entities.Enum;
namespace DataAccessLayer
{
    public class DBLogin : DataAccess 
    {
      
       
        public List<User> GetAllUsers()
        {
            try
            {
                List<User> users = new List<User>();
                con.Open();

                var cmd = con.CreateCommand();
                cmd.CommandText = "SELECT * from users";
                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    AccountType accType = Enum.Parse<AccountType>(dr.GetString("accountType"));

                    if (accType == AccountType.Admin)
                    {
                        users.Add(new Admin(dr.GetInt32("user_id"), dr.GetString("user_name"), dr.GetString("password"), dr.GetDateTime("creation_date"), dr.GetInt32("badges"), dr.GetInt32("number_written_reviews"), accType));
                    }
                    else
                    {
                        users.Add(new Reviewer(dr.GetInt32("user_id"), dr.GetString("user_name"), dr.GetString("password"), dr.GetDateTime("creation_date"), dr.GetInt32("badges"), dr.GetInt32("number_written_reviews"), accType));

                    }
                    //int id, string username, string password, DateTime creation_date, int badges, int number_written_reviews, AccountType accType
                    // users.Add(new User(dr.GetInt32("user_id"), dr.GetString("user_name"), dr.GetString("password"), dr.GetDateTime("creation_date"), dr.GetInt32("badges"), dr.GetInt32("number_written_reviews"), dr.GetEnumerator("accountType"));
                }
                return users;



            }
            catch (Exception)
            {

                throw;
            }
        }
        public bool Register(string password, string username)
        {
            return true;
           

        }
    }
}
