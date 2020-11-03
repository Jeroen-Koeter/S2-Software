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
        public List<Dier> DierenInWagon { get; private set; }

        public Wagon(int nummer)
        {
            this.Naam = "Wagon: " + nummer;
            DierenInWagon = new List<Dier>();
            Grote = 10;
            HuidigeGrote = 0;
        }

        public void addDierAanWagon(Dier dier) 
        {
            HuidigeGrote += (int)dier.size;
            DierenInWagon.Add(dier);
        }
    }
}
