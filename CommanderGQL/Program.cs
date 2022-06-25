using CommanderGQL.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("CommandConStr");
builder.Services.AddDbContext<AppDbContext>(opt => opt.UseSqlServer(connectionString))
.AddScoped<DbContext, AppDbContext>();
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();
