using System;
using System.Collections.Generic;

#nullable disable

namespace TopTalentWebClient1.Models
{
    public partial class RefreshTokenTalent
    {
        public int RefreshTokenTalentId { get; set; }
        public int? TalentId { get; set; }
        public string Token { get; set; }
        public string JwtId { get; set; }
        public bool? IsUsed { get; set; }
        public bool? IsRevoked { get; set; }
        public DateTime? IssuedAt { get; set; }
        public DateTime? ExpiredAt { get; set; }

        public virtual Talent Talent { get; set; }
    }
}
