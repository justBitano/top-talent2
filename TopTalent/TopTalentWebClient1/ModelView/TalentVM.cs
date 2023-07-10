using Microsoft.AspNetCore.Http;

namespace TopTalentWebClient1.ModelView
{
    public class TalentVM
    {



        public int TalentId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string FullName { get; set; }
        public int Phone { get; set; }
        public string Address { get; set; }
        public string JobTitle { get; set; }
        public double? Price { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
        public int? Status { get; set; }
        public IFormFile ImageFile { get; set; }
    }
}
