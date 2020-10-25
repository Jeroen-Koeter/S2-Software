using System;
using System.Collections.Generic;

namespace RacingTeamApp
{
    public class RaceDiciplineCollection
    {
        public List<RaceDicipline> raceDiciplines { get; private set; }

        public RaceDiciplineCollection(List<RaceDicipline> raceDiciplines)
        {
            this.raceDiciplines = raceDiciplines;
        }

        public void AddRaceDicipline(RaceDicipline raceDicipline) 
        {
            raceDiciplines.Add(raceDicipline);
        }
        public void RemoveRaceDicipline(RaceDicipline raceDicipline) 
        {
            raceDiciplines.Remove(raceDicipline);
        }
    }
}
