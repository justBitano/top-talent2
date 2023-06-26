using Microsoft.AspNetCore.Mvc;

namespace TopTalentWebClient1.Controllers
{
    public class BlogController : Controller
    {
        [Route("blog.html", Name = "Blog")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
