using System;
using System.Linq;
using System.Collections.Generic;

namespace _03_Phone_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> phones = Console.ReadLine().Split(", ").ToList();

            string command = "";
            while ((command = Console.ReadLine()) != "End")
            {
                string[] actions = command.Split(" - ");

                switch (actions[0])
                {
                    case "Add":
                        string phoneToAdd = actions[1];

                        if (!phones.Contains(phoneToAdd))
                        {
                            phones.Add(phoneToAdd);
                        }
                        break;
                    case "Remove":
                        string phoneToRemove = actions[1];
                        if (phones.Contains(phoneToRemove))
                        {
                            phones.Remove(phoneToRemove);
                        }
                        break;
                    case "Bonus phone":
                        string[] bonus = actions[1].Split(':');
                        string oldPhone = bonus[0];
                        string newPhone = bonus[1];
                        if (phones.Contains(oldPhone))
                        {
                            int oldPhoneIndex = phones.IndexOf(oldPhone);
                            phones.Insert(oldPhoneIndex + 1, newPhone);
                        }
                        break;
                    case "Last":
                        string phone = actions[1];
                        if (phones.Contains(phone))
                        {
                            string tmp = phone;
                            phones.Remove(phone);
                            phones.Add(tmp);
                        }
                        break;
                }
            }

            Console.WriteLine(string.Join(", ", phones));
        }
    }
}