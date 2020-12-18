using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ODDB.BusinessLogic.Interfaces;
using ODDB.Common.Entities;

namespace ODDB.Repository.Repositories
{
    public class ReviewRepository : IReviewRepository
    {
        public Task DeleteReview(Review review)
        {
            throw new NotImplementedException();
        }

        public Task<Review> WriteReview(Drank drank, User user, string Text)
        {
            throw new NotImplementedException();
        }
    }
}
