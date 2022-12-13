namespace Mindbox.Surkova.Task1;

public abstract class RoundShape : IFigure
{
    private double _radius;

    public RoundShape(double radius)
    {
        Radius = radius;
    }
    public double Radius
    {
        get => _radius;
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Radius cannot be less than 0");
            }

            _radius = value;
        }
    }

    public abstract double GetArea();
}