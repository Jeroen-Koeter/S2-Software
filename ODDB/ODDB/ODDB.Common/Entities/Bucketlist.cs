using System;
using System.Collections.Generic;
using System.Text;

namespace ODDB.Common.Entities
{
    public class Bucketlist
    {
        public string Naam { get; set; }
        public Guid Eignenaar { get; set; }
        public int BucketListId { get; set; }
        public List<User> Volgers { get; set; }
    }
}
