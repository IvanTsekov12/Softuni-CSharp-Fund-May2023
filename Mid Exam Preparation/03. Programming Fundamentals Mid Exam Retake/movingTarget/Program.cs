using System;
using System.Linq;
using System.Collections.Generic;

namespace movingTarget
{
    /*
     	"Shoot {index} {power}"
    	Shoot the target at the index if it exists by reducing its value by the given power (integer value). 
    	Remove the target if it is shot. A target is considered shot when its value reaches 0.
    	"Add {index} {value}"
    	Insert a target with the received value at the received index if it exists. 
    	If not, print: "Invalid placement!"
    	"Strike {index} {radius}"
    	Remove the target at the given index and the ones before and after it depending on the radius.
    	If any of the indices in the range is invalid, print: "Strike missed!" and skip this command.
    	"End"
	    Print the sequence with targets in the following format and end the program: "{target1}|{target2}…|{targetn}"


     */

    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            string command = "";

            
            while ((command = Console.ReadLine()) != "End")
            {
                string[] arguments = command.Split(' ');
                int index = int.Parse(arguments[1]);

                switch (arguments[0])
                {
                    case "Shoot":
                        int power = int.Parse(arguments[2]);
                        if (index >= 0 && index < list.Count)
                        {
                            list[index] -= power;
                            if (list[index] <= 0)
                            {
                                list.RemoveAt(index);
                            }
                        }
                        break;

                    case "Add":
                        int value = int.Parse(arguments[2]);
                        if (index >= 0 && index < list.Count)
                        {
                            list.Insert(index, value);
                        }
                        else
                        {
                            Console.WriteLine("Invalid placement!");
                        }
                        break;
                    case "Strike":
                        int radius = int.Parse(arguments[2]);
                        if (index + radius < list.Count && index - radius >= 0)
                        {
                            list.RemoveRange(index - radius, radius);
                            list.RemoveRange(index, radius);
                            list.RemoveAt(index - 1);
                        }
                        else
                        {
                            Console.WriteLine("Strike missed!");
                        }
                        break;
                }
            }

            Console.WriteLine(string.Join('|', list));
        }
    }
}