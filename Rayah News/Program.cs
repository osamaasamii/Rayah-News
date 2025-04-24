using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Rayah_News.Data;
using Rayah_News.Models;

namespace Rayah_News
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            // تسجيل Rayah_NewsContext اللي بيستخدمه Identity
            builder.Services.AddDbContext<Rayah_NewsContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("Rayah_NewsContextConnection")));

            // إضافة Identity باستخدام Rayah_NewsContext
            builder.Services.AddDefaultIdentity<IdentityUser>(options =>
                options.SignIn.RequireConfirmedAccount = true)
                .AddEntityFrameworkStores<Rayah_NewsContext>();

            builder.Services.AddDbContext<NewsContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));


            var app = builder.Build();

           

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication(); // مهم
            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
