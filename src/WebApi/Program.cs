using System;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using WebApi.DataAccess;
using WebApi.DataAccess.Data;

namespace WebApi;

public class Program
{
    public static void Main(string[] args)
    {
        var host = CreateWebHostBuilder(args).Build();

        using (var scope = host.Services.CreateScope())
        {
            var services = scope.ServiceProvider;
            try
            {
                var context = services.GetRequiredService<ApplicationDbContext>();
                // split initializers into seperate methods in WebApi.DataAccess
                DataSeeder.InitializeRecipes(context);
                DataSeeder.Initialize(context);
            }
            catch (Exception)
            {
                Console.WriteLine("An error occurred while seeding the database.");
            }
        }
        host.Run();
    }

    public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
        WebHost.CreateDefaultBuilder(args)
            .UseStartup<Startup>();
}
