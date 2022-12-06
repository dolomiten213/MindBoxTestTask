
using GeometricShapes;

var shapes = new Shape[]
{
    new Circle(2),
    new Triangle(3, 4, 5),
    new Triangle(6, 8, 10),
    new Triangle(324, 324, 600)
};

foreach (var shape in shapes)
{
    Console.WriteLine(shape.CalculateSquare());
}