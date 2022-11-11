using Entities;
using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using Entities.Enum;
using Entities;
namespace DataAccessLayer
{
    public class DBUser : DataAccess, IUserDB
    {
        DBChecks check = new DBChecks();
        public bool CreateUser(string username, string password, DateTime creationDate)
        {
          //  return false;
            try
            {
              
                con.Open();
                string sql = "insert into users (user_name, password, creation_date, accountType) values(@user_name, @password, @creation_date, @accountType);";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("user_name", username);
                cmd.Parameters.AddWithValue("password", password);
                cmd.Parameters.AddWithValue("creation_date", creationDate);
                cmd.Parameters.AddWithValue("accountType", AccountType.Reviewer.ToString());

                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }
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

                       

                        users.Add(new Admin (dr.GetInt32("user_id"), dr.GetString("user_name"), dr.GetString("password"), dr.GetDateTime("creation_date"), dr.GetInt32("badges"), dr.GetInt32("number_written_reviews"), accType));


                        //users.Add(new Admin
                        //{
                        //    id = dr.GetInt32("user_id"),

                        //    (dr.GetInt32("user_id"), dr.GetString("user_name"), dr.GetString("password"), dr.GetDateTime("creation_date"), dr.GetInt32("badges"), dr.GetInt32("number_written_reviews"), accType)
                        //});
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
            finally
            {
                con.Close();
            }
        }
        public bool DeleteUser(User user)
        {
            throw new NotImplementedException();
        }
        public void UpdateUser(string username, string password, string oldUsername)
        {
            try
            {
                con.Open();
                var cmd = new MySqlCommand("UPDATE users SET user_name = @new_user_name, password = @password  WHERE user_name = @old_username", con);
                cmd.Parameters.AddWithValue("@new_user_name", username);
                cmd.Parameters.AddWithValue("@password", password);
                cmd.ExecuteNonQuery();
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
        public Reviewer GetUser(int id)
        {
            try
            {
                con.Open();
                Reviewer user = null;
                var cmd = con.CreateCommand();
                //user_id, user_name, password, creation date, badges, number written reviews
                cmd.CommandText = "Select user_id, user_name, password, creation_date, badges, number_written_reviews, accountType from users where user_id = @id";
                cmd.Parameters.AddWithValue("@id", id);
                MySqlDataReader dr = cmd.ExecuteReader();
                //int id, string username, string password, DateTime creation_date, int badges, int number_written_reviews
                if (dr.Read())
                {
                    AccountType accType = Enum.Parse<AccountType>(dr.GetString("accountType"));
                    if (accType == AccountType.Reviewer)
                    {
                        user = new Reviewer(dr.GetInt32("user_id"), dr.GetString("user_name"), dr.GetString("password"), dr.GetDateTime("creation_date"), dr.GetInt32("badges"), dr.GetInt32("number_written_reviews"));
                    }
                }
                return user;
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

        public string FindUserId(string username)
        {
            try
            {
                con.Open();
                string id = null;
                var cmd = con.CreateCommand();
                //user_id, user_name, password, creation date, badges, number written reviews
                cmd.CommandText = "Select user_id from users where user_name = @user_name";
                cmd.Parameters.AddWithValue("@user_name", username);
                MySqlDataReader dr = cmd.ExecuteReader();
                //int id, string username, string password, DateTime creation_date, int badges, int number_written_reviews
                if (dr.Read())
                {
                   
                        id = dr.GetInt32("user_id").ToString();
                    
                }
                return id;
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

        public void UpdateUsername(string username, string oldUsername)
        {
            try
            {
                con.Open();
                var cmd = new MySqlCommand("UPDATE users SET user_name = @username  WHERE user_name = @oldUsername", con);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@oldUsername", oldUsername);
                cmd.ExecuteNonQuery();
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
        public void UpdatePassword(string username, string password)
        {
            try
            {
                con.Open();
                var cmd = new MySqlCommand("UPDATE users SET password = @password  WHERE user_name = @Username", con);
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@password", password);
                cmd.ExecuteNonQuery();
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
        //public List<User> GetAllUsers()
        //{
        //    try
        //    {
        //        List<User> users = new List<User>();
        //        con.Open();

        //        var cmd = con.CreateCommand();
        //        cmd.CommandText = "SELECT * from users";
        //        MySqlDataReader dr = cmd.ExecuteReader();

        //        while (dr.Read())
        //        {
        //            AccountType accType = Enum.Parse<AccountType>(dr.GetString("accountType"));

        //            if (accType == AccountType.Admin)
        //            {
        //                users.Add(new Admin(dr.GetInt32("user_id"), dr.GetString("user_name"), dr.GetString("password"), dr.GetDateTime("creation_date"), dr.GetInt32("badges"), dr.GetInt32("number_written_reviews"), accType));
        //            }
        //            else
        //            {
        //                users.Add(new Reviewer(dr.GetInt32("user_id"), dr.GetString("user_name"), dr.GetString("password"), dr.GetDateTime("creation_date"), dr.GetInt32("badges"), dr.GetInt32("number_written_reviews"), accType));
        //            }
        //            //int id, string username, string password, DateTime creation_date, int badges, int number_written_reviews, AccountType accType
        //            // users.Add(new User(dr.GetInt32("user_id"), dr.GetString("user_name"), dr.GetString("password"), dr.GetDateTime("creation_date"), dr.GetInt32("badges"), dr.GetInt32("number_written_reviews"), dr.GetEnumerator("accountType"));
        //        }
        //        return users;
        //    }
        //    catch (Exception)
        //    {

        //        throw;
        //    }
        //    finally
        //    {
        //        this.con.Close();
        //    }
        //}
    }
}
