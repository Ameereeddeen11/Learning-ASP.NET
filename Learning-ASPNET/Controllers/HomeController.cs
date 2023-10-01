using Learning_ASPNET.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Learning_ASPNET.Controllers
{
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;

		public HomeController(ILogger<HomeController> logger)
		{
			_logger = logger;
		}

		public IActionResult Index()
		{
			Generator generator = new Generator();
			ViewBag.Number = generator.BringNumber();
			return View();
		}

		public IActionResult Privacy()
		{
			return View();
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}

		public IActionResult Calculator()
		{
			Calculartor calculartor = new Calculartor();
			return View(calculartor);
		}

		[HttpPost]
		public IActionResult Calculator(Calculartor calculartor)
		{
			if (ModelState.IsValid)
			{
				calculartor.Calculate();
			}
            return View(calculartor);
        }
	}
}