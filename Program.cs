using L11.Data;
using L11.Models;
using Microsoft.EntityFrameworkCore;

namespace L11
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddSingleton<IDateTime, SystemDateTime>();
            builder.Services.AddControllersWithViews();
            builder.Services.AddDbContext<MvcMovieContext>(options => 
            options.UseSqlServer(builder.Configuration.GetConnectionString("MvcMovieContext")));

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            var scope = app.Services.CreateScope();
            SeedData.Initialize(scope.ServiceProvider);

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            /*app.UseEndpoints(endpoints => {
                endpoints.MapControllers();
            });*/

            app.MapAreaControllerRoute("blog_route", "Blog",
					"Manage/{controller}/{action}/{id?}"
					);
            //Manage/Users/AddUser
            //{ area = Blog, controller = Users, action = AddUser }
			app.MapControllerRoute(
                name: "blog",
                pattern: "blog/{*article}",
                defaults: new { controller = "Blog", action = "Article" }
                );
            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");            


            app.Run();
        }
    }
}