using System.ComponentModel.DataAnnotations;

namespace TopTalentWebClient1.ModelView
{
    public class LoginViewModel
    {
        [MaxLength(100)]
        [Required(ErrorMessage = "Vui lòng nhập username")]
        [Display(Name = "Username")]
        public string Username { get; set; }


        [Display(Name = "Password")]
        [Required(ErrorMessage = "Vui lòng nhập mật khẩu")]
        [MinLength(5, ErrorMessage = "Mật khẩu tối thiểu 5 ký tự")]
        public string Password { get; set; }

    }
}
