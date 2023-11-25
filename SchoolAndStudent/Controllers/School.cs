using Microsoft.AspNetCore.Mvc;

namespace SchoolAndStudent.Controllers
{
    public class School : Controller
    {
        public IActionResult Data(string name, int numTime = 1)
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTime;
            return View();
        }
    }
}
