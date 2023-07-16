using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Text;

namespace netherRealms
{
    class Demon
    {
        public Demon(string name, decimal health, decimal damage)
        {
            Name = name;
            Health = health;
            Damage = damage;
        }

        public string Name { get; set; }
        public decimal Health { get; set; }
        public decimal Damage { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            string namePattern = @"[A-Za-z]+";
            string damagePattern = @"(?:(?:[-+]*)(?:\d+\.\d+|\d+))";
            string multiplyPattern = @"[\*\/]";
            string healthPattern = @"[^0-9\*\/\+\-\.]";
            List<string> input = Console.ReadLine().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            List<Demon> demons = new List<Demon>();
            for (int i = 0; i < input.Count; i++)
            {
                string demonName = "";
                foreach (Match match in Regex.Matches(input[i], namePattern))
                {
                    demonName += match.Value;
                }
                
                decimal demonHealth = 0;
                foreach (Match match in Regex.Matches(input[i], healthPattern))
                {
                    demonHealth += match.Value[0];
                }

                decimal demonDamage = 0;
                foreach (Match match in Regex.Matches(input[i], damagePattern))
                {
                    decimal number;
                    decimal.TryParse(match.Value, out number);
                    demonDamage += number;
                }
                foreach (Match match in Regex.Matches(input[i], multiplyPattern))
                {
                    switch (match.Value)
                    {
                        case "/":
                            demonDamage /= 2;
                            break;
                        case "*":
                            demonDamage *= 2;
                            break;
                    }
                }

                Demon demon = new Demon(input[i], demonHealth, demonDamage);
                demons.Add(demon);
            }

            var sortedDemons = demons.OrderBy(x => x.Name).ToList();
            int index = 0;
            foreach (Demon demon in sortedDemons)
            {
                Console.WriteLine($"{demon.Name} - {demon.Health} health, {demon.Damage:f2} damage");
                index++;
            }
        }
    }
}