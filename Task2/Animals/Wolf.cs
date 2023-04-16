namespace Task2.Animals;

public class Wolf : Animal, ICarnivore
{
    public override string? GetParticularIndividual()
    {
        return GetType().Name;
    }

    public void Eat(Animal animal)
    {
        Console.WriteLine("I can eat only meat!\n");
    }
}