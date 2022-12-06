namespace GeometricShapes.Tests;

public class CircleTests
{
    [Theory]
    [InlineData(1, 3.14, 2)]
    [InlineData(2.4324, 18.5875, 4)]
    [InlineData(3, 28.2743, 4)]
    [InlineData(10000, 314159265.359, 4)]
    public void BaseTests(double radius, double result, int precision)
    {
        var sut = new Circle(radius);
        Assert.Equal(result, sut.CalculateSquare(), precision);
    }
    
    [Theory]
    [InlineData(0)]
    [InlineData(-12)]
    [InlineData(-1.12334234)]
    public void ThrowArgumentExceptionIfRadiusLessOrEqualsToZero(double radius)
    {
        Assert.Throws<ArgumentException>(() => new Circle(radius));
    }
}