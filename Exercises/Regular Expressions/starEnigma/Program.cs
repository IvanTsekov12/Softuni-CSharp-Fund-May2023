using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Text;

namespace starEnigma
{
    class Message
    {
        public Message(string planetName, uint population, string attackType, uint soldierCount)
        {
            PlanetName = planetName;
            Population = population;
            AttackType = attackType;
            SoldierCount = soldierCount;
        }

        public string PlanetName { get; set; }

        public uint Population { get; set; }

        public string AttackType { get; set; }

        public uint SoldierCount { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            List<Message> messages = new List<Message>();

            int numberOfMessages = int.Parse(Console.ReadLine());
            string pattern = @"\@(?<Name>[A-Za-z]+)[^\@\-\!\:\>]*\:(?<Population>\d+)[^\@\-\!\:\>]*\!(?<AttackType>A|D)\![^\@\-\!\:\>]*\-\>[^\@\-\!\:\>]*?(?<Soldiers>\d+)[^\@\-\!\:\>]*";
            string starPattern = @"[SsTtAaRr]";

            for (int i = 0; i < numberOfMessages; i++)
            {
                string encrMessage = Console.ReadLine();

                int decryptionKey = Regex.Matches(encrMessage, starPattern).Count;

                StringBuilder sb = new StringBuilder();
                for (int j = 0; j < encrMessage.Length; j++)
                {
                    int decryptedSymbol = (int)encrMessage[j] - decryptionKey;
                    sb.Append((char)decryptedSymbol);
                }

                var match = Regex.Match(sb.ToString(), pattern);
                if (Regex.IsMatch(sb.ToString(), pattern) == false)
                {
                    continue;
                }

                string planetName = match.Groups["Name"].Value;
                uint population = uint.Parse(match.Groups["Population"].Value);
                string attackType = match.Groups["AttackType"].Value;
                uint soldierCount = uint.Parse(match.Groups["Soldiers"].Value);

                Message message = new Message(planetName, population, attackType, soldierCount);

                messages.Add(message);
            }
            var planets = messages.Where(x => x.AttackType == "A").OrderBy(x => x.PlanetName).ToList();

            Console.WriteLine($"Attacked planets: {planets.Count}");
            planets.ForEach(m => Console.WriteLine($"-> {m.PlanetName}"));

            planets = messages.Where(m => m.AttackType == "D")
                .OrderBy(m => m.PlanetName)
                .ToList();

            Console.WriteLine($"Destroyed planets: {planets.Count}");
            planets.ForEach(m => Console.WriteLine($"-> {m.PlanetName}"));
        }
    }
}