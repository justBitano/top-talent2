﻿using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace TopTalentWebClient1.ModelView
{
    public class RegsiterTalentVM
    {
        [Key]
        public int TalentId { get; set; }
        [Display(Name = "Họ và Tên")]
        [Required(ErrorMessage = "Vui lòng nhập Họ Tên")]
        public string FullName { get; set; }
        [Display(Name = "Username")]
        [Required(ErrorMessage = "Vui lòng nhập Username")]
        [MaxLength(100)]
        [DataType(DataType.Text)]
        public string Username { get; set; }

        [Display(Name = "Password")]
        [Required(ErrorMessage = "Vui lòng nhập Password")]
        [MinLength(5, ErrorMessage = "Mật khẩu tối thiểu 5 ký tự")]
        public string Password { get; set; }

        [Display(Name = "Confirm Password")]
        [Required(ErrorMessage = "Vui lòng nhập Password")]
        [MinLength(5, ErrorMessage = "Mật khẩu tối thiểu 5 ký tự")]
        [Compare("Password", ErrorMessage = "Vui lòng nhập lại Password giống nhau")]
        public string ConfirmPassword { get; set; }

        [Display(Name = "Phone")]
        public int Phone { get; set; }

        [Display(Name = "Description")]
        public string Description { get; set; }

        [Display(Name = "Image")]
        public string Image { get; set; }
        [Display(Name = "Address")]
        public string Address { get; set; }
        [Display(Name = "JobTitle")]
        public string JobTitle { get; set; }
        [Display(Name = "Price")]
        public double? Price { get; set; }
        [Display(Name = "Status")]
        public int? Status { get; set; }
    }
}
