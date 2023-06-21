using System.ComponentModel.DataAnnotations;

namespace TopTalentAPI.DTO
{
    public class UserVM
    {
        public int UserId { get; set; }
        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        [MaxLength(75)]
        public string FullName { get; set; }
        public string? Phone { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public int? Status { get; set; }
    }
}
