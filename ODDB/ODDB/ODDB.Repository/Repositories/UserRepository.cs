using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ODDB.BusinessLogic.Interfaces;
using ODDB.Common.Entities;

namespace ODDB.Repository.Repositories
{
    public class UserRepository : IUserRepository
    {
        public Task<User> ChangePassword(string CurrentPassword, string NewPassword)
        {
            throw new NotImplementedException();
        }

        public Task DeleteBucketList(Bucketlist bucketlist)
        {
            throw new NotImplementedException();
        }

        public Task<Bucketlist> MakeBucketList(Drank drank)
        {
            throw new NotImplementedException();
        }
    }
}
