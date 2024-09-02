using Microsoft.EntityFrameworkCore;
using L11.Models;

namespace L11.Data
{
	public class MvcMovieContext : DbContext
	{
		public MvcMovieContext(DbContextOptions<MvcMovieContext> options) : base(options)
		{
		}

		public DbSet<Movie> Movie { get; set; }
	}
}
