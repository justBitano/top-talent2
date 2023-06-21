using BussinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObject
{
    public class BookingDAO
    {
            public static List<Booking> GetBookings()
            {
                var listBookings = new List<Booking>();
                try
                {
                    using (var context = new TopTalent2Context())
                    {
                    listBookings = context.Bookings.ToList();
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
                return listBookings;
            }
        


        public static Booking GetBookingById(int bookingId)
        {
            Booking booking = new Booking();
            try
            {
                using (var context = new TopTalent2Context())
                {
                    booking = context.Bookings.SingleOrDefault(x => x.BookingId == bookingId);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return booking;
        }
        public static void CreateBooking(Booking booking)
        {
            try
            {
                using (var context = new TopTalent2Context())
                {
                    context.Bookings.Add(booking);
                    context.SaveChanges();

                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static void UpdateBooking(Booking bk)
        {
            try
            {

                using (var context = new TopTalent2Context())
                {
                    context.Entry<Booking>(bk).State =
                        Microsoft.EntityFrameworkCore.EntityState.Modified;
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static void DeleteBooking(Booking bk)
        {
            try
            {
                using (var context = new TopTalent2Context())
                {
                    var p1 = context.Bookings.SingleOrDefault(
                        c => c.BookingId == bk.BookingId
                        );
                    context.Bookings.Remove(p1);
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
