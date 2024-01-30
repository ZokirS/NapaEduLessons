// See https://aka.ms/new-console-template for more information
using Microsoft.EntityFrameworkCore;
using NapaEduLessons1.Context;
using NapaEduLessons1.Models;

var context = new MyAppDbContext();

var students = new List<Student>();
var student = new Student
{
    FirstName = "default",
    LastName = "default",
    BirthDate = DateTime.Now.AddDays(- 1)
};

for (int i = 0; i < 10; i++)
{
    students.Add(new Student
    {
        FirstName = $"Test17877{i + 1}",
        LastName = $"Test1{i + 1}",
        BirthDate = DateTime.Now.AddDays(-(i + 1))
    });
}

var people = context.Person.SelectMany(x => context.Vehicle, (p, v) =>
new
{
    OwnerName = p.Name,
    CarName = $"{v.BrandName} - {v.Model}"
});
foreach (var person in people)
{
   // Console.WriteLine($"Owner: {person.OwnerName} with car {person.CarName}");
}

var studentss = context.Course.Include(x => x.Students).ToList();
foreach (var item in studentss)
{
    Console.WriteLine($"Course: {item.CourseName} with students:");
    foreach(var row  in item.Students)
    {
        Console.WriteLine($" - {row.FirstName} {row.LastName}");
    }
}
/*var students2 = context.Students.FirstOrDefault(x=>x.FirstName == "default");
if(students2 != null)
{
    context.Students.Remove(students2);
    context.SaveChanges();
}
//context.Students.Update(student);
var allStudents = context.Students.Where(x=>x.StudentID == 40);

//context.Students.AddRange(students);
//context.SaveChanges();
foreach (var item in allStudents)
{
    Console.WriteLine($"FirstName: {item.FirstName} LastName: {item.LastName}");
}
Console.WriteLine(allStudents.ToQueryString());
*/