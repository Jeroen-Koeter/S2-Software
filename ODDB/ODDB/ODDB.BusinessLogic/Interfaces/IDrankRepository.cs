using System;
using System.Threading.Tasks;
using ODDB.Common.Entities;
using System.Collections.Generic;
using System.Text;

namespace ODDB.BusinessLogic.Interfaces
{
    public interface IDrankRepository
    {
        List<Drank> GetDrankByAttribute(string Attribute, string data);
        List<Drank> GetAll();
        void CreateDrank(Drank drank);
        void DeleteDrank(int DrankID);
        void UpdateDrank(Drank drank);
        Drank GetDrankByID(int DrankID);
        
    }
}
