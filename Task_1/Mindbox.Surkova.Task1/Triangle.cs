namespace Mindbox.Surkova.Task1;

public class Triangle : Polygon
{
    public bool IsRightTriangle { get; }

    public Triangle(int a, int b, int c) : base(new[] {a, b, c})
    {
        ValidateSides(a, b, c);
        IsRightTriangle = a * a + b * b == c * c || a * a + c * c == b * b || c * c + b * b == a * a;
    }

    public Triangle(List<int> sides) : base(sides)
    {
        var a = sides[0];
        var b = sides[1];
        var c = sides[2];

        ValidateSides(a, b, c);
        IsRightTriangle = a * a + b * b == c * c || a * a + c * c == b * b || c * c + b * b == a * a;
    }

    public Triangle(int[] sides) : base(sides)
    {
    }

    private void ValidateSides(int a, int b, int c)
    {
        if (a + b < c || b + c < a || a + c < b)
        {
            throw new ArgumentException("Triangle with specified side does not exist");
        }
    }

    public sealed override double GetArea()
    {
        var a = Sides[0];
        var b = Sides[1];
        var c = Sides[2];
        var p = Sides.Sum() / 2;
        return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
    }
}