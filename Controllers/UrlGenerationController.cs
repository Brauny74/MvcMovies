using Microsoft.AspNetCore.Mvc;
using Microsoft.Docs.Samples;

namespace L11.Controllers
{
	public class UrlGenerationController : Controller
	{
		[HttpGet("custom")]
		public IActionResult Source()
		{
			var url = Url.Action("Destination");

			return ControllerContext.MyDisplayRouteInfo("", $"URL = {url}");
		}

		//{a}/{b}/{c}/{d}
		//{a = Alice, b = Bob, c = Carol, d = David}
		
		//{ d = Donovan}
		//Alice/Bob/Carol/Donovan
		//{ c = Cheryl }
		//Alice/Bob/Cheryl

		//{controller}/{action}/{id?}

		[HttpGet("custom/url/to/destination", Name = "Destination_Route")]
		public IActionResult Destination()
		{
			return ControllerContext.MyDisplayRouteInfo();
		}
	}
}
