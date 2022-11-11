using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
namespace First_ASP_NET_CORE.Pages
{
    [Authorize]
    public class LogOutModel : PageModel
    {
        public IActionResult OnGet()
        {
            HttpContext.SignOutAsync();
            HttpContext.Session.Clear();
            return RedirectToPage("/index");
        }
    }
}
