using System;

namespace beerKegs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int kegsCount = int.Parse(Console.ReadLine());

            string biggestKegModel = "";
            double biggestKegVolume = 0;

            for (int i = 0; i < kegsCount; i++)
            {
                string model = Console.ReadLine();
                double kegRadius = double.Parse(Console.ReadLine());
                int kegHeight = int.Parse(Console.ReadLine());

                double volume = Math.PI * Math.Pow(kegRadius, 2) * kegHeight;

                if (biggestKegVolume < volume)
                {
                    biggestKegModel = model;
                    biggestKegVolume = volume;
                }
            }

            Console.WriteLine(biggestKegModel);
        }
    }
}