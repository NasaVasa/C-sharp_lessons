using System.Text.Json;

namespace lesson_12;

public abstract class Shape
{
    public abstract double Area { get; }
    public abstract double GetArea();
    public int GetRandom => new Random().Next();
}

public class Rectangle : Shape
{
    public double A { get; }
    public double B { get; }

    public override double Area => A * B;
    public override double GetArea() => Area;
}