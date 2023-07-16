using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace race
{
    class Participant
    {
        public string Name { get; set; }
        public int Distance { get; set; }
    }
    
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] namesArr = Console.ReadLine().Split(", ");
            List<Participant> participants = new List<Participant>();

            for (int i = 0; i < namesArr.Length; i++)
            {
                Participant participant = new Participant();
                participant.Name = namesArr[i];
                participant.Distance = 0;
                participants.Add(participant);
            }
            string lettersPattern = @"[A-Za-z]";
            string digitsPattern = @"\d";

            string command = "";
            while ((command = Console.ReadLine()) != "end of race")
            {
                StringBuilder name = new StringBuilder();

                foreach (Match match in Regex.Matches(command, lettersPattern))
                {
                    name.Append(match.Value);
                }

                int distance = 0;
                foreach (Match match in Regex.Matches(command, digitsPattern))
                {
                    distance += int.Parse(match.Value);                        
                }

                Participant foundParticipant = participants.FirstOrDefault(x => x.Name == name.ToString());
                if (foundParticipant != null)
                {
                    foundParticipant.Distance += distance;
                }
            }

            List<Participant> orderedParticipants = participants.OrderByDescending(x => x.Distance)
                .Take(3).ToList();

            Console.WriteLine($"1st place: {orderedParticipants[0].Name}");
            Console.WriteLine($"2nd place: {orderedParticipants[1].Name}");
            Console.WriteLine($"3rd place: {orderedParticipants[2].Name}");
        }
    }
}