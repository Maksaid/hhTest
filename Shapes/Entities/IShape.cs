namespace Shapes.Entities;

public interface IShape
{
    public decimal Perimeter => CountPerimeter();
    public decimal CountSquare();
    public decimal CountPerimeter();
}