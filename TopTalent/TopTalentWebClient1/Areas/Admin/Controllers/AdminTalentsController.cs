using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCoreHero.ToastNotification.Abstractions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PagedList.Core;
using TopTalentWebClient1.Models;

namespace TopTalentWebClient1.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AdminTalentsController : Controller
    {
        private readonly TopTalent2Context _context;
        public INotyfService _notifyService { get; }
        public AdminTalentsController(TopTalent2Context context, INotyfService notifyService)
        {
            _context = context;
            _notifyService=notifyService;
        }
        
        // GET: Admin/AdminTalents
        public async Task<IActionResult> Index(int? page)
        {
            //Pagginggg
            var pageNumber = page == null || page < 0 ? 1 : page.Value;
            var pageSize = 5;
            var lsTalents = _context.Talents.AsNoTracking()
                .OrderByDescending(x => x.TalentId);
            PagedList<Talent> models = new PagedList<Talent>(lsTalents, pageNumber, pageSize);
            ViewBag.CurrentPage = pageNumber;
            //Filter
            List<SelectListItem> lsJobTitle = new List<SelectListItem>();
            List<SelectListItem> lsStatus = new List<SelectListItem>();
            lsStatus.Add(new SelectListItem()
            {
                Text="In Active",
                Value = "0"
            });
            lsStatus.Add(new SelectListItem()
            {
                Text="Block",
                Value = "1"
            });
            lsJobTitle.Add(new SelectListItem()
            {
                Text="Streamer",
                Value = "Streamer"
            });
            lsJobTitle.Add(new SelectListItem()
            {
                Text="TikTok",
                Value = "TikTok"
            });
            lsJobTitle.Add(new SelectListItem()
            {
                Text="Youtuber",
                Value = "Youtuber"
            });
            lsJobTitle.Add(new SelectListItem()
            {
                Text="KOL",
                Value = "KOL"
            });
            lsJobTitle.Add(new SelectListItem()
            {
                Text="Actor",
                Value = "Actor"
            });
            ViewData["lsJobTitle"] = lsJobTitle;
            ViewData["lsStatus"] = lsStatus;
            return View(models);
            /*return View(await _context.Talents.ToListAsync());*/
        }
        //GET: Admin/AdminPages
        // GET: Admin/AdminTalents/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var talent = await _context.Talents
                .FirstOrDefaultAsync(m => m.TalentId == id);
            if (talent == null)
            {
                return NotFound();
            }

            return View(talent);
        }

        // GET: Admin/AdminTalents/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/AdminTalents/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("TalentId,Username,Password,FullName,Phone,Address,JobTitle,Price,Image,Description,Status")] Talent talent)
        {
            if (ModelState.IsValid)
            {
                _context.Add(talent);
                await _context.SaveChangesAsync();
                _notifyService.Success("Tạo mới thành công");
                return RedirectToAction(nameof(Index));
            }
            return View(talent);
        }

        // GET: Admin/AdminTalents/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var talent = await _context.Talents.FindAsync(id);
            if (talent == null)
            {
                return NotFound();
            }
            return View(talent);
        }

        // POST: Admin/AdminTalents/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("TalentId,Username,Password,FullName,Phone,Address,JobTitle,Price,Image,Description,Status")] Talent talent)
        {
            if (id != talent.TalentId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(talent);
                    await _context.SaveChangesAsync();
                    _notifyService.Success("Cập nhập thành công");
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TalentExists(talent.TalentId))
                    {
                        _notifyService.Success("Có lỗi xãy ra");
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(talent);
        }

        // GET: Admin/AdminTalents/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var talent = await _context.Talents
                .FirstOrDefaultAsync(m => m.TalentId == id);
            if (talent == null)
            {
                return NotFound();
            }

            return View(talent);
        }

        // POST: Admin/AdminTalents/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var talent = await _context.Talents.FindAsync(id);
            _context.Talents.Remove(talent);
            await _context.SaveChangesAsync();
            _notifyService.Success("Xóa thành công");
            return RedirectToAction(nameof(Index));
        }

        private bool TalentExists(int id)
        {
            return _context.Talents.Any(e => e.TalentId == id);
        }
    }
}
