namespace Mindbox.Surkova.Task1.Tests;

public class Tests
{

    [Test]
    public void TestCircleSquare()
    {
        var circle = new Circle(5);
        var circleSquare = circle.GetArea();
        Assert.That(circleSquare, Is.EqualTo(78.53981633974483));
    }
    
    [Test]
    public void TestRigntTriangleTrue()
    {
        var triangle = new Triangle(3, 4, 5);
        Assert.True(triangle.IsRightTriangle);
    }
    
    [Test]
    public void TestTriangleSquare()
    {
        var triangle = new Triangle(4, 6, 6);
        var triangleSquare = triangle.GetArea();
        Assert.That(triangleSquare, Is.EqualTo(11.313708498984761));
    }
    
    [Test]
    public void TestCircleNegativeRadius()
    {
        Assert.Throws<ArgumentException>(() =>
        {
            var circle = new Circle(-20);
        });
    }
    
    [Test]
    public void TestTriangleNegativeSide()
    {
        Assert.Throws<ArgumentException>(() =>
        {
            var triangle = new Triangle(-3, 9, 3);
        });
    }
}