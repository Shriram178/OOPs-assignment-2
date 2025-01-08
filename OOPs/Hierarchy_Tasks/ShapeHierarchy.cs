namespace OOPs.ShapeHierarchy;



public abstract class Shape
{
    public abstract string Colour { get; set; }
    public abstract double CalculateArea();
    public void PrintDetails()
    {
        Console.WriteLine($"Colour : {Colour}, Area :{CalculateArea()}");

    }
}

public class Rectangle : Shape
{
    public override string Colour { get; set; }
    private readonly string _shapeType = "Rectangle";
    public int Length { get; set; }
    public int Width { get; set; }

    public Rectangle(string colour, int length, int width)
    {
        Colour = colour;
        Length = length;
        Width = width;

    }

    public override double CalculateArea()
    {
        return this.Length * this.Width;
    }
    public new void PrintDetails()
    {
        Console.WriteLine($"Colour : {Colour}, ShapeType : {_shapeType} ,Area :{CalculateArea()}");
    }
}

public class Circle : Shape
{

    public override string Colour { get; set; }
    private readonly string _shapeType = "Circle";

    private double _radius;

    private const double Pi = Math.PI;

    public Circle(string colour, double radius)
    {
        Colour = colour;
        _radius = radius;
    }
    public override double CalculateArea()
    {
        return 2 * Pi * _radius;
    }

    public new void PrintDetails()
    {
        Console.WriteLine($"Colour : {Colour}, ShapeType : {_shapeType} ,Area :{CalculateArea()}");

    }

}