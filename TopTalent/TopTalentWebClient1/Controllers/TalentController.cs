using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PagedList.Core;
using System.Linq;
using TopTalentWebClient1.Models;

namespace TopTalentWebClient1.Controllers
{
    public class TalentController : Controller
    {
        private readonly TopTalent2Context _context;
        public TalentController(TopTalent2Context context)
        {
            _context = context;
        }
        [Route("listTalent.html", Name = "BookingTalent")]
        public IActionResult Index(int? page)
        {
            try
            {
                var pageNumber = page == null || page <= 0 ? 1 : page.Value;
                var pageSize = 8;
                var lsTalent = _context.Talents
                    .AsNoTracking()
                    .OrderByDescending(x => x.JobTitle)
                    .Where(x => x.Status == 0);


                PagedList<Talent> models = new PagedList<Talent>(lsTalent, pageNumber, pageSize);
                ViewBag.CurrentPage = pageNumber;
                return View(models);
            }
            catch
            {
                return RedirectToAction("Index", "Home");
            }


        }
        /*        [Route("/{JobTitle}", Name ="ListTalent")]
                public IActionResult List(string JobTitle,int page=1)
                {
                    try
                    {
                        var pageSize = 8;
                        var title = _context.Talents.AsNoTracking().SingleOrDefault( x => x.JobTitle == JobTitle );
                        var lsTalent = _context.Talents
                            .AsNoTracking()
                            .OrderByDescending(x => x.JobTitle);
                        PagedList<Talent> models = new PagedList<Talent>(lsTalent, page, pageSize);
                        ViewBag.CurrentPage = page;
                        ViewBag.CurrentJob = title;
                        return View(models);
                    }
                    catch
                    {
                        return RedirectToAction("Index", "Home");
                    }

                }*/
        [Route("/{fullname}--{id}.html", Name = "TalentDetails")]
        public IActionResult Details(int id)
        {
            try
            {
                var talent = _context.Talents.Include(x => x.Bookings).FirstOrDefault(x => x.TalentId == id);
                if (talent == null)
                {
                    return RedirectToAction("Index");
                }

                var lsTalent = _context.Talents.AsNoTracking()
                    .Where(x => x.TalentId != id && x.Status == 0)
                    .OrderByDescending(x => x.JobTitle)
                    .Take(4)
                    .ToList();
                ViewBag.TalentKhac = lsTalent;
                return View(talent);

            }
            catch
            {
                return RedirectToAction("Index", "Home");
            }
        }

    }
}
