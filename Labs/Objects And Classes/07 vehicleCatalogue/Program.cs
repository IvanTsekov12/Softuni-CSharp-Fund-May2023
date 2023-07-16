using System;
using System.Linq;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.ConstrainedExecution;

namespace _07_vehicleCatalogue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();
            List<Truck> trucks = new List<Truck>();

            string command = "";
            while ((command = Console.ReadLine()) != "end")
            {
                string[] arguments = command.Split('/');
                string vehicleType = arguments[0];
                string vehicleBrand = arguments[1];
                string vehicleModel = arguments[2];
                if (vehicleType == "Car")
                {
                    int horsePower = int.Parse(arguments[3]);
                    Car car = new Car(vehicleBrand, vehicleModel, horsePower);
                    cars.Add(car);
                }
                else
                {
                    int weight = int.Parse(arguments[3]);
                    Truck truck = new Truck(vehicleBrand, vehicleModel, weight);
                    trucks.Add(truck);
                }
            }

            var sortedCars = cars.OrderBy(brand => brand.Brand).ToList();
            var sortedTrucks = trucks.OrderBy(brand => brand.Brand).ToList();

            Catalog vehicles = new Catalog(sortedCars, sortedTrucks);
            if (vehicles.Cars.Count > 0 && vehicles.Trucks.Count > 0)
            {
                Console.WriteLine("Cars:");
                foreach (Car car in vehicles.Cars)
                {
                    Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
                }
                Console.WriteLine("Trucks:");
                foreach (Truck truck in vehicles.Trucks)
                {
                    Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
                }
            }
            else if (vehicles.Cars.Count > 0 && vehicles.Trucks.Count == 0)
            {
                Console.WriteLine("Cars:");
                foreach (Car car in vehicles.Cars)
                {
                    Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
                }
            }
            else
            {
                Console.WriteLine("Trucks:");
                foreach (Truck truck in vehicles.Trucks)
                {
                    Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
                }
            }
        }
    }

    public class Truck
    {
        public Truck(string brand, string model, int weight)
        {
            Brand = brand;
            Model = model;
            Weight = weight;
        }

        public string Brand { get; set; }
        public string Model { get; set; }
        public int Weight { get; set; }
    }

    public class Car
    {
        public Car(string brand, string model, int horsePower)
        {
            Brand = brand;
            Model = model;
            HorsePower = horsePower;
        }

        public string Brand { get; set; }
        public string Model { get; set; }
        public int HorsePower { get; set; }
    }

    public class Catalog
    {
        public Catalog(List<Car> cars, List<Truck> trucks)
        {
            this.Cars = cars;
            this.Trucks = trucks;
        }

        public List<Car> Cars { get; set; }
        public List<Truck> Trucks { get; set; }
    }
}