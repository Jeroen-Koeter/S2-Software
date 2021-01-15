using System;
using System.Threading.Tasks;
using ODDB.Common.Entities;
using System.Collections.Generic;
using System.Text;

namespace ODDB.BusinessLogic.Interfaces
{
    public interface IBucketListRepository
    {
        void AddDrank(int BucketlistID, int DrankID);
        void Deletebucketlistentry(int BucketlistID);
        void Deletebucketlist(int BucketlistID);
        void CreateBucketList(string Naam, string UserID);
        List<Bucketlist> GetBucketlistsByUser(string UserID);
        List<Drank> GetDrankFromBucketlist(int BucketlistID);
        List<Drank> GetNotInBucketlist(int BucketListID);
    }
}
