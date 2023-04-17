namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            ColoredLightstring coloredLightstring = new ColoredLightstring(10);
            SimpleLightstring simpleLightstring = new SimpleLightstring(20);
            
            coloredLightstring.TurnedOnLights();
            simpleLightstring.TurnedOnLights();
        }
    }
}