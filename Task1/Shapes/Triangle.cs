namespace Task1.Shapes;

public class Triangle : Shape
{
    private double firstSideLength;
    private double secondSideLength;
    private double thirdSideLength;
    private double heightLength;

    public Triangle(double firstSideLength, double secondSideLength, double thirdSideLength)
    {
        this.firstSideLength = firstSideLength;
        this.secondSideLength = secondSideLength;
        this.thirdSideLength = thirdSideLength;

        if (this.firstSideLength + this.secondSideLength > this.thirdSideLength
            && this.firstSideLength + this.thirdSideLength > this.secondSideLength
            && this.thirdSideLength + this.secondSideLength > this.firstSideLength)
        {
            heightLength = 2 / firstSideLength
                           * Math.Sqrt(GetHalfPerimetr() * (GetHalfPerimetr() - firstSideLength)
                                                         * (GetHalfPerimetr() - secondSideLength)
                                                         * (GetHalfPerimetr() - thirdSideLength));
        }
        else
        {
            throw new NotSupportedException("Error, the sum of the lengths of each two " +
                                            "sides must be greater than the length of the third side.");
        }
    }

    public override double GetArea()
    {
        Console.WriteLine($"Area of the triangle = {firstSideLength * heightLength / 2}");
        return firstSideLength * heightLength / 2;
    }


    public override double GetPerimeter()
    {
        Console.WriteLine($"Perimeter of the triangle = {firstSideLength + secondSideLength + thirdSideLength}");
        return firstSideLength + secondSideLength + thirdSideLength;
    }

    public double GetHalfPerimetr()
    {
        return (firstSideLength + secondSideLength + thirdSideLength) / 2;
    }
}
