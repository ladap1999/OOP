namespace Task3_4.Fibonacci;

public class FibonacciLoop
{
    private List<int> numbersSequence;

    public void GetSequenceFibonacci(int lastNumber)
    {
        numbersSequence = new List<int>();
        for (int i = 0; i <= lastNumber; i++)
        {
            if (i == lastNumber)
            {
                break;
            }

            if (i == 0 || i == 1)
            {
                numbersSequence.Add(i);
            }
            else
            {
                int elementOfList = numbersSequence[i - 2] + numbersSequence[i - 1];

                if (elementOfList > lastNumber)
                {
                    break;
                }

                numbersSequence.Add(numbersSequence[i - 2] + numbersSequence[i - 1]);
            }
        }
    }

    public void PrintList()
    {
        foreach (var element in numbersSequence)
        {
            Console.Write(element + " ");
        }
    }
}