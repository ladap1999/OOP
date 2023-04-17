namespace Task2.Herbals;

public abstract class Herbal : Alive
{
    public override string? GetNameSpecies()
    {
        return GetType().Name;
    }
}