using System;
using System.Threading.Tasks;
using ODDB.Common.Entities;
using System.Collections.Generic;
using System.Text;

namespace ODDB.BusinessLogic.Interfaces
{
    public interface IReviewRepository
    {
        Task<Review> WriteReview(Drank drank, User user, String Text);
        Task DeleteReview(Review review);
    }
}
