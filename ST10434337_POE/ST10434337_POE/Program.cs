using Microsoft.EntityFrameworkCore;
using ST10434337_POE.Data;
using ST10434337_POE.Models.DomainModels;
using ST10434337_POE.Services;

namespace ST10434337_POE
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            // Add services to the container.
            builder.Services.AddControllersWithViews();

            // In Memory EF Core DB (Temporary Storage)
            builder.Services.AddDbContext<AppDbContext>(options => options.UseInMemoryDatabase("POE_DB"));


            
            //PasswordHelper BCrypt all in 1 place
            builder.Services.AddScoped<PasswordHelper>();


            // Enable session
            builder.Services.AddSession(options =>
            {
                options.IdleTimeout = TimeSpan.FromMinutes(30);
                options.Cookie.HttpOnly = true;
                options.Cookie.IsEssential = true;
            });

            builder.Services.AddHttpContextAccessor();

            var app = builder.Build();

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
            app.UseSession();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Account}/{action=Login}/{id?}");// Start on Login page

            app.Run();
        }
    }
}
