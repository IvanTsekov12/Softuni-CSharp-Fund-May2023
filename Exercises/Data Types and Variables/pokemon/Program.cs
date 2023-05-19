using System;

namespace pokemon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pokePower = int.Parse(Console.ReadLine());
            int pokeTargetsDistance = int.Parse(Console.ReadLine());
            int exhaustionFactor = int.Parse(Console.ReadLine());
            int pokeCounts = 0;
            int originalPokePower = pokePower;

            while (pokePower >= pokeTargetsDistance)
            {
                pokePower -= pokeTargetsDistance;
                pokeCounts++;

                if (originalPokePower / 2 == pokePower && exhaustionFactor > 0)
                {
                    pokePower /= exhaustionFactor;
                }
            }

            Console.WriteLine(pokePower);
            Console.WriteLine(pokeCounts);
        }
    }
}