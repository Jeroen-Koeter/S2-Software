using System;
using System.Collections.Generic;
using System.Text;

namespace ODDB.Common.Entities
{
   public class Drank
    {
        public string Naam { get; set; }
        public string Type { get; set; }
        public string Omschrijving { get; set; }
        public double AlcoholPecentage { get; set; }
        public int DrankID { get; set; }

    }
}
