using L11.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Razor;
using System.Diagnostics;

namespace L11.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        [ViewData]
        public string Title { get; set; }

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            Title = "Movies";
            return View();
        }

        public IActionResult Privacy()
        {
            Title = "Privacy Policy";
            return View();
        }

        public IActionResult About()
        {
            ViewBag.Address = new Address
            { 
                Street = "Main Street",
                HouseNumber = "123",
                City = "Gorodok"
            };

            Title = "About us";
            ViewData["Message"] = "Your web-application description page.";

            return View("Views/Home/About.cshtml");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}