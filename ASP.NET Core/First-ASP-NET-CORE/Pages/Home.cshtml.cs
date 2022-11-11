using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Entities;
using BusinessLogicLayer;
using BusinessLogicLayer.InterfacesForGameManager;
using DataAccessLayer;
namespace First_ASP_NET_CORE.Pages
{
    public class HomeModel : PageModel
    {
        private IGetAllGames getGames = new gameManager(new DBgame());
        List<Game> games;

        public List<Game> Games()
        {
          //  (var game in @Model.Games().OrderByDescending(x => x.releaseDate).ToList())
            return games = getGames.GetAllGames().OrderByDescending(x => x.releaseDate).ToList();
        }
        public void OnGet()
        {

        }
    }
}
