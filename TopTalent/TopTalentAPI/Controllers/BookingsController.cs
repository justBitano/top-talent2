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
    public class BookingsController : ControllerBase
    {
        private IBookingRepository repo = new BookingRepository();

        [HttpGet]
        public ActionResult<IEnumerable<Booking>> GetBooking() => repo.GetBooking();

        [HttpGet("id")]
        public IActionResult GetBookingById(int id)
        {
            try
            {
                var booking = repo.GetBookingById(id);
                return Ok(booking);

            }
            catch (Exception ex)
            {
                return NotFound();
            }

        }

        [HttpDelete]
        public IActionResult DeleteBooking(int id)
        {
            var p = repo.GetBookingById(id);
            if (p == null)
            {
                return NotFound();
            }
            repo.DeleteBooking(p);
            return Ok(p);
        }

        [HttpPost]
        public IActionResult CreateBooking(BookingVM booking)
        {
            var bookTmp = new Booking
            {
               BookingId = booking.BookingId,
               CreateDate = booking.CreateDate,
               Cash = booking.Cash,
               Description = booking.Description,
               Status = booking.Status,
               UserId = booking.UserId,
               TalentId = booking.TalentId,

            };
            repo.CreateBooking(bookTmp);
            return Ok();
        }

        [HttpPut("id")]
        public IActionResult UpdateBooking(int id, BookingVM booking)
        {
            var p = repo.GetBookingById(id);
            if (p != null)
            {
                p.BookingId = booking.BookingId;
                p.CreateDate = booking.CreateDate;
                p.Cash = booking.Cash;
                p.Description = booking.Description;
                p.UserId = booking.UserId;
                p.TalentId = booking.TalentId;
                p.Status = booking.Status;

                repo.UpdateBooking(p);
                return Ok(p);
            }

            return NotFound();
        }
    }
}
