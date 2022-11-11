using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using System.Security.Claims;
using BusinessLogicLayer.InterfacesForUserManager;
using BusinessLogicLayer;
using DataAccessLayer;
using Entities.DTO;
namespace First_ASP_NET_CORE.Pages
{
    public class loginModel : PageModel
    {



        [BindProperty] public RegisterLogin Register { get; set; }

        
        private readonly IGetUser getUser = new UserManager(new DBUser());
        private readonly IFindUserId userId = new UserManager(new DBUser());
   


        public loginModel()
        {

        }

        public void OnGet()
        {
            
        }


        public async void Auth(string user)
        {
            var authProperties = new AuthenticationProperties
            {
                ExpiresUtc = DateTimeOffset.UtcNow.AddMinutes(28)
            };

            var claims = new List<Claim>();
            claims.Add(new Claim("user_id", userId.FindUserId(user)));
            claims.Add(new Claim(ClaimTypes.Name, user));


            var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);


            await HttpContext.SignInAsync(new ClaimsPrincipal(claimsIdentity), authProperties);
        }
        public ActionResult OnPostAsync()
        {
          
            ILogin login = new UserManager(new DBUser());
            if (ModelState.IsValid)
            {
                if (login.CheckLogin(Register.password, Register.username))
                {
                    Auth(Register.username);
                    return RedirectToPage("/home");
                }
            }
            return Page();
        }

       
    }
}
