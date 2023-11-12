
using Shapes.Exceptions;

namespace Shapes.Entities;

public class Circle : IShape
{
    public Circle(decimal radius)
    {
        if (radius <= 0)
        {
            throw CircleException.ValueLessThenZeroException(radius);
        }
        Radius = radius;
    }

    public decimal Radius { get; set; }

    public decimal Perimeter { get; set; }

    public decimal CountSquare()
    {
        return Radius * Radius * (decimal)Math.PI;
    }

    public decimal CountPerimeter()
    {
        return 2 * Radius * (decimal)Math.PI;
    }

    public override string ToString()
    {
        return $"{nameof(Radius)}: {Radius}, {nameof(Perimeter)}: {Perimeter}, Square: {CountSquare()}";
    }
}