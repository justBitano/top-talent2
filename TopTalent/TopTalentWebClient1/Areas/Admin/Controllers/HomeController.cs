using Microsoft.AspNetCore.Mvc;

namespace TopTalentWebClient1.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }
    }
}
