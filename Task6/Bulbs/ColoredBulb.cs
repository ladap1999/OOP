using Task6.Enam;

namespace Task6.Bulbs;

public class ColoredBulb : Bulb
{
    private Colors color;
    
    public void SetColor(Colors color)
    {
        this.color = color;
    }

    public String GetColor()
    {
        return this.color.ToString();
    }

    public ColoredBulb(string serialNumber) : base(serialNumber)
    {
        if (serialNumber.EndsWith('1') || serialNumber.EndsWith('5') || serialNumber.EndsWith('9'))
        {
            SetColor(Colors.Red);
        }
        else if (serialNumber.EndsWith('2') || serialNumber.EndsWith('6'))
        {
            SetColor(Colors.Yellow);
        }
        else if (serialNumber.EndsWith('3') || serialNumber.EndsWith('7'))
        {
            SetColor(Colors.Green);
        }
        else if (serialNumber.EndsWith('4') || serialNumber.EndsWith('8'))
        {
            SetColor(Colors.Blue);
        }
    }
}