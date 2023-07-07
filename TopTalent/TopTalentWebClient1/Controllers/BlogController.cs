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

        [Route("blog1.html")]
        public IActionResult Blog1()
        {
            return View();
        }
        [Route("blog2.html")]
        public IActionResult Blog2()
        {
            return View();
        }
        [Route("blog3.html")]
        public IActionResult Blog3()
        {
            return View();
        }
        [Route("blog4.html")]
        public IActionResult Blog4()
        {
            return View();
        }
    }

}
