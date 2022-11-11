using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DataAccessLayer;
using BusinessLogicLayer;
using Entities;
using Entities.Enum;
namespace First_ASP.UnitTests.FakeDataAccessLayer
{
    [TestClass]
    public class ReviewManagerTest
    {
        [TestMethod]
        public void CreateReview_ReviewCreatrdSuccesfully_Void()
        {
            List<Review> reviews = new List<Review>();
            Reviewer reviewer = new Reviewer("test", "123", DateTime.Now, AccountType.Reviewer);
            Game game = new Game(1, "testDeveloper", "testGenre", 9, DateTime.Now, "testTitle", "testDescription");
            Review rev = new Review("test", 3, reviewer, game);
            reviews.Add(rev);
            FakeReviewDB fakeRepo = new FakeReviewDB(reviews);
            ReviewerManager reviewerManager = new ReviewerManager(fakeRepo);
            Assert.IsTrue(reviewerManager.CreateReview(rev));
        }
        [TestMethod]
        public void DeleteReview_ReviewDeletedSuccesfully_Void()
        {
            List<Review> reviews = new List<Review>();
            Reviewer reviewer = new Reviewer("test", "123", DateTime.Now, AccountType.Reviewer);
            Game game = new Game(1, "testDeveloper", "testGenre", 9, DateTime.Now, "testTitle", "testDescription");
            Review rev = new Review("test", 3, reviewer, game);
            reviews.Add(rev);
            FakeReviewDB fakeRepo = new FakeReviewDB(reviews);
            ReviewerManager reviewerManager = new ReviewerManager(fakeRepo);
            Assert.IsTrue(reviewerManager.DeleteReview("test", rev.user.Id()));
        }



  


        [TestMethod]
        public void GetAllUserReviews_ReviewFoundSuccesfully_Void()
        {
            List<Review> reviews = new List<Review>();
            Reviewer reviewer = new Reviewer("test", "123", DateTime.Now, AccountType.Reviewer);
            Game game = new Game(1, "testDeveloper", "testGenre", 9, DateTime.Now, "testTitle", "testDescription");
            Review rev = new Review("test", 3, reviewer, game);
            reviews.Add(rev);
            FakeReviewDB fakeRepo = new FakeReviewDB(reviews);
            ReviewerManager reviewerManager = new ReviewerManager(fakeRepo);
            List<Review> foundReviews = reviewerManager.GetAllReviewsWithGame(game);
            Assert.AreEqual(foundReviews[0], reviews[0]);
        }



        [TestMethod]
        public void UpdateReviews_ReviewUpdatedSuccesfully_Void()
        {
            List<Review> reviews = new List<Review>();
            Reviewer reviewer = new Reviewer("test", "123", DateTime.Now, AccountType.Reviewer);
           
            Game game = new Game(1, "testDeveloper", "testGenre", 9, DateTime.Now, "testTitle", "testDescription");
            Review rev = new Review("test", 3, reviewer, game);
            reviews.Add(rev);
            FakeReviewDB fakeRepo = new FakeReviewDB(reviews);
            ReviewerManager reviewerManager = new ReviewerManager(fakeRepo);
            reviewerManager.UpdateReview("testtt", reviewer);
            List<Review> foundReviews = reviewerManager.GetAllReviewsWithGame(game);
           
            Assert.AreEqual(foundReviews[0], reviews[0]);
        }
    }
}
