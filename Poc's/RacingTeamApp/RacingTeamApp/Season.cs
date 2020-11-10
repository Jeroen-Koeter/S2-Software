using System;
using System.Collections.Generic;
using System.Text;

namespace RacingTeamApp
{
    public class Season
    {
        public int NumberOfRaces { get; private set; }
        public string Champion { get; private set; }
        public int Year { get; private set; }
        private List<Team> Teams { get; set; }

        public Season(int numberOfRaces, string champion, int year, List<Team> teams)
        {
            NumberOfRaces = numberOfRaces;
            Champion = champion;
            Year = year;
            Teams = teams;
            Teams = new List<Team>();
        }

        public void AddTeam(Team team) 
        {
            Teams.Add(team);
        }

        public void RemoveTeam(Team team)
        {
            Teams.Remove(team);
        }
        
        public void AddChampion(string champion)
        {
            Champion = champion;
        }
    }
}
