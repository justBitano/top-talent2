using BussinessObject.Models;
using DataAccessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class BookingRepository : IBookingRepository
    {
        public void CreateBooking(Booking booking) => BookingDAO.CreateBooking(booking);
       

        public void DeleteBooking(Booking booking) => BookingDAO.DeleteBooking(booking);
        

        public List<Booking> GetBooking() => BookingDAO.GetBookings();
      

        public Booking GetBookingById(int id) => BookingDAO.GetBookingById(id);


        public void UpdateBooking(Booking booking) => BookingDAO.UpdateBooking(booking);
       
    }
}
