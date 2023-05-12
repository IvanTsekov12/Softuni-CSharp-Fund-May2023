using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();   
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine($"Hello, my name is {name} and I am {age} years old!");
        }
    }
}
