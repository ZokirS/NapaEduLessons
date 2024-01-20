// See https://aka.ms/new-console-template for more information
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using NapaEduLessons1.Context;
using NapaEduLessons1.Models;

Console.WriteLine("Hello, World!");

var services = new ServiceCollection();
var context = new MyAppDbContext();
services.AddDbContext<MyAppDbContext>(options =>
options.UseSqlServer("server=(localhost); database=sampleDB; Integrated Security=true"));

var student = new Student
{
    FirstName = "Test",
    LastName = "Test",
    BirthDate = DateTime.Now,
    Address = "asda"
};


