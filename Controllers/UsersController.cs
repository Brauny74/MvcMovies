using Microsoft.AspNetCore.Mvc;

namespace L11.Controllers
{
	[Area("Blog")]
	public class UsersController : Controller
	{
		//GET /manage/users/adduser
		public IActionResult AddUser()
		{
			var area = ControllerContext.ActionDescriptor.RouteValues["area"];
			var actionName = ControllerContext.ActionDescriptor.ActionName;
			var controllerName = ControllerContext.ActionDescriptor.ControllerName;

			return Content($"Area: {area}, Controller: {controllerName}, Action: {actionName}");
		}
	}
}
