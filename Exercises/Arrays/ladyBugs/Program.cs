﻿using System;
using System.Linq;

namespace ladyBugs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int fieldLength = int.Parse(Console.ReadLine());
            int[] bugPlaces = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int[] field = new int[fieldLength];

            for (int i = 0; i < bugPlaces.Length; i++)
            {
                int bugIndex = bugPlaces[i];
                if (bugIndex >= 0 && bugIndex < field.Length)
                {
                    field[bugIndex] = 1;
                }
            }

            string command = "";
            while ((command = Console.ReadLine()) != "end")
            {
                string[] arguments = command.Split();
                int bugIndex = int.Parse(arguments[0]);
                string direction = arguments[1];
                int flyLength = int.Parse(arguments[2]);

                field[bugIndex] = 0;

                if (direction == "right")
                {
                    int landIndex = bugIndex + flyLength;

                    if (landIndex > field.Length - 1 || landIndex < 0)
                    {
                        continue;
                    }

                    if (field[landIndex] == 1)
                    {
                        while (field[landIndex] == 1)
                        {
                            landIndex += flyLength;
                            if (landIndex > field.Length - 1 || landIndex < 0)
                            {
                                break;
                            }
                        }
                    }

                    if (landIndex <= field.Length - 1 && landIndex >= 0)
                    {
                        field[landIndex] = 1;
                    }
                }
                else if (direction == "left")
                {
                    int landIndex = bugIndex - flyLength;

                    if (landIndex > field.Length - 1 || landIndex < 0)
                    {
                        continue;
                    }

                    if (field[landIndex] == 1)
                    {
                        while (field[landIndex] == 1)
                        {
                            landIndex -= flyLength;
                            if (landIndex > field.Length - 1 || landIndex < 0)
                            {
                                break;
                            }
                        }
                    }

                    if (landIndex <= field.Length - 1 && landIndex >= 0)
                    {
                        field[landIndex] = 1;
                    }
                }
            }

            Console.WriteLine(string.Join(" ", field));
        }
    }
}