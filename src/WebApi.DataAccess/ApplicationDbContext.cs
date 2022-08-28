// public class ApplicationDbContext : DbContext
// {
//    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

//    public virtual DbSet<User> Users { get; set; }
//    public virtual DbSet<Recipe> Recipes { get; set; }
//    public virtual DbSet<Ingredient> Ingredients { get; set; }
// }

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using WebApi.Domain.Models;
using System.IO;

namespace WebApi.DataAccess
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Recipe> Recipes { get; set; }
        public virtual DbSet<Ingredient> Ingredients { get; set; }

        // Public Library Organizations objects
        public virtual DbSet<Book> Books { get; set; }
        public virtual DbSet<Author> Authors { get; set; }

        public virtual DbSet<Address> Addresses { get; set; }
    }

    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<ApplicationDbContext>
    {
        public ApplicationDbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile(@Directory.GetCurrentDirectory() + "/../WebApi/appsettings.json")
                .Build();
            var builder = new DbContextOptionsBuilder<ApplicationDbContext>();

            // mssql
            var connectionString = configuration.GetConnectionString("MssqlConnection");
            builder.UseSqlServer(connectionString);

            // // pgsql
            // var connectionString = configuration.GetConnectionString("NpgsqlConnection");
            // builder.UseNpgsql(connectionString);

            return new ApplicationDbContext(builder.Options);
        }
    }
}
