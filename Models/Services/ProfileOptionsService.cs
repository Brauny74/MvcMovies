using L11.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;

namespace L11.Models.Services
{
	public class ProfileOptionsService
	{
		public List<string> ListGenders()
		{
			return new List<string> { "муж", "жен" };
		}

		public List<Oblast> ListOblasts()
		{
			return new List<Oblast>
			{
				new Oblast("Челябинск", 74),
				new Oblast("Екатеринбург", 96),
				new Oblast("Тюмень", 72),
				new Oblast("Курган", 45),
				new Oblast("Башкортостан", 2)
			};
		}

		public List<string> ListGenres()
		{
			return new List<string>
			{ 
				"комедия", "фантастика", "романтика", "драма"
			};
		}
	}
}
