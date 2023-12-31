﻿using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace TopTalentWebClient1.ModelView
{
    public class UserVM
    {
        [Key]
        public int UserId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string FullName { get; set; }
        public int? Phone { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public int? Status { get; set; }

        public IFormFile ImageFile { get; set; }
    }
}
