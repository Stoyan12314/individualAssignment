using System;
using System.Collections.Generic;
using System.Text;
using BusinessLogicLayer;
using BusinessLogicLayer.InterfacesForGameManager;
using First_ASP.UnitTests.FakeDataAccessLayer;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entities;
using Entities.Enum;
namespace First_ASP.UnitTests
{
    [TestClass]
    public class UserManagerTest
    {
        [TestMethod]
        
        public void CreateUser_UserCreatedSuccesfully_void()
        {
            List<User> users = new List<User>();
            FakeUserDB fakeRepo = new FakeUserDB(users);
            UserManager userManager = new UserManager(fakeRepo);

            var result1 =   userManager.Register("test", "123");
           
           
            Assert.IsTrue(result1);
           
        }

        [TestMethod]
        public void FindUserId_UserFoundSuccesfully_void()
        {
            List<User> users = new List<User>();
            Reviewer rev = new Reviewer(1,"test");
            users.Add(rev);
            FakeUserDB fakeRepo = new FakeUserDB(users);
            UserManager userManager = new UserManager(fakeRepo);
           string found =  userManager.FindUserId("test");
        
            Assert.AreEqual(rev.Id().ToString(), found);
           
          

        }


       



        [TestMethod]
        public void GetUser_UserFoundSuccesfully_void()
        {
            List<User> users = new List<User>();
            Reviewer rev = new Reviewer(1, "test");
            users.Add(rev);
            FakeUserDB fakeRepo = new FakeUserDB(users);
            UserManager userManager = new UserManager(fakeRepo);
            Reviewer found = (Reviewer)userManager.GetUser(1);
         
            Assert.AreEqual(rev.Id(), found.Id());
            


        }
        [TestMethod]
        public void UpdatePassword_UserPasswordUpdatedSuccesfully_Void()
        {
            List<User> users = new List<User>();
            Reviewer rev = new Reviewer("test", "123", DateTime.Now, AccountType.Reviewer);
            users.Add(rev);
            FakeUserDB fakeRepo = new FakeUserDB(users);
            UserManager userManager = new UserManager(fakeRepo);
            userManager.UpdatePassword(rev.Username(), "4");
            string user_id = userManager.FindUserId("test");
            Reviewer found = (Reviewer)userManager.GetUser(Convert.ToInt32(user_id));
          
            Assert.AreNotEqual(rev.Password(), found.Password());
            
        }


        [TestMethod]
        public void UpdateUsername_UserNameUpdatedSuccesfully_Void()
        {
            List<User> users = new List<User>();
            Reviewer rev = new Reviewer("test", "123", DateTime.Now, AccountType.Reviewer); 
            users.Add(rev);
            FakeUserDB fakeRepo = new FakeUserDB(users);
            UserManager userManager = new UserManager(fakeRepo);
            userManager.UpdateUsername("testttttttt", rev.Username());
            string user_id = userManager.FindUserId("testttttttt"); // user_id is automatically 0 
            Reviewer found = (Reviewer)userManager.GetUser(Convert.ToInt32(user_id));

            Assert.AreNotEqual(rev.Username(), found.Username());

        }


    }
}
