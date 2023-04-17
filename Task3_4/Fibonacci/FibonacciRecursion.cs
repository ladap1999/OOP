namespace Task3_4.Fibonacci;

public class FibonacciRecursion
{
    public void GetFibonacci(int beforePreviousValue, int previousValue, int maxValue)
    {
        if (previousValue <= maxValue)
        {
            if (beforePreviousValue == 0)
            {
                Console.Write(beforePreviousValue + " ");
            }

            Console.Write(previousValue + " ");
            int currentValue = beforePreviousValue + previousValue;
            GetFibonacci(previousValue, currentValue, maxValue);
        }
    }
}