namespace AgileSoftwarePractice.Domain.LSP.Bad;

public class Square : Shape
{
    public Point TopLeft { get; private set; }
    public double Side { get; private set; }
    public Square(ShapeType shapeType ,Point topLeft, double side) : base(shapeType)
    {
        this.TopLeft = topLeft;
        this.Side = side;
    }

    public string Draw()
    {
        return $"TopLeft: {this.TopLeft} Side: {this.Side:F1}";
    }
}
