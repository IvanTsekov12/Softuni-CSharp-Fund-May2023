    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.ConstrainedExecution;

    namespace _02._Tax_Calculator
    {
        internal class Program
        {
            static void Main(string[] args)
            {
                string[] allCars = Console.ReadLine().Split(">>");

                double totalTaxesCollected = 0;

                for (int i = 0; i < allCars.Length; i++)
                {
                    string[] currentCar = allCars[i].Split();
                    string carType = currentCar[0];
                    int taxYears = int.Parse(currentCar[1]);
                    int kilometersTravelled = int.Parse(currentCar[2]);
                    double initalTax = 0;
                    double currentTax = 0;
                    double yearlyDecline = 0;
                    double kilometersOverPrice = 0;

                    switch (carType)
                    {
                        case "family":
                            initalTax = 50;
                            kilometersOverPrice = kilometersTravelled / 3000 * 12;
                            yearlyDecline = initalTax - taxYears * 5;
                            currentTax = kilometersOverPrice + yearlyDecline;
                            break;
                        case "heavyDuty":
                            initalTax = 80;
                            kilometersOverPrice = kilometersTravelled / 9000 * 14;
                            yearlyDecline = initalTax - taxYears * 8;
                            currentTax = kilometersOverPrice + yearlyDecline;
                            break;
                        case "sports":
                            initalTax = 100;
                            kilometersOverPrice = kilometersTravelled / 2000 * 18;
                            yearlyDecline = initalTax - taxYears * 9;
                            currentTax = kilometersOverPrice + yearlyDecline;
                            break;
                        default:
                            Console.WriteLine("Invalid car type.");
                            continue;
                    }

                    Console.WriteLine($"A {carType} car will pay {currentTax:f2} euros in taxes.");
                    totalTaxesCollected += currentTax;
                }

                Console.WriteLine($"The National Revenue Agency will collect {totalTaxesCollected:f2} euros in taxes.");
            }
        }
    }