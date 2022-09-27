using System;
namespace HelloWorld;

public class AbstractMain
{
    public static void Main(string[] args)
    {
        AreaClass square = new Square(5);
        AreaClass circle = new Circle(5.7);
        Console.WriteLine(circle.calculateArea());
        Console.Write(square.calculateArea());
    }
}

