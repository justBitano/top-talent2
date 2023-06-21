using System;
using System.Collections.Generic;

#nullable disable

namespace BussinessObject.Models
{
    public partial class Payment
    {
        public int PaymentId { get; set; }
        public int BookingId { get; set; }
        public double? Ammount { get; set; }
        public string Method { get; set; }

        public virtual Booking Booking { get; set; }
    }
}
