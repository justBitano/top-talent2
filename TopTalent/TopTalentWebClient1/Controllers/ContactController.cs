using Microsoft.AspNetCore.Mvc;

namespace TopTalentWebClient1.Controllers
{
    public class ContactController : Controller
    {
        [Route("contact.html", Name = "Contact")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
