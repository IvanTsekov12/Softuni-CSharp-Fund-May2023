using System;

namespace waterOverflow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());

            int totalPoured = 0;

            for (int i = 0; i < lines; i++)
            {
                int litersPoured = int.Parse(Console.ReadLine());

                totalPoured += litersPoured;
                if (totalPoured > 255)
                {
                    Console.WriteLine("Insufficient capacity!");
                    totalPoured -= litersPoured;
                }
            }

            Console.WriteLine(totalPoured);
        }
    }
}