// using Microsoft.EntityFrameworkCore;
// using System.Diagnostics.CodeAnalysis;
// using WebApi.Models;

// namespace WebApi.Data;

// public class ApplicationDbContext : DbContext
// {
//     public ApplicationDbContext(DbContextOptions options)
//         : base(options)
//     {

//     }

//     // base example provided by the lovely folks at Microsoft
//     public DbSet<TodoItem> TodoItems { get; set; } = null!;

//     // Library Locations Example
//     public DbSet<Operation> Operations { get; set; }
//     public DbSet<Location> Locations { get; set; }
//     public DbSet<Book> Books { get; set; }
//     public DbSet<Author> Authors { get; set; }
//     public DbSet<Publisher> Publishers { get; set; }
//     public DbSet<Genre> Genres { get; set; }

//     public DbSet<Address> Addresses { get; set; }


//     // public void Seed(ApplicationDbContext context)
//     // {

//     // }
// }
