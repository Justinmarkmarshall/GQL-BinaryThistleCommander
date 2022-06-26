using CommanderGQL.Data;
using CommanderGQL.GraphQL;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("CommandConStr");
builder.Services.AddDbContext<AppDbContext>(opt => opt.UseSqlServer(connectionString))
.AddScoped<DbContext, AppDbContext>()
.AddGraphQLServer()
.AddQueryType<Query>();
var app = builder.Build();

app.UseRouting();
app.UseEndpoints(endpoints => {
    endpoints.MapGraphQL();
});

app.Run();
