using BussinessObject.Models;
using DataAccessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class ReviewRepository : IReviewRepository
    {

        public void CreateReview(Review review) => ReviewDAO.CreateReview(review);


        public void DeleteReview(Review review) => ReviewDAO.DeleteReview(review);


        public List<Review> GetReview() => ReviewDAO.GetReviews();


        public Review GetReviewById(int id) => ReviewDAO.GetReviewById(id);


        public void UpdateReview(Review review) => ReviewDAO.UpdateReview(review);

    }
}

