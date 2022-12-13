namespace Mindbox.Surkova.Task1;

public class Circle : RoundShape
{
    public Circle(double radius) : base(radius)
    {
    }
    
    public sealed override double GetArea() => Math.PI * Radius * Radius;
}