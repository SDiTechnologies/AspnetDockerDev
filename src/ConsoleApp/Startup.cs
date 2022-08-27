using Microsoft.AspNetCore.Builder;
// using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

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
        // Configure your services here
        // services.AddDbContext<>
        // var testFake = new OperationFaker();
        // var sumVar = OperationFaker.NewOperation();
        // Console.WriteLine(sumVar);
        // Console.WriteLine(sumVar.ToString());

        var af = new AttributeFaker();
        var sumVar = af.NewAddress();
        Console.WriteLine(sumVar);
        Console.WriteLine(sumVar.ToString());
    }

    public void Configure(IApplicationBuilder app, IHostEnvironment env)
    {
        if (env.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();
        }

        app.UseStaticFiles();
        Console.WriteLine("Yay! you made it!");
    }
}
