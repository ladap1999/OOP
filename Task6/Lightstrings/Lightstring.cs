using Task6.Bulbs;

namespace Task6.Lightstrings;

public  abstract class Lightstring
{
    private Bulb bulb;
    protected List<ColoredBulb> coloredBulbs;
    protected int amountOfBulbs;

    protected Lightstring(int amountOfBulbs)
    {
        this.amountOfBulbs = amountOfBulbs;
    }

    public abstract void TurnedOnLights();
}