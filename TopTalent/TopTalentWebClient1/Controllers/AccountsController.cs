using AspNetCoreHero.ToastNotification.Abstractions;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using TopTalentWebClient1.Models;
using TopTalentWebClient1.ModelView;

namespace TopTalentWebClient1.Controllers
{

    public class AccountsController : Controller
    {
        private readonly TopTalent2Context _context;
        public INotyfService _notifyService { get; }
        public AccountsController(TopTalent2Context context, INotyfService notyfService)
        {
            _context = context;
            _notifyService = notyfService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login(LoginViewModel model)
        {
            var user = _context.Users.SingleOrDefault(x => x.Username == model.Username && x.Password == model.Password);
            var talent = _context.Talents.SingleOrDefault(x => x.Username == model.Username && x.Password == model.Password);

            if (model.Username == "admin" && model.Password == "admin@@123")
            {
                _notifyService.Success("Đăng nhập  admin thành công");
                return RedirectToAction("Index", "AdminUsers", new { Area = "Admin" });
            }
            if (user != null)
            {

                HttpContext.Session.SetInt32("UserId", user.UserId);
                _notifyService.Success("Đăng nhập  User thành công");
                return RedirectToAction("Index", "Home");
            }
            if (talent != null)
            {
                HttpContext.Session.SetInt32("TalentId", talent.TalentId);
                _notifyService.Success("Đăng nhập  Talent thành công");
                return RedirectToAction("Index", "Home");
            }
            if (user == null && talent == null) _notifyService.Error("UserName hoặc Password không chính xác");

            return View();
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(AccountViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = _context.Users.SingleOrDefault(u => u.Username == model.Username);
                if (user == null)
                {
                    User user1 = new User
                    {
                        Username= model.Username,
                        Password = model.Password,
                        FullName= model.FullName,
                        Description= model.Description,
                        Phone= model.Phone,
                        Image  = model.Image,
                        Status = null
                    };
                    _context.Users.Add(user1);
                    _context.SaveChanges();
                    HttpContext.Session.SetInt32("UserId", user1.UserId);
                    _notifyService.Success("Tạo tài khoản thành công");
                    return RedirectToAction("Login", "Accounts");
                }

            }
            _notifyService.Error("tài khoản đã tồn tại");
            return View(model);
        }

        [HttpGet]
        public IActionResult RegisterTalent()
        {
            return View();
        }

        [HttpPost]
        public IActionResult RegisterTalent(TalentVM model)
        {
            if (ModelState.IsValid)
            {
                var talent = _context.Talents.SingleOrDefault(u => u.Username == model.Username);
                if (talent == null)
                {
                    Talent talent1 = new Talent
                    {
                        Username = model.Username,
                        Password = model.Password,
                        FullName = model.FullName,
                        Description = model.Description,
                        Phone = model.Phone,
                        Image = model.Image,
                        JobTitle= model.JobTitle,
                        Price= model.Price,
                        Address = model.Address,
                        Status = null
                    };
                    _context.Talents.Add(talent1);
                    _context.SaveChanges();
                    HttpContext.Session.SetInt32("TalentId", talent1.TalentId);
                    _notifyService.Success("Tạo tài khoản thành công");
                    return RedirectToAction("Login", "Accounts");
                }

            }
            _notifyService.Error("tài khoản đã tồn tại");
            return View(model);
        }

        public IActionResult Dashboard()
        {
            var taikhoanID = HttpContext.Session.GetInt32("UserId");
            var taikhoanTalent = HttpContext.Session.GetInt32("TalentId");
            if (taikhoanID != null)
            {
                var khachhang = _context.Users.SingleOrDefault(x => x.UserId.Equals(taikhoanID));
                if (khachhang != null)
                {
                    var listBooking = _context.Bookings
                        .Include(t => t.Talent)
                        .Include(u => u.User)
                        .AsNoTracking()
                        .Where(x => x.UserId == khachhang.UserId)
                        .OrderByDescending(x => x.CreateDate).ToList();
                    ViewBag.listBooking = listBooking;
                    return View(khachhang);
                }
            }
            if (taikhoanTalent != null)
            {
                var talent = _context.Talents.SingleOrDefault(x => x.TalentId.Equals(taikhoanTalent));
                if (talent != null)
                {
                    var listBookingTalent = _context.Bookings
                        .Include(t => t.User)
                        .Include(y => y.Talent)
                        .AsNoTracking()
                        .Where(x => x.TalentId == talent.TalentId)
                        .OrderByDescending(x => x.CreateDate).ToList();
                    ViewBag.listBookingTalent = listBookingTalent;
                    return View(talent);
                }
            }

            return RedirectToAction("Dashboard");
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Remove("UserId");
            HttpContext.Session.Remove("TalentId");
            return RedirectToAction("Index", "Home");
        }
        public IActionResult Options()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Edit(TalentVM talent, UserVM user)
        {
            try
            {
                var taikhoanID = HttpContext.Session.GetInt32("UserId");
                var talentID = HttpContext.Session.GetInt32("TalentId");

                var talent1 = _context.Talents.SingleOrDefault(x => x.TalentId.Equals(talentID));
                var user1 = _context.Users.SingleOrDefault(x => x.UserId.Equals(taikhoanID));
                if (talent1 != null)
                {
                    talent1 = new Talent
                    {
                        Username = talent.Username,
                        FullName = talent.FullName,
                        Phone = talent.Phone,
                        Description = talent.Description,
                        Address = talent.Address,
                        JobTitle = talent.JobTitle,
                        Price = talent.Price,
                        Image = talent.Image,

                    };
                    _context.Talents.Update(talent1);
                    _context.SaveChanges();
                    _notifyService.Success("Update Talent Success");
                }
                if (user1 != null)
                {
                    user1 = new User
                    {
                        Username = talent.Username,
                        FullName = talent.FullName,
                        Phone = talent.Phone,
                        Description = talent.Description,
                        Image = talent.Image,
                    };
                    _context.Users.Update(user1);
                    _context.SaveChanges();
                    _notifyService.Success("Update User Success");
                }


            }
            catch
            {
                return RedirectToAction("Dashboard", "Accounts");
            }
            _notifyService.Success("Edit thành công");
            return RedirectToAction("Dashboard", "Accounts");
        }

        [HttpPost]
        public IActionResult ChangePassword(ChangePasswordViewModel model)
        {
            try
            {
                var taikhoanID = HttpContext.Session.GetInt32("UserId");
                var talentID = HttpContext.Session.GetInt32("TalentId");


                var taikhoan = _context.Users.SingleOrDefault(x => x.UserId.Equals(taikhoanID));
                var talent = _context.Talents.SingleOrDefault(t => t.TalentId.Equals(talentID));



                var pass = model.PasswordNow;
                if (pass == taikhoan.Password)
                {
                    string passnew = model.Password;
                    taikhoan.Password = passnew;
                    _context.Users.Update(taikhoan);
                    _context.SaveChanges();
                    _notifyService.Success("Change User Password Success");
                    return RedirectToAction("Dashboard", "Accounts");
                }
                if (pass == talent.Password)
                {
                    string passnew = model.Password;
                    talent.Password = passnew;
                    _context.Talents.Update(talent);
                    _context.SaveChanges();
                    _notifyService.Success("Change Talent Password Success");
                    return RedirectToAction("Dashboard", "Accounts");
                }
            }
            catch
            {
                return RedirectToAction("Dashboard", "Accounts");
            }
            _notifyService.Success("Thay đổi mật khẩu không thành công");
            return RedirectToAction("Dashboard", "Accounts");
        }
    }
}
