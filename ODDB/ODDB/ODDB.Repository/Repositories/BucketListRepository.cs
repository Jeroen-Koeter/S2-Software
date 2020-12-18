using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ODDB.BusinessLogic.Interfaces;
using ODDB.Common.Entities;

namespace ODDB.Repository.Repositories
{
    public class BucketListRepository : IBucketListRepository
    {
        public Task<Drank> AddDrank(Drank drank)
        {
            throw new NotImplementedException();
        }

        public Task DeleteDrank(Drank drank)
        {
            throw new NotImplementedException();
        }
    }
}
