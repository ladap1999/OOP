namespace Task1.Shapes;

public class Square : Shape
{
    private double sideLength;

    public Square(double sideLength)
    {
        this.sideLength = sideLength;
    }

    public override double GetArea()
    {   
        Console.WriteLine($"Area of the square = {Math.Pow(sideLength,2)}");
        return  Math.Pow(sideLength,2);
    }

    public override double GetPerimeter()
    {
        Console.WriteLine($"Perimeter of the square = {sideLength * 4}");
        return sideLength * 4;
    }
}