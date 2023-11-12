using Shapes.Exceptions;

namespace Shapes.Entities;

public class Triangle : IShape
{
    public Triangle(decimal sideA, decimal sideB, decimal sideC)
    {
        if (sideA <= 0 || sideB <= 0 || sideC <= 0)
        {
            throw TriangleException.ValueLessThenZeroException(sideA,sideB, sideC);
        }
        if (!IsInequalitySatisfied(sideA,sideB,sideC))
        {
            throw TriangleException.TriangleInequalityNotSatisfied(sideA, sideB, sideC);
        }

        SideA = sideA;
        SideB = sideB;
        SideC = sideC;
    }

    public decimal SideA { get; set; }
    public decimal SideB { get; set; }
    public decimal SideC { get; set; }

    public bool IsRightAngled => ((SideA * SideA + SideB * SideB == SideC * SideC) ||
                                  (SideA * SideA + SideC * SideC == SideB * SideB) ||
                                  (SideC * SideC + SideB * SideB == SideA * SideA));


    public decimal Perimeter => CountPerimeter();

    public decimal CountSquare()
    {
        return (decimal)Math.Sqrt((double)(Perimeter / 2 * (Perimeter / 2 - SideA) * (Perimeter / 2 - SideB) *
                                           (Perimeter / 2 - SideC)));
    }

    public decimal CountPerimeter()
    {
        return SideA + SideB + SideC;
    }

    private bool IsInequalitySatisfied(decimal sideA, decimal sideB, decimal sideC)
    {
        if (sideA < sideB + sideC)
            if (sideB < sideA + sideC)
                if (sideC < sideA + sideB)
                    return true;
        return false;
                
    }

    public override string ToString()
    {
        return $"{nameof(SideA)}: {SideA}, {nameof(SideB)}: {SideB}, {nameof(SideC)}: {SideC}, {nameof(IsRightAngled)}: {IsRightAngled}, {nameof(Perimeter)}: {Perimeter}, Square: {CountSquare()}";
    }
}