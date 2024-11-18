namespace AgileSoftwarePractice.Domain.LSP.Bad
{
    public static class ShapeClient
    {
        public static List<string> DrawAllShapes(List<Shape> shapes)
        {
            List<string> result = [];
            foreach (var shape in shapes)
            {
                switch (shape.ShapeType)
                {
                    case ShapeType.Square:
                        var square = shape as Square;
                        result.Add(square!.Draw());
                        break;
                    case ShapeType.Circle:
                        var circle = shape as Circle;
                        result.Add(circle!.Draw());
                        break;
                    default:
                        throw new ArgumentException(nameof(shape));
                }
            }
            return result;
        }
    }
}
