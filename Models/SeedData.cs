using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using L11.Data;
using System;
using System.Linq;

namespace L11.Models
{
	public static class SeedData
	{
		public static void Initialize(IServiceProvider serviceProvider)
		{
			using (var context = new MvcMovieContext(
				serviceProvider.GetRequiredService<DbContextOptions<MvcMovieContext>>()
				))
			{
				if (context.Movie.Any())
					return;

				context.Movie.AddRange(
					new Movie
					{ 
						Title = "Когда Гарри встретил Салли",
						ReleaseDate = DateTime.Parse("1989-2-12"),
						Genre = "романтика",
						Price = 450.0m
					},
					new Movie
					{
						Title = "Назад в будущее",
						ReleaseDate = DateTime.Parse("1985-7-3"),
						Genre = "фантастика",
						Price = 500.0m
					},
					new Movie
					{
						Title = "Назад в будущее 2",
						ReleaseDate = DateTime.Parse("1989-11-22"),
						Genre = "фантастика",
						Price = 500.0m
					},
					new Movie
					{
						Title = "Назад в будущее 3",
						ReleaseDate = DateTime.Parse("1990-5-25"),
						Genre = "фантастика",
						Price = 500.0m
					},
					new Movie
					{
						Title = "Охотники за приведениями",
						ReleaseDate = DateTime.Parse("1984-3-13"),
						Genre = "комедия",
						Price = 560.0m
					},
					new Movie
					{
						Title = "Охотники за приведениями 2",
						ReleaseDate = DateTime.Parse("1986-2-23"),
						Genre = "комедия",
						Price = 560.0m
					},
					new Movie
					{
						Title = "Роки",
						ReleaseDate = DateTime.Parse("1976-12-3"),
						Genre = "спортивная драма",
						Price = 470.0m
					}
					);
				context.SaveChanges();
			}
		}
	}
}
