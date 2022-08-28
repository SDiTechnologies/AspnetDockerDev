// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using System.Linq;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

using WebApi.Data;


namespace ConsoleApp;

// // Async style app
// public class Program
// {
//     public static async Task Main(string[] args)
//     {
//         // CreateHostBuilder(args).Build().Run();
//         var host = CreateHostBuilder(args).Build();
//         await host.RunAsync();
//     }

//     public static IHostBuilder CreateHostBuilder(string[] args) =>
//         Host.CreateDefaultBuilder(args)
//             .ConfigureLogging(logging => logging.ClearProviders())
//             .ConfigureWebHostDefaults(builder =>
//             {
//                 builder.UseStartup<Startup>();
//             });
//             // .UseStartup<Startup>();


//     // public static IHostBuilder CreateHostBuilder(string[] args) =>
//     //     Host.CreateDefaultBuilder(args)
//     //         .ConfigureLogging(logging => logging.ClearProviders())
//     //         .ConfigureWebHostDefaults(webBuilder =>
//     //         {
//     //             webBuilder.UseNLogWeb();
//     //             webBuilder.UseStartup<Startup>();
//     //         });
// }



// // debug sync below
// public class Program
// {
//     static void Main(string[] args)
//     {
//         PerformDatabaseOperations();
//     }

//     public static void PerformDatabaseOperations()
//     {
//         using (var db = new ApplicationDbContext())
//         {
//             db.Operations.Add(new Operation
//             {
//                 name = "test op",
//                 alias = "test op alias"
//             });

//             db.SaveChanges();

//             var ops = (from o in db.Operations
//                        orderby o.OperationName
//                        select o).ToList();
//             foreach (var e in ops)
//             {
//                 Console.WriteLine($"{e.OperationName}");
//             }
//         }
//     }
// }
