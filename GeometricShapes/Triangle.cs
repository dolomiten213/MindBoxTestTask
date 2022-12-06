namespace GeometricShapes;

public class Triangle : Shape
{
    public bool IsRight { get; }
    
    public double A { get; }
    public double B { get; }
    public double C { get; }

    public Triangle(double side1, double side2, double side3)
    {
        if (side1 <= 0 || side2 <= 0 || side3 <= 0) throw new ArgumentException("All arguments must be greater than zero");
        var maxSide = Math.Max(Math.Max(side1, side2), side3);
        const double tolerance = 0.000001;
        var (leg1, leg2) = Math.Abs(maxSide - side1) < tolerance
            ? (side2, side3)
            : Math.Abs(maxSide - side2) < tolerance
                ? (side1, side3)
                : (side1, side2);

        IsRight = Math.Abs(leg1 * leg1 + leg2 * leg2 - maxSide * maxSide) < tolerance;
        (A, B, C) = (leg1, leg2, maxSide);
    }
    
    public override double CalculateSquare()
    {
        if (IsRight) return A * B / 2;
        
        var p = (A + B + C) / 2;
        return Math.Sqrt(p*(p - A) * (p - B) * (p - C));
    }
}