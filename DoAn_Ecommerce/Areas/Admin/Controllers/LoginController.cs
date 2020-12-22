using DoAn_Ecommerce.Areas.Admin.Data;
using DoAn_Ecommerce.Areas.Admin.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DoAn_Ecommerce.Areas.Admin.Controllers
{

    [Area("Admin")]
    public class LoginController : Controller
    {
        private DPContext _context;
        public LoginController(DPContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Login([Bind("Email, MatKhau")] NguoiDungModel nguoiDung)
        {
            var r = _context.NguoiDung.Where(m => (m.Email == nguoiDung.Email && m.MatKhau
            == HashString.CreateMD5Hash(nguoiDung.MatKhau))).ToList();
            if (r.Count == 0)
            {
                return View("Index");
            }
            //var str = JsonConvert.SerializeObject(nguoiDung);
            //HttpContext.Session.SetString("user", str);
            //Quyen han = 0 la admin
            if (r[0].QuyenHan == 0)
            {
                var url = Url.RouteUrl("Admin", new { controller = "AdminHomeController", action = "Index", area = "Admin" });
                return RedirectToAction("Index", "AdminHome", new { area = "Admin" });
            }
            return RedirectToAction("Index", "Login");
        }
    }
}
