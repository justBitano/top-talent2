using System;

#nullable disable

namespace TopTalentWebClient1.Models
{
    public partial class Chat
    {
        public int UserId { get; set; }
        public int TalentId { get; set; }
        public string Message { get; set; }
        public DateTime Time { get; set; }

        public virtual Talent Talent { get; set; }
        public virtual User User { get; set; }
    }
}
