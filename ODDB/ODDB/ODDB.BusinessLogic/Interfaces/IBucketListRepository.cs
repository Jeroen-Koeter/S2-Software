using System;
using System.Threading.Tasks;
using ODDB.Common.Entities;
using System.Collections.Generic;
using System.Text;

namespace ODDB.BusinessLogic.Interfaces
{
    public interface IBucketListRepository
    {
        Task<Drank> AddDrank(Drank drank);
        Task DeleteDrank(Drank drank);
    }
}
