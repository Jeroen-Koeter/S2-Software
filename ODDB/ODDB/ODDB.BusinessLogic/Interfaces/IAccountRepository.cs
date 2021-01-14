using System;
using System.Collections.Generic;
using System.Text;
using ODDB.Common.Entities;

namespace ODDB.BusinessLogic.Interfaces
{
    public interface IAccountRepository
    {
        void RegisterUser(Guid ID, string Naam, string Email, string hashedWachtwoord);
        User GetUserByEmail(string Email);
    }
}
