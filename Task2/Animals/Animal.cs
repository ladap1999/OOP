namespace Task2.Animals;

public abstract class Animal : Alive
{
    public override string? GetNameSpecies()
    {
        return GetType().BaseType?.Name;
    }
    public abstract string? GetParticularIndividual();
}