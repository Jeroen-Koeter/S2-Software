using System;
using System.Collections.Generic;
using System.Text;

namespace RacingTeamApp
{
    public class RaceDicipline
    {
        public string Name { get; private set; }
        public int StartYear { get; private set; }
        public bool IsActive { get; private set; }
        private List<Season> Seasons { get; set; }
        public RaceDicipline(string name, int startYear, bool isActive, List<Season> seasons)
        {
            Name = name;
            StartYear = startYear;
            IsActive = isActive;
            Seasons = seasons;
            Seasons = new List<Season>();
        }

        public void AddSeason(Season season) 
        {
            Seasons.Add(season);            
        }
        
    }
}
