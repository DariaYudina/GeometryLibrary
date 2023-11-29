using GeometryLibrary.Implementations;

namespace GeometryLibraryTests;

[TestFixture]
public class CircleTests
{
    private Circle _circle;

    [SetUp]
    public void SetUp()
    {
        _circle = new Circle(5);
    }

    [Test]
    public void GetPerimeter_Valid()
    {
        // Act
        double perimeter = _circle.GetPerimeter();

        // Assert
        Assert.AreEqual(2 * Math.PI * 5, perimeter, 0.001);
    }

    [Test]
    public void GetArea_Valid()
    {
        // Act
        double area = _circle.GetArea();

        // Assert
        Assert.AreEqual(Math.PI * Math.Pow(5, 2), area, 0.001);
    }

    [Test]
    public void Constructor_NegativeRadius_ThrowsArgumentException()
    {
        // Act & Assert
        Assert.Throws<AggregateException>(() => new Circle(-5), "radius");
    }
}
