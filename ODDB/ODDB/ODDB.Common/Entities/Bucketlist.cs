using System;
using System.Collections.Generic;
using System.Text;

namespace ODDB.Common.Entities
{
    public class Bucketlist
    {
        public string Naam { get; set; }
        public User Eignenaar { get; set; }
        public Guid BucketListId { get; set; }
        public List<User> Volgers { get; set; }
    }
}
