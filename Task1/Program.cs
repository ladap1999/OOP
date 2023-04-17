using Task1.Shapes;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the radius:");
            Circle circle = new Circle(Convert.ToDouble(Console.ReadLine()));
            circle.GetPerimeter();
            circle.GetArea();

            Console.WriteLine("Enter the side of square:");
            Square square = new Square(Convert.ToDouble(Console.ReadLine()));
            square.GetPerimeter();
            square.GetArea();
            
            Console.WriteLine("Enter 3 sides of triangle:");
            Triangle triangle = new Triangle(Convert.ToDouble(Console.ReadLine()),
                Convert.ToDouble(Console.ReadLine()),
                Convert.ToDouble(Console.ReadLine()));
            triangle.GetPerimeter();
            triangle.GetArea();
        }
    }
};