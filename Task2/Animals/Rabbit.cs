using Task2.Herbals;

namespace Task2.Animals;

public class Rabbit : Animal, IHerbivore
{
    public override string? GetParticularIndividual()
    {
        return GetType().Name;
    }

    public void Eat(Herbal herbal)
    {
        Console.WriteLine("I can eat only herbal!\n");
    }
}