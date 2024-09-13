using Microsoft.AspNetCore.Mvc;
using Microsoft.Docs.Samples;
using System.Text.Json;

namespace L11.Controllers
{
	public class Product {
		public string name { get; set; } = "Test";
	}

	[Route("api/[controller]")]
	[ApiController]
	public class ProductController : Controller
	{
		/*[Route("")]
		[Route("Product")]
		[Route("Product/Edit/")]*/
		/*[area]*/
		//[Route("[controller]/[action]/{id?}")]
		//Product/Edit/17
		//action area controller handler page
		//{ controller = Product, action = Edit, id = 17 }
		public IActionResult Edit(int id)
		{
			return ControllerContext.MyDisplayRouteInfo(id);
		}

		[HttpPost]
		public IActionResult Edit(int id, Product pd)
		{
			return ControllerContext.MyDisplayRouteInfo(id, pd.name);
		}

		// GET: /api/Product/
		[HttpGet]
		public IActionResult ListProducts()
		{
			return ControllerContext.MyDisplayRouteInfo();
		}

		// GET: /api/Product/{id}
		[HttpGet("{id}")]
		public IActionResult GetProduct(int id)
		{
			return ControllerContext.MyDisplayRouteInfo(id);
		}

		//GET: /api/Product/int/{id}
		[HttpGet("int/{id:int}")]
		public IActionResult GetProductById(int id)
		{
			return ControllerContext.MyDisplayRouteInfo(id);
		}

		//GET: /api/Product/int2/{id}
		[HttpGet("int2/{id}")]
		public IActionResult GetInt2Product(int id)
		{
			return ControllerContext.MyDisplayRouteInfo(id);
		}

		[NonAction]
		public string GetProductJson(Product pd)
		{
			return JsonSerializer.Serialize(pd);
		}
	}
}
