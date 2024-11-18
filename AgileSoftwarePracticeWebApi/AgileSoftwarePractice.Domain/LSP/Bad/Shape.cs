namespace AgileSoftwarePractice.Domain.LSP.Bad;

public abstract class Shape
{
    public ShapeType ShapeType { get; }
    public Shape(ShapeType shapeType)
    {
        this.ShapeType = shapeType;
    }
}
