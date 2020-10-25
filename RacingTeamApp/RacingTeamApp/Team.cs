using System;
using System.Collections.Generic;
using System.Text;

namespace RacingTeamApp
{
    public class Team
    {
        public string Name { get; private set; }
        public string City { get; private set; }
        public string Country { get; private set; }
        public string MainSponsor { get; private set; }
        public int FoundingYear { get; private set; }

        public Team(string name, string city, string country, string mainSponsor, int foundingYear)
        {
            Name = name;
            City = city;
            Country = country;
            MainSponsor = mainSponsor;
            FoundingYear = foundingYear;
        }

        public void UpdateTeam() 
        { 
        }
    }
}
