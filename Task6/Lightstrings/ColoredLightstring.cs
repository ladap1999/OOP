using Task6.Bulbs;

namespace Task6.Lightstrings;

public class ColoredLightstring : Lightstring
{
    public ColoredLightstring(int amountOfBulbs) : base(amountOfBulbs)
    {
        coloredBulbs = new List<ColoredBulb>();
        Random random = new Random();
        for (int i = 1; i <= amountOfBulbs; i++)
        {
            coloredBulbs.Add(new ColoredBulb(random.Next(1, 400).ToString()));
        }
    }
    
    public override void TurnedOnLights()
    {
        string burningLights = string.Empty;
        int currrentTime = DateTime.Now.Minute;
        
        if (currrentTime % 2 == 0)
        {
            for (int i = 0; i < amountOfBulbs; i += 2)
            {   
                burningLights += $" {i}.{coloredBulbs[i].GetColor()} ";
            }
        }
        else
        {
            for (int i = 1; i < amountOfBulbs; i += 2)
            {
                burningLights += $" {i}.{coloredBulbs[i].GetColor()} ";
            }
        }
        Console.WriteLine($"Now is {currrentTime} minutes");
        Console.WriteLine($"Lights numbers {burningLights} are burning!");
    }
}