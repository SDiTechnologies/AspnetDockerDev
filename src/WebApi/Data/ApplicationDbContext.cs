using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;
using WebApi.Models;

namespace WebApi.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions options)
        : base(options)
    {

    }

    public DbSet<TodoItem> TodoItems { get; set; } = null!;
}
