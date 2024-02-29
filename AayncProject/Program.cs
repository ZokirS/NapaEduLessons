// See https://aka.ms/new-console-template for more information
using AayncProject;
using Microsoft.AspNetCore.Mvc;

Console.WriteLine("Hello, World!");
 Method1();
 Method2();

var file = new FileName();
var a = file.MyProperty;
file.Method();
async Task Method1()
{
    await Task.Run(() =>
    {
        for (int i = 0; i < 100; i++)
        {
            Console.WriteLine(" Method 1");
            Task.Delay(1000);
        }
    }
    );
}
[HttpGet]

async Task Method2()
{
    await Task.Run(() =>
    {
        for (int i = 0; i < 25; i++)
        {
            Console.WriteLine(" Method 2");
            Task.Delay(1000);
        }
    }
    );
}