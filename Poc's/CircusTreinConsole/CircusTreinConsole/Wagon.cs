using CircusTrein;
using System;
using System.Collections.Generic;
using System.Text;

namespace CircusTreinConsole
{
    public class Wagon
    {
        public int Grote { get; private set; }
        public int HuidigeGrote { get;  set; }
        public string Naam { get; private set; }

        private List<Dier> dierenInWagon;

        public IEnumerable<Dier> Dieren => dierenInWagon;
       
     
        public Wagon(int nummer)
        {
            this.Naam = "Wagon: " + nummer;
            dierenInWagon = new List<Dier>();
            Grote = 10;
            HuidigeGrote = 0;
        }

        public void addDierAanWagon(Dier dier) 
        {
            HuidigeGrote += (int)dier.size;
            dierenInWagon.Add(dier);
        }
    }
}
