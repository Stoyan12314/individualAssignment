using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace First_ASP_NET_CORE.Pages
{
    public class IndexModel : PageModel
    {

        //[BindProperty]
       // public Credential credential { get; set; }
        private readonly ILogger<IndexModel> _logger;
        

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
       
    }
}