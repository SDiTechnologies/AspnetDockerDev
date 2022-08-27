// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;


namespace ConsoleApp;

public class Program
{
    public static async Task Main(string[] args)
    {
        // CreateHostBuilder(args).Build().Run();
        var host = CreateHostBuilder(args).Build();
        await host.RunAsync();
    }

    public static IHostBuilder CreateHostBuilder(string[] args) =>
        Host.CreateDefaultBuilder(args)
            .ConfigureLogging(logging => logging.ClearProviders())
            .ConfigureWebHostDefaults(builder =>
            {
                builder.UseStartup<Startup>();
            });
            // .UseStartup<Startup>();


    // public static IHostBuilder CreateHostBuilder(string[] args) =>
    //     Host.CreateDefaultBuilder(args)
    //         .ConfigureLogging(logging => logging.ClearProviders())
    //         .ConfigureWebHostDefaults(webBuilder =>
    //         {
    //             webBuilder.UseNLogWeb();
    //             webBuilder.UseStartup<Startup>();
    //         });
}
