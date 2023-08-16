
using Shapes;

Circle circle = new Circle(10);
Console.WriteLine(circle.CountSquare());

IShape triangle = new Triangle(4,5,7);
Console.WriteLine(triangle.Perimeter);
Console.WriteLine(triangle.CountSquare());

