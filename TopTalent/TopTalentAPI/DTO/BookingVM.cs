using System;

namespace TopTalentAPI.DTO
{
    public class BookingVM
    {
        public int BookingId { get; set; }
        public DateTime? CreateDate { get; set; }
        public double Cash { get; set; }
        public string Description { get; set; }
        public int? Status { get; set; }
        public int UserId { get; set; }
        public int TalentId { get; set; }
    }
}
