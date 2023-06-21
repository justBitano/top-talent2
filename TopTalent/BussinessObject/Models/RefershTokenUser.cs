using System;
using System.Collections.Generic;

#nullable disable

namespace BussinessObject.Models
{
    public partial class RefershTokenUser
    {
        public int RefershToken { get; set; }
        public int? UserId { get; set; }
        public string Token { get; set; }
        public string JwtId { get; set; }
        public bool? IsUsed { get; set; }
        public bool? IsRevoked { get; set; }
        public DateTime? IssuedAt { get; set; }
        public DateTime? ExpiredAt { get; set; }
    }
}
