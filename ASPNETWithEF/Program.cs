using ASPNETWithEF.Context;
using ASPNETWithEF.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
var connString = builder.Configuration.GetConnectionString("DefaultConnection");
var context = new StudentDbContext();
//builder.Services.AddDbContext<StudentDbContext>(student =>
//{
//    student.UseSqlServer(connString);
//});
var app = builder.Build();


//Get exist student list
app.MapGet("/students", () =>
{
    var students = context.Students;
    return Results.Ok(students);
});

//Add new student
app.MapPost("/addStudent", ([FromBody] Student student) =>
{
    context.Students.Add(student);
    context.SaveChanges();
    return Results.Ok(student);
});

//Update existing student or throw error
app.MapPut("/updateStudent", ([FromQuery] int id, [FromBody] Student student) =>
{
    var st = context.Students.Find(id);
    if (st != null)
    {
        st.FirstName = student.FirstName;
        st.LastName = student.LastName;
        st.BirthDate = student.BirthDate;
        context.Students.Update(st);
        context.SaveChanges();
        return Results.Ok(st);
    }
    else
    {
        return Results.BadRequest(student);
    }

});

app.MapDelete("/deleteStudent", ([FromQuery] int id) =>
{
    var student = context.Students.Find(id);
    if (student != null)
    {
        context.Remove(student);
        context.SaveChanges();
        return Results.Ok();
    }
    else
    {
        return Results.BadRequest(id);
    }
});

app.Run();
