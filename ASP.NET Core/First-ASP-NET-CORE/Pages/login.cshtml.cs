using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace First_ASP_NET_CORE.Pages
{
    public class loginModel : PageModel
    {
        [BindProperty]
        public string username { get; set; } 
        public void OnGet()
        {
        }
    }
}
