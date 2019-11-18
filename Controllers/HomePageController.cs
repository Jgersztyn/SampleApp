using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace SampleApp.Controllers
{
    public class HomePageController : Controller
    {
        // 
        // GET: /Movie/
        public IActionResult Index()
        {
            return View();
        }

        // GET: /Movie/Welcome/ 
        // Requires using System.Text.Encodings.Web;
        public IActionResult Welcome(string name, int ID = 1)
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["ID"] = ID;

            return View();
        }

        //
        // https://docs.microsoft.com/en-us/aspnet/core/tutorials/first-mvc-app/working-with-sql?view=aspnetcore-3.0&tabs=visual-studio
        //^^^^^ Next step
    }
}
