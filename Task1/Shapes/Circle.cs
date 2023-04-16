namespace Task1.Shapes;

public class Circle : Shape
{
    private double radius;
    
    public Circle(double radius)
    {
        this.radius = radius;
    }

    public override double GetArea()
    {
        Console.WriteLine($"Area of the circle = {Math.PI * Math.Pow(radius, 2)}");
        return  Math.PI * Math.Pow(radius, 2);
    }

    public override double GetPerimeter()
    {
        Console.WriteLine($"Perimeter of the circle = {2 * Math.PI * radius}");
        return 2 * Math.PI * radius;;
    }
}