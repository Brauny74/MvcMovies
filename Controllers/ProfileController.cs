using Microsoft.AspNetCore.Mvc;
using L11.Models;

namespace L11.Controllers
{
	public class ProfileController : Controller
	{
		public IActionResult Index()
		{
			var profile = new Profile
			{
				Name = "Сергей",
				FavGenre = "комедия",
				Gender = "муж",
				Oblast = new Oblast("Челябинск", 74)
			};
			return View(profile);
		}
	}
}
