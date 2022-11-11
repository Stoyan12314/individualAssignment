using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Entities;
using BusinessLogicLayer;
using BusinessLogicLayer.InterfacesForUserManager;
using Entities.DTO;
using DataAccessLayer;
using Microsoft.AspNetCore.Authentication;

namespace First_ASP_NET_CORE.Pages
{
    public class RegisterModel : PageModel
    {
        //private UserManager userManager;
       // [BindProperty] public Reviewer reviewer {get; set;}
        [BindProperty] public RegisterLogin Register { get; set; }
        //[BindProperty]
        // public Credential credential { get; set; }
        // private readonly ILogger<RegisterModel> _logger;

        private IRegister register = new UserManager(new DBUser());
        public RegisterModel()
        {
          

        }
        private void Updare()
        {
            //HttpContext.SignOutAsync();
            // HttpContext.Session.Clear();
        }
        public void OnGet()
        {
          
        }

        public IActionResult OnPost()
        {


            if (ModelState.IsValid)
            {
                try
                {
                    
                    bool registrationSucessful = register.Register(Register.password, Register.username);
                    if (registrationSucessful)
                    {
                        return new RedirectToPageResult("/login");
                    }
                    else
                    {
                        return Page();
                    }
                }
                catch (Exception ex)
                {
                    return new RedirectToPageResult("Error");
                }
                

               
            }
            else
            {
                return Page();
            }
        }

    }
}