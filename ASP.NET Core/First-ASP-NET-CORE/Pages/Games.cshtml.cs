using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.IO;
using System.Drawing;
using BusinessLogicLayer;
using DataAccessLayer;
using BusinessLogicLayer.InterfacesForGameManager;
namespace First_ASP_NET_CORE.Pages
{
    public class GamesModel : PageModel
    {
        public IGetAllGames IGetAllGames { get; set; }
       // public gameManager gameManager { get; set; }

        public GamesModel()
        {
            IGetAllGames = new gameManager(new DBgame());  
        }
        
       
        //public Task<IActionResult> MyAction(Game game)
        //{

        //  //  return RedirectToRoute("/reviewPage", "SingleOrder", new { game = game });
        //}
       
        //public Image getProduct_Image(byte[] imagebytes)
        //{
        //    byte[] byteArray = new byte[imagebytes.Length];

        //    MemoryStream ms = new MemoryStream(byteArray);
        //    ms.Position = 0;

        //    ms.Read((byteArray, 0, byteArray.Length);
        //    ms.ToArray();
        //    ms.Seek(0, SeekOrigin.Begin);
        //    System.Drawing.Image returnImage = Image.FromStream((Stream)ms);
        //    Bitmap bmp = new Bitmap(returnImage);
        //    return bmp;
        //}

    }
}
