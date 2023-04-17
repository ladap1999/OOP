using Task3_4.Fibonacci;

namespace Task3_4
{
    class Program
    {
        private const int PreviousNumber = 1;
        private const int BeforePreviousNumber = 0;

        static void Main(string[] args)
        {
            FibonacciLoop fibonacciLoop = new FibonacciLoop();
            FibonacciRecursion fibonacciRecursion = new FibonacciRecursion();

            Console.WriteLine("Enter the last number of sequence: ");
            fibonacciLoop.GetSequenceFibonacci(Convert.ToInt32(Console.ReadLine()));
            fibonacciLoop.PrintList();

            Console.WriteLine("Enter the last number of sequence: ");
            fibonacciRecursion.GetFibonacci(BeforePreviousNumber, PreviousNumber,
                Convert.ToInt32(Console.ReadLine()));
        }
    }
}