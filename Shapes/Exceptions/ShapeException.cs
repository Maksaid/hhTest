namespace Shapes.Exceptions;

public class ShapeException : Exception
{
    public ShapeException(string? message) : base(message)
    {
    }

    public static ShapeException ValueLessThenZeroException(decimal value) =>
        new ShapeException($"value {value} must be positive");
}