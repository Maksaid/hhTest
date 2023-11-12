namespace Shapes.Exceptions;

public class CircleException : ShapeException
{
    public CircleException(string? message) : base(message)
    {
    }

    public new static ShapeException ValueLessThenZeroException(decimal radius) =>
        new CircleException($"radius must be greater then zero, provided: {radius}");

}