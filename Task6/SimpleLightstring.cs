namespace Task6;

public class SimpleLightstring : Lightstring
{
    public SimpleLightstring(int amountOfBulbs) : base(amountOfBulbs)
    {
    }

    public override void TurnedOnLights()
    {
        string burningLights = string.Empty;
        int currrentTime = DateTime.Now.Minute;
        if (DateTime.Now.Minute % 2 == 0)
        {
            for (int i = 2; i <= amountOfBulbs; i += 2)
            {
                burningLights += i + " ";
            }
        }
        else
        {
            for (int i = 1; i <= amountOfBulbs; i += 2)
            {
                burningLights += i + " ";
            }
        }
        Console.WriteLine($"Now is {currrentTime} minutes");
        Console.WriteLine($"Simple Lights numbers {burningLights} are burning with white color!");
    }
}