using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Taste.Models;
using Microsoft.AspNetCore.Identity;

namespace Taste
{
  class Program
  {
    static void Main(string[] args)
    {
      WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

      builder.Services.AddControllersWithViews();
      // be sure to update the line below for your project
      builder.Services.AddDbContext<TasteContext>(options => options
      .UseMySql(
      builder.Configuration["ConnectionStrings:DefaultConnection"],
      ServerVersion.AutoDetect(builder.Configuration["ConnectionStrings:DefaultConnection"])
)
);
      // Line below adds Identity
      builder.Services.AddIdentity<ApplicationUser, IdentityRole>()
                .AddEntityFrameworkStores<TasteContext>()
                .AddDefaultTokenProviders();

      builder.Services.Configure<IdentityOptions>(options =>
{
  // options.Password.RequireDigit = true;
  // options.Password.RequireLowercase = true;
  // options.Password.RequireNonAlphanumeric = true;
  // options.Password.RequireUppercase = true;
  // options.Password.RequiredLength = 6;
  // options.Password.RequiredUniqueChars = 1;
  options.Password.RequireDigit = false;
  options.Password.RequireLowercase = false;
  options.Password.RequireNonAlphanumeric = false;
  options.Password.RequireUppercase = false;
  options.Password.RequiredLength = 0;
  options.Password.RequiredUniqueChars = 0;
});

      WebApplication app = builder.Build();
      app.UseDeveloperExceptionPage();
      app.UseHttpsRedirection();
      app.UseStaticFiles();
      app.UseRouting();
      // Next two lines below enable authentication and authorization.
      app.UseAuthentication();
      app.UseAuthorization();
      app.MapControllerRoute(
          name: "default",
          pattern: "{controller=Home}/{action=Index}/{id?}"
        );
      app.Run();
    }
  }
}