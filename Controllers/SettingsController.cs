using L11.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace L11.Controllers
{
	public class SettingsController : Controller
	{
		private readonly SampleWebSettings _settings;

		public SettingsController(IOptions<SampleWebSettings> settingsOptions)
		{ 
			_settings = settingsOptions.Value;
		}

		public IActionResult Index()
		{
			ViewData["Title"] = _settings.Title;
			ViewData["Updates"] = _settings.Updates;
			return View();
		}
	}
}
