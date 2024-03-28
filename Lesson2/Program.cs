using Lesson2.Context;
using Lesson2.Models;
using System.Text.Json;


var student = new Student
{
    Name = "Hojiakbar",
    BirtDate = DateTime.Now,
};

var jsonString = JsonSerializer.Serialize(student);
Console.WriteLine(jsonString);


var obj = JsonSerializer.Deserialize<Rootobject>(jsonString, new JsonSerializerOptions { });

Console.WriteLine();


public class Rootobject
{
    public int Id { get; set; }
    public string Name { get; set; }
    public DateTime BirtDate { get; set; }
}
