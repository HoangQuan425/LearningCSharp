using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.EntityFrameworkCore;
using MyWebsite.Application.AutoMapper;
using MyWebsite.Application.Implementation;
using MyWebsite.Application.Interfaces.ProductCategory;
using MyWebsite.Data.EF;
using MyWebsite.Data.EF.Repositories;
using MyWebsite.Data.Entities;
using MyWebsite.Data.IRepositories;
using MyWebsite.Infrastructure.Interfaces;
namespace MyProject.Web
{
	public class Program
	{
		public static void Main(string[] args)
		{
			var builder = WebApplication.CreateBuilder(args);
			//add auto mapper
			builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());


			// Add services to the container.
			builder.Services.AddControllersWithViews();
			//configuration database
			builder.Services.AddDbContext<AppDbContext>(options =>
			options.UseSqlServer(builder.Configuration.GetConnectionString("Default"), o => o.MigrationsAssembly("MyWebsite.Data.EF")));
			//add identity
			builder.Services.AddIdentity<AppUser, AppRole>(options =>
			{
				// Password settings
				options.Password.RequireDigit = true;
				options.Password.RequiredLength = 6;
				options.Password.RequireNonAlphanumeric = false;
				options.Password.RequireUppercase = false;
				options.Password.RequireLowercase = false;

				// Lockout settings
				options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(30);
				options.Lockout.MaxFailedAccessAttempts = 10;

				// User settings
				options.User.RequireUniqueEmail = true;
			}).AddEntityFrameworkStores<AppDbContext>()
			.AddDefaultTokenProviders();

			// Add application services
			builder.Services.AddScoped<UserManager<AppUser>, UserManager<AppUser>>();
			builder.Services.AddScoped<RoleManager<AppRole>, RoleManager<AppRole>>();
			builder.Services.AddTransient<DbInitializer>();
			builder.Services.AddTransient<IProductCategoryRepository, ProductCategoryRepository>();


			var app = builder.Build();

			//seed data
			using (var scope = app.Services.CreateScope())
			{
				var services = scope.ServiceProvider;
				try
				{
					var dbInitializer = services.GetRequiredService<DbInitializer>();
					dbInitializer.Seed().Wait();
				}
				catch (Exception ex)
				{
					var logger = services.GetRequiredService<ILogger<Program>>();
					logger.LogError(ex, "An error occurred while seeding the database.");
				}
			}

			// Configure the HTTP request pipeline.
			if (!app.Environment.IsDevelopment())
			{
				app.UseExceptionHandler("/Home/Error");
				// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
				app.UseHsts();
			}

			app.UseHttpsRedirection();
			app.UseStaticFiles();

			app.UseRouting();

			app.UseAuthorization();
			
			//admin route
			app.MapControllerRoute(
			name: "areas",
			pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");
			
			//default route
			app.MapControllerRoute(
					name: "default",
					pattern: "{controller=Home}/{action=Index}/{id?}");

			app.Run();
		}
	}
}
