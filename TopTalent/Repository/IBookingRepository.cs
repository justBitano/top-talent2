using BussinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public interface IBookingRepository
    {
        void CreateBooking(Booking booking);


        Booking GetBookingById(int id);

        void DeleteBooking(Booking booking);

        void UpdateBooking(Booking booking);

        List<Booking> GetBooking();
    }
}
