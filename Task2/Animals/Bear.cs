using Task2.Herbals;

namespace Task2.Animals;

public class Bear : Animal, ICarnivore, IHerbivore
{
    public override string? GetParticularIndividual()
    {
        return GetType().Name;
    }

    public void Eat(Animal animal)
    {
        Console.WriteLine("I can eat meat!\n");
    }

    public void Eat(Herbal herbal)
    {
        Console.WriteLine("I can eat herbal!");
    }
}