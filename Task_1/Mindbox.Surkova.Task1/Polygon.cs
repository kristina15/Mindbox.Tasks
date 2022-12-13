namespace Mindbox.Surkova.Task1;

public abstract class Polygon : IFigure
{
    public IList<int> Sides { get; }
    
    public Polygon(IList<int> sides)
    {
        ValidateSides(sides);
        if (sides.Count < 3)
        {
            throw new ArgumentException("There must be more than 3 sides");
        }
        
        Sides = sides;
    }
    
    public Polygon(int[] sides)
    {
        ValidateSides(sides);
        if (sides.Length < 3)
        {
            throw new ArgumentException("There must be more than 3 sides");
        }
        
        Sides = sides;
    }
    
    public abstract double GetArea();
    
    private void ValidateSides(IList<int> sides)
    {
        if (sides.Any(x => x <= 0))
        {
            throw new ArgumentException("Lenght of side cannot be less than 0");
        }
    }
}