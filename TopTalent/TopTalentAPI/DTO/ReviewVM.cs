namespace TopTalentAPI.DTO
{
    public class ReviewVM
    {
        public int ReviewId { get; set; }
        public int BookingId { get; set; }
        public string Text { get; set; }
        public int? Rate { get; set; }
    }
}
