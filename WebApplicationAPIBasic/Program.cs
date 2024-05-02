using Microsoft.EntityFrameworkCore;
using WebApplicationAPIBasic.Context;
using WebApplicationAPIBasic.Services;
using WebApplicationAPIBasic.Services.Interfaces;

var builder = WebApplication.CreateBuilder(args);
var connString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddScoped<IStudentService, StudentService>();
builder.Services.AddDbContext<AppDbContext>(context =>
{
    context.UseSqlServer(connString);
});
var app = builder.Build();

app.UseHttpsRedirection();
app.MapControllers();

//app.MapGet("/get", () =>
//{
//    return Results.Ok("Hello 200");
//});
//app.Use(async (context, next) =>
//{
//    await context.Response.WriteAsync("\nBefore Request Use method");
//    await next();
//    await context.Response.WriteAsync("\nAfter Request Use method");

//});
//app.Run(async (context) =>
//{
//    await context.Response.WriteAsync("\nHello world");
//});

//app.Run(async (context) =>
//{
//    await context.Response.WriteAsync("Hello world2");
//});


app.Run();