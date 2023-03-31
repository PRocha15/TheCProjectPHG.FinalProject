
using TheCProject.Database.Context;
using Microsoft.EntityFrameworkCore;
using TheCProject.Dal.Interfaces;
using TheCProject.Dal.Implementations;
using TheCProject.Database.Seeds;

namespace TheCProject
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            Microsoft.Extensions.Configuration.ConfigurationManager configuration = builder.Configuration;
            // Add services to the container.
            builder.Services.AddControllersWithViews();

            builder.Services.AddDbContext<TheCProjectDbContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("MainConnectionString"), op =>
                op.CommandTimeout(Convert.ToInt32(configuration.GetSection("SqlTimeout").Value)));

            });


            //Add services
            builder.Services.AddScoped<ICakeRepository, CakeRepository>();
            builder.Services.AddScoped<IDecorationRepository, DecorationRepository>();
            builder.Services.AddScoped<IFillingRepository, FillingRepository>();
            builder.Services.AddScoped<IIngredientRepository, IngredientRepository>();
            builder.Services.AddScoped<IToppingRepository, ToppingRepository>();
            builder.Services.AddScoped<IWeightRepository, WeightRepository>();



            //ADD session
            builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            builder.Services.AddDistributedMemoryCache();
            builder.Services.AddSession(options =>
            {
                options.IdleTimeout = TimeSpan.FromMinutes(10);
            });

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseSession();
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");


            SeedDecoration.PopulateDecorations(app);
            SeedFilling.PopulateFillings(app);
            SeedIngredient.PopulateIngredients(app);
            SeedTopping.PopulateToppings(app);
            SeedWeight.PopulateWeights(app);
            SeedCake.PopulateCakes(app);

            app.Run();
        }
    }
}