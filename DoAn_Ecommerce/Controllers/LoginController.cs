using DoAn_Ecommerce.Areas.Admin.Data;
using DoAn_Ecommerce.Areas.Admin.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DoAn_Ecommerce.Controllers
{
    public class LoginController : Controller
    {
        private readonly DPContext _context;
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
        public IActionResult Login([Bind("Email, MatKhau")] NguoiDungModel member)
        {
            if (member.Email != null && member.MatKhau != null)
            {
                var r = _context.NguoiDung.Where(m => (m.Email == member.Email && m.MatKhau
                == HashString.CreateMD5Hash(member.MatKhau))).ToList();

                if (r.Count == 0)
                {
                    ViewBag.error = "Login failed !";
                    return View("Index");
                }
                var str = JsonConvert.SerializeObject(r[0]);
                HttpContext.Session.SetString("user", str);
                if (r[0].QuyenHan == 1)
                {
                    var url = Url.RouteUrl("Admin", new { controller = "AdminHome", action = "Index", area = "Admin" });
                    return Redirect(url);
                }
                else
                {
                    var url = Url.RouteUrl("default", new { controller = "Home", action = "Index" });
                    return Redirect(url);
                }
            }
            ViewBag.error = "Please enter email and password !";
            return View("Index");
        }
    }
}
