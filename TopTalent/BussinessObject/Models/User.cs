using System;
using System.Collections.Generic;

#nullable disable

namespace BussinessObject.Models
{
    public partial class User
    {
        public User()
        {
            Bookings = new HashSet<Booking>();
            Chats = new HashSet<Chat>();
        }

        public int UserId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string FullName { get; set; }
        public int? Phone { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public int? Status { get; set; }

        public virtual ICollection<Booking> Bookings { get; set; }
        public virtual ICollection<Chat> Chats { get; set; }
    }
}
