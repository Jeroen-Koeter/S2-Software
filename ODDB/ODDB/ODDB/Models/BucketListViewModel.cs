using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using ODDB.Common.Entities;

namespace ODDB.Models
{
    public class BucketListViewModel
    {
        [Required]
        public string Naam { get; set; }
        [Required]
        public int BucketListID { get; set; }

        [Required]
        public List<Drank> Drankjes { get; set; }
    }
}
