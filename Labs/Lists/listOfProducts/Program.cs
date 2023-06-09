using System;
using System.Linq;
using System.Collections.Generic;

namespace listOfProducts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int productsCount = int.Parse(Console.ReadLine());

            List<string> prodctsList = new List<string>();

            for (int i = 0; i < productsCount; i++)
            {
                string product = Console.ReadLine();

                prodctsList.Add(product);
            }

            prodctsList.Sort();

            for (int i = 0; i < prodctsList.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{prodctsList[i]}");
            }
        }
    }
}