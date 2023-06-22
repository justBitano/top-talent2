using System;
using System.Collections.Generic;

#nullable disable

namespace TopTalentWebClient1.Models
{
    public partial class Booking
    {
        public Booking()
        {
            Payments = new HashSet<Payment>();
            Reviews = new HashSet<Review>();
        }

        public int BookingId { get; set; }
        public DateTime? CreateDate { get; set; }
        public double Cash { get; set; }
        public string Description { get; set; }
        public int? Status { get; set; }
        public int UserId { get; set; }
        public int TalentId { get; set; }

        public virtual Talent Talent { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<Payment> Payments { get; set; }
        public virtual ICollection<Review> Reviews { get; set; }
    }
}
