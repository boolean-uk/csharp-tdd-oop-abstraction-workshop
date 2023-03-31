using Boolean.CSharp.Main;
using System.Drawing;

Circle c = new Circle(5.0);
Console.ForegroundColor = c.cc;
Console.WriteLine("Area of Circle = {0}", c.area());
Square s = new Square(2.5);
Console.WriteLine("Area of Square = {0}", s.area());
Triangle t = new Triangle(2.0, 5.0);
Console.WriteLine("Area of Triangle = {0}", t.area());
Console.ForegroundColor = ConsoleColor.White;


Console.ReadLine();
