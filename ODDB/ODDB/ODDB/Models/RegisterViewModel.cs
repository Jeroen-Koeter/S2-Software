using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ODDB.Models
{
    public class RegisterViewModel
    {
        [Required]
        public string Email { get; set; }
        [Required]
        public string Naam { get; set; }
        [Required]
        [MinLength(8)]
        public string Wachtwoord { get; set; }

        [Required]
        [MinLength(8)]
        public string WachtwoordCheck { get; set; }
    }
}
