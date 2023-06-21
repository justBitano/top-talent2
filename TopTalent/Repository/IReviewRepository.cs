using BussinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public interface IReviewRepository
    {
        void CreateReview(Review review);


        Review GetReviewById(int id);

        void DeleteReview(Review review);

        void UpdateReview(Review review);

        List<Review> GetReview();
    }
}
