using System;
using System.Threading.Tasks;
using ODDB.Common.Entities;
using System.Collections.Generic;
using System.Text;

namespace ODDB.BusinessLogic.Interfaces
{
    public interface IUserRepository 
    {
        Task<Bucketlist> MakeBucketList(Drank drank);
        Task DeleteBucketList(Bucketlist bucketlist);
        Task<User> ChangePassword(string CurrentPassword, string NewPassword);
    }
}
