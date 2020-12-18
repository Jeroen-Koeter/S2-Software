using System;
using System.Collections.Generic;
using System.Text;

namespace ODDB.Common.Entities
{
    public class User
    {
        public string Naam { get; set; }
        public string Wachtwoord { get; set; }
        public string Email { get; set; }
        public Guid UserID { get; set; }
        public List<Bucketlist> Bucketlists { get; set; }
    }
}
