using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace SchoolApp.Controllers
{
    public class School : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public string Hi()
        {
            return "This is my default action...";
        }
        public IActionResult Welcome(string name, int numTimes = 1)
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;
            return View();
        }
    }
}
