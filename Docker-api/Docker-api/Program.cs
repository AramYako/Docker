using Microsoft.Extensions.Options;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.



builder.Services.AddControllers();


//Goal connect to redis   (Done)
//Make sure it works      (Done)
//Add connection to       (Done)
//dev app settings        (Done)
//Staging  app settings   (Done)
//Prod app settings       (Done)
//composite settings with override (Done)
//Verify dev container doesnt use compsite  (Done)
//Up composite and test it  (Done)
//Up composite and then debug dev container


builder.Services.AddStackExchangeRedisCache(options =>
{
    string server = builder.Configuration["redis:server"] ?? throw new Exception("Startup fail");

    string port = builder.Configuration["redis:port"] ?? throw new Exception("Startup fail2");

    string cnstring = $"{server}:{port}";

    options.Configuration = cnstring;
});


var app = builder.Build();



// Configure the HTTP request pipeline.

app.UseAuthorization();

app.MapControllers();

app.Run();
