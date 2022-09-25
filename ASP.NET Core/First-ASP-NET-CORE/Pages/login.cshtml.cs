using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using System.Security.Claims;

namespace First_ASP_NET_CORE.Pages
{
    public class loginModel : PageModel
    {

        [BindProperty]
        public Credential credential { get; set; }
        
        //when i use a class i need to have a empty ctor 

      

        public void OnGet()
        {
           
        }
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid) return Page();

            if (credential.Email == "admin" && credential.Password == "123")
            {
                var claims = new List<Claim> {
                   new Claim (ClaimTypes.Email, "admin"),
                   new Claim ("Password","123")
                };
                var identity = new ClaimsIdentity(claims, "MyCookieAuth");
                ClaimsPrincipal claimsPrincipal = new ClaimsPrincipal(identity);

                await HttpContext.SignInAsync("MyCookieAuth", claimsPrincipal);

                return RedirectToPage("/Index");
            }
            return Page();  
        }
        public class Credential
        {
            public Credential()
            {

            }
            [Required]
            public string? Email { get; set; }
            [Display(Name = "Email address")]

            [Required]
            [DataType(DataType.Password)]
            public string? Password { get; set; }
            

        }
    }
}
