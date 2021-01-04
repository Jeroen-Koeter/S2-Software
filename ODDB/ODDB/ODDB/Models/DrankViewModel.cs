using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ODDB.Models
{
    public class DrankViewModel
    {
        [Required]
        public string Naam { get; set; }
        [Required]
        public string Type { get; set; }
        [Required]
        public string Omschrijving { get; set; }
        [Required]
        public double AlcoholPecentage { get; set; }
        [Required]
        public int DrankID { get; set; }
    }
}
