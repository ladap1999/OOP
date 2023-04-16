using Task2.Animals;
using Task2.Herbals;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Bear whiteBear = new Bear();
            Wolf greyWolf = new Wolf();
            Rabbit blackRabbit = new Rabbit();

            Rose redRose = new Rose();
            Grass greenGrass = new Grass();

            Console.WriteLine(whiteBear.GetNameSpecies());
            Console.WriteLine(whiteBear.GetParticularIndividual()); 
            whiteBear.Eat(new Grass());
            whiteBear.Eat(new Rabbit());

            Console.WriteLine(greyWolf.GetNameSpecies());
            Console.WriteLine(greyWolf.GetParticularIndividual());
            greyWolf.Eat(new Rabbit());

            Console.WriteLine(blackRabbit.GetNameSpecies());
            Console.WriteLine(blackRabbit.GetParticularIndividual());
            blackRabbit.Eat(new Grass());

            Console.WriteLine("I'm rose, my species is " + redRose.GetNameSpecies());

            Console.WriteLine("I'm grass, my species is " + greenGrass.GetNameSpecies());
        }
    }
}