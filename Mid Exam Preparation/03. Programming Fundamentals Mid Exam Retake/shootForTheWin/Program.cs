using System;
using System.Linq;
using System.Collections.Generic;

namespace shootForTheWin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int shots = 0;
            string command = "";

            while ((command = Console.ReadLine()) != "End")
            {
                int index = int.Parse(command);

                if ((index >= 0 && index < arr.Length) && arr[index] != -1)
                {
                    shots++;
                    for (int i = 0; i < arr.Length; i++)
                    {
                        if (i != index && arr[i] != -1)
                        {
                            if (arr[i] > arr[index])
                            {
                                arr[i] -= arr[index];
                            }
                            else
                            {
                                arr[i] += arr[index];
                            }
                        }
                    }

                    arr[index] = -1;
                }
            }

            Console.WriteLine($"Shot targets: {shots} -> {string.Join(" ", arr)}");
        }
    }
}