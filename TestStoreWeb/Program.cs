using Microsoft.EntityFrameworkCore;
using TestStoreWeb.Data;
using TestStoreWeb.Repository;
using TestStoreWeb.Repository.IRepository;

namespace TestStoreWeb
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();
            builder.Services.AddDbContext<ApplicationDBContext>(options =>
            options.UseSqlServer(builder.Configuration.GetConnectionString("DefualtConnection")));
            
            
            builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();



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

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{area=Guest}/{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
