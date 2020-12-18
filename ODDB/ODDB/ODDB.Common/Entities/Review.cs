using System;
using System.Collections.Generic;
using System.Text;

namespace ODDB.Common.Entities
{
    public class Review
    {
        public Drank Product { get; set; }
        public string Text { get; set; }
        public User Scrhijver { get; set; }
        public DateTime Date { get; set; }
        public Guid ReviewId { get; set; }
    }
}
