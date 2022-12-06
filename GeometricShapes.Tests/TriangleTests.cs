namespace GeometricShapes.Tests;

public class TriangleTests
{
    [Theory]
    [InlineData(3, 4, 5, 6, 0)]
    [InlineData(4, 3, 5, 6, 0)]
    [InlineData(5, 4, 3, 6, 0)]
    [InlineData(6, 8, 10, 24, 0)]
    [InlineData(20.32, 23.4, 28.143, 233.9852, 4)]
    [InlineData(28.143, 23.4, 20.32, 233.9852, 4)]
    public void RightTriangleTests(double a, double b, double c, double result, int precision)
    {
        var sut = new Triangle(a,b,c);
        Assert.Equal(result, sut.CalculateSquare(), precision);
    }
    
    [Theory]
    [InlineData(1, 4, -5)]
    [InlineData(-6, 8, 10)]
    [InlineData(0, 8, 10)]
    [InlineData(6, -8, 10)]
    public void ThrowArgumentExceptionIfRadiusLessOrEqualsToZero(double a, double b, double c)
    {
        Assert.Throws<ArgumentException>(() => new Triangle(a,b,c));
    }
}