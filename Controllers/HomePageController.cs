using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace SampleApp.Controllers
{
    public class HomePageController : Controller
    {

        //public IActionResult Index()
        //{
        //    return View();
        //}


        // 
        // GET: /HelloWorld/

        public string Index()
        {
            return "This is my default action...";
        }

        // GET: /HelloWorld/Welcome/ 
        // Requires using System.Text.Encodings.Web;
        public string Welcome(string name, int ID = 1)
        {
            return HtmlEncoder.Default.Encode($"Hello {name}, ID: {ID}");
        }

        // https://docs.microsoft.com/en-us/aspnet/core/tutorials/first-mvc-app/adding-view?view=aspnetcore-3.0&tabs=visual-studio
        //^^^^^ Next step
    }
}
