using System;
using System.Collections.Generic;
using System.Text;

namespace CircusTrein
{
    class DierBase
    {
        public int gewicht { get; private set; }
        public string naam { get; private set; }
        public int grote { get; private set; }
        public bool eetVlees { get; private set; }

        public DierBase(int gewicht, string naam, int grote, bool eetVlees)
        {
            this.gewicht = gewicht;
            this.naam = naam;
            this.grote = GetGrote(gewicht);
            this.eetVlees = eetVlees;
        }

        private int GetGrote(int gewicht) 
        {
            if (gewicht < 20) 
            {
                return 1;
            }
            if (gewicht >= 20 && gewicht < 50)
            {
                return 3;
            }
            else 
            {
                return 5;
            }
        }
    }
}
