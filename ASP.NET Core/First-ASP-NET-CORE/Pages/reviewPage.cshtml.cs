using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using BusinessLogicLayer;
using Entities;
using BusinessLogicLayer.InterfacesForGameManager;
using BusinessLogicLayer.interfacesForReviewManager;
using BusinessLogicLayer.InterfacesForUserManager;
using Newtonsoft.Json;
using DataAccessLayer;
using Entities.DTO;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;
namespace First_ASP_NET_CORE.Pages
{
    public class reviewPageModel : PageModel
    {
       // int user_id = Convert.ToInt32(User.FindFirst("user_id").Value);
       
        // bool isAuthenticated = User.Identity.IsAuthenticated;

      [BindProperty]  public ReviewDTO review { get; set; }
         public List<Review> reviews { get; set; }
        int game_id;

         public Game game { get; set; }
        private IGetAllReviewsWithGame GetAllUserReviewsGame;
        private IGetGameWith getGameWith;
        private IGetUser getUser;
        private ICreateReview createReview;
        private IDeleteReview deleteReview;
        private IGetAvgScore getAvgScore;
        //User user { get; set; }


        public int returnLogedUserId(int game_id)
        {
            OnGet(game_id);
            if (User.Identity.IsAuthenticated)
            {
                return Convert.ToInt32(User.FindFirst("user_id").Value);
            }
            return 0;
          
        }
        public double AvgScore(int game_id)
        {
            getAvgScore = new gameManager(new DBgame());
           return  getAvgScore.GetAvgScore(game_id);
        }
        public IActionResult OnGet(int id)
        {
            try
            {
                
                    this.game_id = id;
                    getUser = new UserManager(new DBUser());
                    GetAllUserReviewsGame = new ReviewerManager(new DBReview());
                    getGameWith = new gameManager(new DBgame());
                    game = getGameWith.GetGameWith(game_id);
                reviews = GetAllUserReviewsGame.GetAllReviewsWithGame(game);
                  
                    return Page();
                
                
                 
                
                
              
            }
            catch (Exception)
            {

                throw;
            }
            return Page();
        }
      
     


         public  IActionResult OnPost(int game_id)
        {
            getGameWith = new gameManager(new DBgame());    
            int user_id = Convert.ToInt32(User.FindFirst("user_id").Value);
           
            getUser = new UserManager(new DBUser());
            game = getGameWith.GetGameWith(game_id);
            if (ModelState.IsValid)
            {
                createReview = new ReviewerManager(new DBReview());
                createReview.CreateReview(new Review(review.review, review.score, getUser.GetUser(user_id), game ));
                OnGet(game_id);
                return Page();
            }
            OnGet(game_id);
            return Page();
        }

        public IActionResult OnPostReviewDelete(int user_id, string review, int game_id)
        {
            deleteReview = new ReviewerManager(new DBReview());

                deleteReview.DeleteReview(review, user_id);
                OnGet(game_id);
                return Page();
          

        }


    }

}
