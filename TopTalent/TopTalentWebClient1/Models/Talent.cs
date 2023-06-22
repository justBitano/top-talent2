using System;
using System.Collections.Generic;

#nullable disable

namespace TopTalentWebClient1.Models
{
    public partial class Talent
    {
        public Talent()
        {
            Bookings = new HashSet<Booking>();
            Chats = new HashSet<Chat>();
        }

        public int TalentId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string FullName { get; set; }
        public int Phone { get; set; }
        public string Address { get; set; }
        public string JobTitle { get; set; }
        public double? Price { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
        public int? Status { get; set; }

        public virtual ICollection<Booking> Bookings { get; set; }
        public virtual ICollection<Chat> Chats { get; set; }
    }
}
