using System.ComponentModel.DataAnnotations;

namespace TopTalentAPI.DTO
{
    public class LoginVM
    {
        [Required]
        [MaxLength(100)]
        public string username { get; set; }

        [Required]
        [MaxLength(100)]
        public string password { get; set; }
    }
}
