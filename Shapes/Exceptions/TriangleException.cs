namespace Shapes.Exceptions;

public class TriangleException : ShapeException
{
    public TriangleException(string? message) : base(message)
    {
    }

    public static TriangleException TriangleInequalityNotSatisfied(decimal a, decimal b, decimal c) =>
        new TriangleException($"triangle with sides: {a} {b} {c} can not exist");

    public static ShapeException ValueLessThenZeroException(decimal a, decimal b, decimal c) =>
        new TriangleException($"some of the sides are less or equal to zero: sideA: {a},sideB {b},sideC: {c}");
}