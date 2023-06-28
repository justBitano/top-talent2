using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;
using TopTalentWebClient1.Models;

namespace TopTalentWebClient1.Controllers
{
    public class BookingTalentsController : Controller
    {
        private readonly TopTalent2Context _context;

        public BookingTalentsController(TopTalent2Context context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> Approved(int bookingId, int userId, int talentId)
        {
            var booking = _context.Bookings.SingleOrDefault(x => x.BookingId.Equals(bookingId) && x.UserId.Equals(userId)
            && x.TalentId.Equals(talentId) );

            if (booking != null)
            {
                booking.Status = 1;
                 _context.Update(booking);
                await _context.SaveChangesAsync();
                return RedirectToAction("Dashboard" , "Accounts");
            }
            return View(booking);
        }
        public async Task<IActionResult> Reject(int bookingId, int userId, int talentId)
        {
            var booking = _context.Bookings.SingleOrDefault(x => x.BookingId.Equals(bookingId) && x.UserId.Equals(userId)
            && x.TalentId.Equals(talentId));

            if (booking != null)
            {
                booking.Status = 6;
                _context.Update(booking);
                await _context.SaveChangesAsync();
                return RedirectToAction("Dashboard", "Accounts");
            }
            return View(booking);
        }
    }
}
