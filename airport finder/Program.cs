using airport_finder.Models;
using airport_finder.Repository;
using airport_finder.Services.Implementation;
using airport_finder.Services;
using airport_finder;
using Microsoft.EntityFrameworkCore;

namespace airport_finder
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();
            var cons = builder.Configuration.GetSection("ConnectionStrings:DefaultConnection").Value;
            builder.Services.AddDbContext<DatabaseContext>(x => x.UseSqlServer(cons));

            builder.Services.AddTransient<IRepository<AirportInfo>, Repository<AirportInfo>>();
            builder.Services.AddTransient<IRepository<CityInfo>, Repository<CityInfo>>();
            builder.Services.AddTransient<IRepository<FeedBack>, Repository<FeedBack>>();
            builder.Services.AddTransient<IRepository<StateImg>, Repository<StateImg>>();


            builder.Services.AddTransient<IAirportService, AirportServices>();
            builder.Services.AddTransient<ICityService, CityService>();
            builder.Services.AddTransient<IStateService, StateService>();
            builder.Services.AddTransient<IFeedBackService, FeedBackService>();
            builder.Services.AddTransient<IDistMethods, DistMethods>();


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
                pattern: "{controller=Airport}/{action=Index}/{id?}");

            app.Run();
        }
    }
}