using System;
using System.Collections.Generic;
using System.Text;

namespace RacingTeamApp
{
    public class TeamCollection
    {
        private List<Team> Teams { get; set; }

        public TeamCollection() 
        {
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

        public List<Team> GetAllTeams()
        {
            return Teams;
        }
    }
}
