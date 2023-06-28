using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCoreHero.ToastNotification.Abstractions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TopTalentWebClient1.Models;

namespace TopTalentWebClient1.Controllers
{
    public class BookingsController : Controller
    {
        private readonly TopTalent2Context _context;
        public INotyfService _notifyService { get; }
        public BookingsController(TopTalent2Context context, INotyfService notyfService)
        {
            _context = context; 
            _notifyService = notyfService;
        }

        // GET: Bookings
        public async Task<IActionResult> Index()
        {
            var topTalent2Context = _context.Bookings.Include(b => b.Talent).Include(b => b.User);
            return View(await topTalent2Context.ToListAsync());
        }

        // GET: Bookings/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var booking = await _context.Bookings
                .Include(b => b.Talent)
                .Include(b => b.User)
                .FirstOrDefaultAsync(m => m.BookingId == id);
            if (booking == null)
            {
                return NotFound();
            }

            return View(booking);
        }

        // GET: Bookings/Create
        public IActionResult Create()
        {
            string fullName = Request.Query["fullName"];
            string price = Request.Query["price"];
            ViewBag.FullNameTalent = fullName;
            ViewBag.PriceTalent = price;
            ViewData["TalentId"] = new SelectList(_context.Talents, "TalentId", "FullName");
            ViewData["UserId"] = new SelectList(_context.Users, "UserId", "FullName");
            return View();
        }

        // POST: Bookings/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("BookingId,CreateDate,Cash,Description,Status,UserId,TalentId")] Booking booking, int id)
        {
            var userId = HttpContext.Session.GetInt32("UserId");
            if(userId == null)
            {
                return RedirectToAction("Login", "Accounts");
            }
            if (ModelState.IsValid)
            {
                booking.TalentId = id;
                booking.UserId = (int)userId;
                booking.Status = 0;
                _context.Add(booking);
                await _context.SaveChangesAsync();
                _notifyService.Success("Create Booking Success");
                return RedirectToAction("Dashboard", "Accounts");
            }
            var talent = _context.Talents.SingleOrDefault(x => x.TalentId.Equals(id));
            ViewData["TalentId"] = new SelectList(_context.Talents, "TalentId", "FullName", booking.TalentId);
            ViewData["UserId"] = new SelectList(_context.Users, "UserId", "FullName", booking.UserId);
            return View(booking);
        }

        // GET: Bookings/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var booking = await _context.Bookings.FindAsync(id);
            if (booking == null)
            {
                return NotFound();
            }
            ViewData["TalentId"] = new SelectList(_context.Talents, "TalentId", "FullName", booking.TalentId);
            ViewData["UserId"] = new SelectList(_context.Users, "UserId", "Password", booking.UserId);
            return View(booking);
        }

        // POST: Bookings/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("BookingId,CreateDate,Cash,Description,Status,UserId,TalentId")] Booking booking)
        {
            if (id != booking.BookingId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(booking);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BookingExists(booking.BookingId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["TalentId"] = new SelectList(_context.Talents, "TalentId", "FullName", booking.TalentId);
            ViewData["UserId"] = new SelectList(_context.Users, "UserId", "Password", booking.UserId);
            return View(booking);
        }

        // GET: Bookings/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var booking = await _context.Bookings
                .Include(b => b.Talent)
                .Include(b => b.User)
                .FirstOrDefaultAsync(m => m.BookingId == id);
            if (booking == null)
            {
                return NotFound();
            }

            return View(booking);
        }

        // POST: Bookings/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var booking = await _context.Bookings.FindAsync(id);
            _context.Bookings.Remove(booking);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BookingExists(int id)
        {
            return _context.Bookings.Any(e => e.BookingId == id);
        }


        public async Task<IActionResult> DirectPayment(int bookingId, int userId, int talentId, string talentName , string talentPrice)
        {
            string bookingId1 = Request.Query["bookingId"];
            string userId1 = Request.Query["userId"];
            string talentId1 = Request.Query["talentId"];
            string talentName1 = Request.Query["talentName"];
            string talentPrice1 = Request.Query["talentPrice"];
            ViewBag.BookingID = bookingId1;
            ViewBag.UserId = userId1;
            ViewBag.TalentId = talentId1;
            ViewBag.TalentPrice = talentPrice1;
            ViewBag.TalentFullname = talentName1;
            return View();
        }
        public async Task<IActionResult> Payment(int bookingId, int userId, int talentId)
        {
            var booking = _context.Bookings.SingleOrDefault(x => x.BookingId.Equals(bookingId) && x.UserId.Equals(userId)
           && x.TalentId.Equals(talentId));

            if (booking != null)
            {
                booking.Status = 3;
                _context.Update(booking);
                await _context.SaveChangesAsync();
                _notifyService.Success("Bạn vui lòng chờ check thanh toán nhé.");
                return RedirectToAction("Dashboard", "Accounts");
            }
            return View(booking);
        }
    }
}
