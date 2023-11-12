using Shapes;
using Shapes.Entities;
using Shapes.Exceptions;
using Xunit;

namespace TestProject1;

public class UnitTest1
{
    [Theory]
    [InlineData(3, 4, 5, true)]
    [InlineData(3, 5, 6, false)]
    [InlineData(12, 5, 13, true)]
    public void IsRightAngledTest(decimal a, decimal b, decimal c, bool expected)
    {
        var triangle = new Triangle(a, b, c);
        Assert.Equal(expected, triangle.IsRightAngled);
    }

    [Theory]
    [InlineData(12, 5, 13, 30)]
    [InlineData(3, 4, 5, 6)]
    public void TriangleSquareTest(decimal a, decimal b, decimal c, decimal expected)
    {
        var triangle = new Triangle(a, b, c);
        Assert.Equal(expected, triangle.CountSquare());

    }

    [Theory]
    [InlineData(3, 28.27)]
    public void CircleSquareTest(decimal radius, decimal expected)
    {
        var circ = new Circle(radius);
        Assert.Equal(expected, Math.Round(circ.CountSquare(), 2));
    }

    [Theory]
    [InlineData(-3, 2, 5)]
    [InlineData(2, 3, 5)]
    public void TriangleExceptionThrowing(decimal a, decimal b, decimal c)
    {
        Assert.Throws<TriangleException>(() => new Triangle(a, b, c));
    }

    [Theory]
    [InlineData(-3)]
    [InlineData(0)]
    public void CircleExceptionThrowing(decimal radius)
    {
        Assert.Throws<CircleException>(() => new Circle(radius));
    }
}