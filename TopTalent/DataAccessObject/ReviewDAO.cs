using BussinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObject
{
    public class ReviewDAO
    {
        
            public static List<Review> GetReviews()
            {
                var listReviews = new List<Review>();
                try
                {
                    using (var context = new TopTalent2Context())
                    {
                    listReviews = context.Reviews.ToList();
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
                return listReviews;
            }
      

        

        public static Review GetReviewById(int reviewId)
        {
            Review review = new Review();
            try
            {
                using (var context = new TopTalent2Context())
                {
                    review = context.Reviews.SingleOrDefault(x => x.ReviewId == reviewId);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return review;
        }
        public static void CreateReview(Review review)
        {
            try
            {
                using (var context = new TopTalent2Context())
                {
                    context.Reviews.Add(review);
                    context.SaveChanges();

                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static void UpdateReview(Review review)
        {
            try
            {

                using (var context = new TopTalent2Context())
                {
                    context.Entry<Review>(review).State =
                        Microsoft.EntityFrameworkCore.EntityState.Modified;
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static void DeleteReview(Review review)
        {
            try
            {
               
                using (var context = new TopTalent2Context())
                {
                    var review1 = context.Reviews.SingleOrDefault(
                        c => c.ReviewId == review.ReviewId
                        );
                    context.Reviews.Remove(review1);
                    context.SaveChanges();
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
