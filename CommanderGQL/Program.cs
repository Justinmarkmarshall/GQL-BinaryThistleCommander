using CommanderGQL.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

var connectionString = builder.Configuration.GetConnectionString("CommandConStr");
builder.Services.AddDbContext<AppDbContext>(opt => opt.UseSqlServer(connectionString));


app.MapGet("/", () => "Hello World!");

app.Run();
