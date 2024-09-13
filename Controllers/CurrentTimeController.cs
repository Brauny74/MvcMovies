using L11.Models;
using Microsoft.AspNetCore.Mvc;

namespace L11.Controllers
{
	public class CurrentTimeController : Controller
	{
		private readonly IDateTime _dateTime;

		public CurrentTimeController(IDateTime dateTime)
		{ 
			_dateTime = dateTime;
		}

		public IActionResult Index()
		{
			var serverTime = _dateTime.Now;
			string msg = string.Empty;
			if (serverTime.Hour < 12)
				msg = "Good Morning!";
			else if (serverTime.Hour < 17)
				msg = "Good Day!";
			else
			{
				msg = "Good Evening!";
			}
			ViewData["Message"] = msg;

			return View();
		}
	}
}
