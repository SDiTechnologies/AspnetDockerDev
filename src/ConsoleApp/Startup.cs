using Microsoft.AspNetCore.Builder;
// using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

using Microsoft.EntityFrameworkCore;

using WebApi.Data;
using WebApi.Models;

using ConsoleApp.Fakers;

namespace ConsoleApp;

public class Startup
{
    public IConfiguration Configuration { get; }

    public Startup(IConfiguration configuration)
    {
        Configuration = configuration;
    }

    public void ConfigureServices(IServiceCollection services)
    {
        var connString = Configuration.GetConnectionString("NpgsqlConnection");

        services.AddDbContext<ApplicationDbContext>(opt =>
        {
            opt.UseNpgsql(connString);
        });

        // Controllers, endpoints, Transients, Services, what?

        // Configure your services here
        // services.AddDbContext<>

        // // faker debug code
        // var fake = new LibraryOpFaker();
        // var sumVar = fake.NewAddress();
        // Console.WriteLine(sumVar);
        // Console.WriteLine(sumVar.ToString());
    }

    public void Configure(IApplicationBuilder app, IHostEnvironment env)
    {
        if (env.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();
        }

        app.UseStaticFiles();
        // Console.WriteLine("Yay! you made it!");
    }
}
