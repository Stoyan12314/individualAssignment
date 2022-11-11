using System;
using System.Collections.Generic;
using System.Text;
using Entities;
using MySql.Data.MySqlClient;

namespace DataAccessLayer
{
    public class DBReview : DataAccess, IReviewDB 
    {
        public bool CreateReview(Review review)
        {
            try
            {
                con.Open();
                var cmd = con.CreateCommand();
                var command = con.CreateCommand();
                command.CommandText =
                    "INSERT INTO review (game_id,user_id,score,review) VALUES (@game_id, @user_id, @score, @review)";
                command.Parameters.AddWithValue("@game_id", review.game.gameId);
                command.Parameters.AddWithValue("@user_id", review.user.Id());
                command.Parameters.AddWithValue("@score", review.score);
                command.Parameters.AddWithValue("@review", review.review);
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

        public bool DeleteReview(string review, int  user_id)
        {
                try
                {
                    con.Open();
                    var cmd = con.CreateCommand();
                    cmd.CommandText = "DELETE from review where  user_id=@user_id and review=@review";
                    cmd.Parameters.AddWithValue("@review", review);
                    cmd.Parameters.AddWithValue("@user_id", user_id);
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

        public List<Review> GetAllUserReviews(User user)
        {
            try
            {
                List<Review> reviews = new List<Review>();
                con.Open();
                var cmd = con.CreateCommand();
                cmd.CommandText = "select g.game_name, r.score, r.review from review as r inner join users as u on r.user_id = u.user_id inner join game as g on r.game_id = g.game_id where u.user_id = @user_id";
                cmd.Parameters.AddWithValue("@user_id", user.Id());
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Game game = new Game(dr.GetString("game_name"));
                    reviews.Add(new Review(dr.GetString("review"), dr.GetInt32("score"), game));
                }
                return reviews;
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



        public List<Review> GetAllUserReviewsGame(Game game)
        {
            try
            {
                List<Review> reviews = new List<Review>();
                con.Open();
                var cmd = con.CreateCommand();
                //  select g.game_name, r.score, r.review from review as r inner join users as u on r.user_id = u.user_id inner join game as g on r.game_id = g.game_id where g.game_id = @game_id
             //   cmd.CommandText = "select g.game_name, r.score, r.review from review as r inner join game as g on g.game_id = r.game_id where g.game_id = @game_id";
                cmd.CommandText = " select u.user_name, u.user_id, g.game_name, r.score, r.review from review as r inner join users as u on r.user_id = u.user_id inner join game as g on r.game_id = g.game_id where g.game_id = @game_id";

                cmd.Parameters.AddWithValue("@game_id", game.gameId);
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Reviewer user = new Reviewer(dr.GetInt32("user_id"),dr.GetString("user_name"));
                    reviews.Add(new Review(dr.GetString("review"), dr.GetInt32("score"),user, game));
                }
                return reviews;
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



        public bool UpdateReview(string review, User user)
        {
            try
            {
                con.Open();
                var cmd = new MySqlCommand("UPDATE tournaments SET review = @review,  WHERE username = @username");
                cmd.Parameters.AddWithValue("@username", user.Username());
                cmd.Parameters.AddWithValue("@review", review);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception)
            {

                throw;
            }
            finally 
            {
                this.con.Close();
            }
        }

        public bool UpdateReview(User user)
        {
            throw new NotImplementedException();
        }
    }
}
