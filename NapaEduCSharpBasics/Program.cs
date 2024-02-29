// See https://aka.ms/new-console-template for more information
using NapaEduCSharpBasics.Classes;
using System.Runtime.CompilerServices;
using static System.Runtime.InteropServices.JavaScript.JSType;

Console.WriteLine("Hello, World!");

var value = "value1";
var valueAll = value.StringMethod("value2", "value3");

var date = DateTime.Now;
date.DatetimeMethod(17);

Console.WriteLine(date);
void PrintMessage(string message) => Console.WriteLine(message);
void SecondMethod(string message) => Console.WriteLine(message);
Action<string> action = PrintMessage;
action += SecondMethod;

action("Hello world 2");

string Square(int number, int number2) =>  $"Square is {number*number2}";

Func<int,int, string> func = Square;
Console.WriteLine(func(4, 6));
Func<int, bool> func2 =  x => true;

Func<int, bool> isEven = x => x % 2 == 0;
void Add(int x, int y) => Console.WriteLine(x + y);
void Multiply(int a, int b) => Console.WriteLine(a * b);

void DoSomeOperation(int a, int b, Action<int,int> op) => op(a, b);

DoSomeOperation(4, 7, Add);
DoSomeOperation(3, 9, Multiply);

Func<int, int> func4 = x=>Math.Abs(x);

Console.WriteLine(func4(-65));

 List<int> SortedByCondition( List<int> list, Func<int, bool> condition)
{
    var newList = new List<int>();
    foreach (int x in list)
    {
        if (condition(x))
        {
            newList.Add(x);
        }
    }
    return newList;
}


var list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

var res = list.SortedByCondition(x => x % 2 == 0);
foreach(long x in res)
    Console.WriteLine(x);