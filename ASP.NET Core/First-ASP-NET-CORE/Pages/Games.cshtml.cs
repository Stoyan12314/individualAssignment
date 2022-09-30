using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.IO;
using System.Drawing;
using BusinessLogicLayer;
using DataAccessLayer;
namespace First_ASP_NET_CORE.Pages
{
    public class GamesModel : PageModel
    {
        public DBgame Dbgame { get; set; }

        public GamesModel()
        {
                Dbgame = new DBgame();
        }
        
        public ActionResult GetImage(byte[] m)
        {
            return File(m, "image/jpeg");
        }
        //public Task<IActionResult> MyAction(Game game)
        //{

        //  //  return RedirectToRoute("/reviewPage", "SingleOrder", new { game = game });
        //}
        public void OnGet()
        {

        }
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
