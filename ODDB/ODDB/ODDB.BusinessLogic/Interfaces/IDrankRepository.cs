using System;
using System.Threading.Tasks;
using ODDB.Common.Entities;
using System.Collections.Generic;
using System.Text;

namespace ODDB.BusinessLogic.Interfaces
{
    public interface IDrankRepository
    {
        Drank GetDrankByID(int Id);
        List<Drank> GetAll();
        void CreateDrank(Drank drank);
    }
}
