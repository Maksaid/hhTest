namespace Shapes;

public class Triangle : IShape
{
    public Triangle(decimal sideA, decimal sideB, decimal sideC)
    {
        if (sideA < sideB + sideC)
        {
            if (sideB < sideA + sideC)
                if (sideC < sideA + sideB)
                {
                    SideA = sideA;
                    SideB = sideB;
                    SideC = sideC;
                }
        }
        else
                    throw new Exception("TRIANGLE CANNOT EXIST");
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
}