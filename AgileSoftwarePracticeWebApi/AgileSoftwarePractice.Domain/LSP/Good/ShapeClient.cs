namespace AgileSoftwarePractice.Domain.LSP.Good;

public static class ShapeClient
{
    public static List<string> DrawAllShapes(List<Shape> shapes)
    {
        List<string> result = [];
        foreach (var shape in shapes)
        {
            result.Add(shape.Draw());
        }
        return result;
    }
}
