using System.ComponentModel.DataAnnotations;

namespace TopTalentAPI.DTO
{
    public class TalentVM
    {
        public int TalentId { get; set; }
        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        [MaxLength(75)]
        public string FullName { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string JobTitle { get; set; }
        public double? Price { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
        public int? Status { get; set; }
    }
}
