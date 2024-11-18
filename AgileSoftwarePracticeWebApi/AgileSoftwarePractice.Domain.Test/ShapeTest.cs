using AgileSoftwarePractice.Domain.LSP.Bad;
using System.Text;

namespace AgileSoftwarePractice.Domain.Test;

public class ShapeTest
{
    [Fact]
    public void TestBadShape()
    {
        StringBuilder expected = new();
        expected.AppendLine("Center: Point [X: 1 Y: 1] Radius: 3.0");
        expected.AppendLine("TopLeft: Point [X: 1 Y: 1] Side: 3.0");
        expected.Append("Center: Point [X: 1 Y: 1] Radius: 3.0");
        List<Shape> input = new()
        {
            new Circle(ShapeType.Circle, new Point{X = 1, Y = 1}, 3.0),
            new Square(ShapeType.Square, new Point{X = 1, Y = 1}, 3.0),
            new Circle(ShapeType.Circle, new Point{X = 1, Y = 1}, 3.0),
        };
        List<string> result = ShapeClient.DrawAllShapes(input);
        var act = string.Join("\r\n", result);
        Assert.Equal(expected.ToString(), act);
    }

    [Fact]
    public void TestGoodShape()
    {
        StringBuilder expected = new();
        expected.AppendLine("Center: Point [X: 1 Y: 1] Radius: 3.0");
        expected.AppendLine("TopLeft: Point [X: 1 Y: 1] Side: 3.0");
        expected.Append("Center: Point [X: 1 Y: 1] Radius: 3.0");
        List<Shape> input = new()
    {
        new Circle(ShapeType.Circle, new Point{X = 1, Y = 1}, 3.0),
        new Square(ShapeType.Square, new Point{X = 1, Y = 1}, 3.0),
        new Circle(ShapeType.Circle, new Point{X = 1, Y = 1}, 3.0),
    };
        List<string> result = ShapeClient.DrawAllShapes(input);
        var act = string.Join("\r\n", result);
        Assert.Equal(expected.ToString(), act);
    }
}
