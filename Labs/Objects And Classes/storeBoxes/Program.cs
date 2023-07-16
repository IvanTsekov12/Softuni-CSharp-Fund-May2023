using System;
using System.Linq;
using System.Collections.Generic;

namespace storeBoxes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Box> boxes = new List<Box>();

            string command = "";
            while ((command = Console.ReadLine()) != "end")
            {
                string[] arguments = command.Split();
                string serialNumber = arguments[0];
                string itemName = arguments[1];
                int quanity = int.Parse(arguments[2]);
                decimal price = decimal.Parse(arguments[3]);

                Item item = new Item(itemName, price);
                Box box = new Box(serialNumber, quanity, item);

                boxes.Add(box);
            }

            var sortedBoxes = boxes.OrderByDescending(price => price.BoxPrice);

            foreach (Box box in sortedBoxes)
            {
                Console.WriteLine(box.SerialNumber);
                Console.WriteLine($"-- {box.Item.Name} - ${box.Item.Price:f2}: {box.Quantity}");
                Console.WriteLine($"-- ${box.BoxPrice:f2}");
            }
        }
    }

    public class Item
    {
        public Item(string name, decimal price)
        {
            Name = name;
            Price = price;
        }

        public string Name { get; set; }
        public decimal Price { get; set; }
    }

    public class Box
    {
        public Box(string serialNumber, int quantity, Item item)
        {
            SerialNumber = serialNumber;
            Quantity = quantity;
            Item = item;
        }

        public string SerialNumber { get; set; }
        public int Quantity { get; set; }
        public Item Item { get; set; }
        public decimal BoxPrice => Item.Price * Quantity;
    }
}