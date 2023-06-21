using BussinessObject.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Repository;
using System;
using System.Collections.Generic;
using TopTalentAPI.DTO;

namespace TopTalentAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReviewsController : ControllerBase
    {
        private IReviewRepository repo = new ReviewRepository();

        [HttpGet]
        public ActionResult<IEnumerable<Review>> GetTalent() => repo.GetReview();

        [HttpGet("id")]
        public IActionResult GetReviewById(int id)
        {
            try
            {
                var review = repo.GetReviewById(id);
                return Ok(review);

            }
            catch (Exception ex)
            {
                return NotFound();
            }

        }

        [HttpPost]
        public IActionResult CreateReview(ReviewVM review)
        {
            var rev = new Review
            {
                ReviewId = review.ReviewId,
                BookingId = review.BookingId,
                Text = review.Text,
                Rate = review.Rate,
                
            };
            repo.CreateReview(rev);
            return Ok();
        }

        [HttpDelete]
        public IActionResult DeleteReview(int id)
        {
            var p = repo.GetReviewById(id);
            if (p == null)
            {
                return NotFound();
            }
            repo.DeleteReview(p);
            return Ok(p);
        }

        [HttpPut("id")]
        public IActionResult UpdateReview(int id, ReviewVM review)
        {
            var p = repo.GetReviewById(id);
            if (p != null)
            {
                p.ReviewId = review.ReviewId;
                p.BookingId = review.BookingId;
                p.Text = review.Text;
                p.Rate = review.Rate;
                repo.UpdateReview(p);
                return Ok(p);
            }

            return NotFound();
        }
    }
}
