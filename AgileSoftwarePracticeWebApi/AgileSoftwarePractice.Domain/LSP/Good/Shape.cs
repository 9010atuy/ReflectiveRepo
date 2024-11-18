namespace AgileSoftwarePractice.Domain.LSP.Good;

public abstract class Shape
{
    public ShapeType ShapeType { get; }
    public Shape(ShapeType shapeType)
    {
        this.ShapeType = shapeType;
    }
    public abstract string Draw();
}
