using Docker_api.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.



builder.Services.AddControllers();

builder.Services.AddDbContext<ColourContext>(options =>
options.UseSqlServer($"Server={builder.Configuration["DBServer"]?? "localhost"},{builder.Configuration["DBPort"] ?? "1443"}; Initial Catalog={builder.Configuration["Database"] ?? "Colours"}; User ID = {builder.Configuration["DBUser"]?? "SA"};Password={builder.Configuration["DBPassword"] ?? "Pa$$word2022"}"));


var app = builder.Build();

var server = app.Configuration.GetValue<string>("DBServer") ?? "localhost";
var port = app.Configuration.GetValue<string>("DBPort") ?? "1443";
var user = app.Configuration.GetValue<string>("DBUser") ?? "SA";
var password = app.Configuration.GetValue<string>("DBPassword") ?? "Pa$$word2022";



// Configure the HTTP request pipeline.

app.UseAuthorization();

app.MapControllers();

app.Run();
