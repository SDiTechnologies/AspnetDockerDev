using Microsoft.EntityFrameworkCore;
using WebApi.Models;
using WebApi.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

// // use in-memory db
// builder.Services.AddDbContext<ApplicationDbContext>(opt =>
//     opt.UseInMemoryDatabase("TodoList"));

// // use sqlite
// var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
// builder.Services.AddDbContext<ApplicationDbContext>(options =>
//     options.UseSqlite(connectionString));

// use a proper database connection...
// use postgres
var connectionString = builder.Configuration.GetConnectionString("NpgsqlConnection");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseNpgsql(connectionString));

// // use mssqlserver
// var connectionString = builder.Configuration.GetConnectionString("MssqlConnection");
// builder.Services.AddDbContext<ApplicationDbContext>(options =>
//     options.UseSqlServer(connectionString));

builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
    app.UseSwagger();
    app.UseSwaggerUI();
}

// app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
