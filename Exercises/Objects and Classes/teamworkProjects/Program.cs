using System;
using System.Linq;
using System.Collections.Generic;

namespace teamworkProjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfTeams = int.Parse(Console.ReadLine());

            List<Team> teams = new List<Team>();

            for (int i = 0; i < numberOfTeams; i++)
            {
                string creatorTeamString = Console.ReadLine();
                string[] arguments = creatorTeamString.Split('-');
                string creator = arguments[0];
                string teamName = arguments[1];
                
                Team team = new Team(teamName, creator);
                teams.Add(team);
                
                Console.WriteLine($"Team {teamName} has been created by {creator}!");
            }

            string command = "";

            while ((command = Console.ReadLine()) != "end of assignment")
            {
                string[] argumnets = command.Split("->");
                string memberName = argumnets[0];
                string desiredTeam = argumnets[1];

                Team foundTeam = teams.Find(team => team.Name == desiredTeam);
                if (foundTeam != null)
                {
                    foundTeam.Members.Add(memberName);
                }
            }

            List<Team> validTeams = teams.FindAll(team => team.Members.Count > 0);
            List<Team> disbandTeams = teams.FindAll(team => team.Members.Count == 0);

            for (int i = 0; i < teams.Count; i++)
            {
                
            }

            foreach (Team team in teams)
            {
                Console.WriteLine(team.Name);
                Console.WriteLine($"- {team.Creator}");
                foreach (string member in team.Members)
                {
                    Console.WriteLine($"-- {member}");
                }
            }
        }
    }

    public class Team
    {
        public Team(string name, string creator)
        {
            name = Name;
            creator = Creator;
            Members = new List<string>();
        }
        public string Name { get; set; }
        public string Creator { get; set; }
        public List<string> Members { get; set; }
    }
}