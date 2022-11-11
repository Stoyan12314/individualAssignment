using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Entities.DTO;
using BusinessLogicLayer.InterfacesForUserManager;
using BusinessLogicLayer;
using DataAccessLayer;
using Entities;
namespace First_ASP_NET_CORE.Pages
{
    public class AccountModel : PageModel
    {
        [BindProperty] public  UpdateDTO updateDTO { get; set; }
        public User user { get; set; }
        public void OnGet()
        {
            IGetUser getUser = new UserManager(new DBUser());
            int user_id = Convert.ToInt32(User.FindFirst("user_id").Value);
             user = getUser.GetUser(user_id);
        }
        public  IActionResult OnPost()
        {
            int user_id = Convert.ToInt32(User.FindFirst("user_id").Value);
         
            IGetUser getUser = new UserManager(new DBUser());
            IUpdatePassword upPas = new UserManager(new DBUser());
             user = getUser.GetUser(user_id);

            if (updateDTO.password == updateDTO.repeatPassword)
            {
                
                upPas.UpdatePassword(user.Username(), updateDTO.password);
            }
           
            return Page();  
        }
    }
}
