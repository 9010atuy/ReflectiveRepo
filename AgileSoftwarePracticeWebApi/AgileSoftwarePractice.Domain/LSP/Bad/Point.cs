﻿namespace AgileSoftwarePractice.Domain.LSP.Bad;

public class Point
{
    public double X { get; set; }
    public double Y { get; set; }
    public override string ToString()
    {
        return $"Point [X: {this.X} Y: {this.Y}]";
    }
}
