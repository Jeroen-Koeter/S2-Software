using System;
using System.Collections.Generic;
using System.Text;

namespace CircusTrein
{
    public class Dier
    {
        public string naam { get; private set; }
        public Dieet diet { get; private set; }
        public Grote size { get; private set; }
        public enum Dieet 
        {
            herbivoor = 1,
            carnivoor = 2
        }
        public enum Grote 
        {
            klein = 1,
            middel = 3,
            groot = 5,
        }

        public Dier(string naam, Dieet dieet, Grote grote)
        {
            this.naam = naam;
            diet = dieet;
            size = grote;

        }

        public override string ToString()
        {
            return naam + " " + diet + " " + size;
        }
    }
}
