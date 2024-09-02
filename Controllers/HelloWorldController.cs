using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace L11.Controllers
{
    /*
     * Добавить контроллер, главная страница которого выводит текущую дату.
     * 
     * Страница, которая принимает число в качестве параметра и выводит все его делители.
     */

    public class HelloWorldController : Controller
    {
        //GET: /HelloWorld/
        public IActionResult Index()
        {
            return View();
        }

        //GET: /HelloWorld/Welcome
        public IActionResult Welcome(string name, int numTimes = 1)
        {
            ViewData["Message"] = $"Hello, {name}";
            ViewData["NumTimes"] = numTimes;

            return View();
        }
    }
}
