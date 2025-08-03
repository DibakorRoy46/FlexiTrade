using FlexiTrade.Infrastructure;
using FlexiTrade.Core;
using FlexiTrade.API.Middleware;

var builder = WebApplication.CreateBuilder(args);

//Add services to the container.
builder.Services.AddInfrastructure();
builder.Services.AddCore();

// Add controllers
builder.Services.AddControllers();

var app = builder.Build();

//Exception handling middleware
app.UseExcelptionHandlingMiddleware();

//Routing
app.UseRouting();

//Auth
app.UseAuthentication();
app.UseAuthorization();

//Map controllers
app.MapControllers();

app.Run();




