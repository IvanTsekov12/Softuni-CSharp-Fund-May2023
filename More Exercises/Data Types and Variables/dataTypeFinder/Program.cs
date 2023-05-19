using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dataTypeFinder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            string dataType = "";

            while (command != "END")
            {
                if (int.TryParse(command, out _))
                {
                    dataType = "integer";
                }
                else if (double.TryParse(command, out _))
                {
                    dataType = "floating point";
                }
                else if (char.TryParse(command, out _))
                {
                    dataType = "character";
                }
                else if (bool.TryParse(command, out _))
                {
                    dataType = "boolean";
                }
                else
                {
                    dataType = "string";
                }

                Console.WriteLine($"{command} is {dataType} type");
                command = Console.ReadLine();
            }
        }
    }
}
