using System;
using System.Collections.Generic;

#nullable disable

namespace BussinessObject.Models
{
    public partial class Review
    {
        public int ReviewId { get; set; }
        public int BookingId { get; set; }
        public string Text { get; set; }
        public int? Rate { get; set; }

        public virtual Booking Booking { get; set; }
    }
}
