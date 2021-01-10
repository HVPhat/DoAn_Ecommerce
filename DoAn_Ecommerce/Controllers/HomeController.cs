using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using DoAn_Ecommerce.Areas.Admin.Models;
using DoAn_Ecommerce.Areas.Admin.Data;
using Microsoft.EntityFrameworkCore;
using System.Dynamic;

namespace DoAn_Ecommerce.Controllers
{
    public class HomeController : Controller
    {
        /*  private readonly ILogger<HomeController> _logger;

          public HomeController(ILogger<HomeController> logger)
          {
              _logger = logger;
          }
        */
        private readonly DPContext _context;

        public HomeController(DPContext context)
        {
            _context = context;
        }

      
        public async Task<IActionResult> Index()
        {
            dynamic Model = new ExpandoObject();
            Model.SanPham = _context.SanPham.Include(p => p.LoaiSanPham);
            Model.TinTuc = _context.TinTuc.OrderByDescending(x => x.Id).Take(1);
            Model.LoaiSanPham = _context.LoaiSP.Include(t => t.ltsSanPham);
            return View(Model);
        }

        
        //public IActionResult Shop()
        //{
        //    return View();
        //}
        public IActionResult Cart()
        {
            return View();
        }
        public IActionResult About()
        {
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }
        public IActionResult Checkout()
        {
            return View();
        }
        public IActionResult Thankyou()
        {
            return View();
        }
        public IActionResult ShopSingle()
        {
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
