using System.Drawing;

namespace AgileSoftwarePractice.Domain.LSP.Bad;

public class Circle : Shape
{
    public Point Center { get; }
    public double Radius { get; }
    public Circle(ShapeType shapeType, Point center, double radius) : base(shapeType)
    {
        this.Center = center;
        this.Radius = radius;
    }
    public string Draw()
    {
        return $"Center: {this.Center} Radius: {this.Radius:F1}";
    }
}
