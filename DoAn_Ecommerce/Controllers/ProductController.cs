using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;
using DoAn_Ecommerce.Areas.Admin.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DoAn_Ecommerce.Controllers
{
    public class ProductController : Controller
    {
        private readonly DPContext _context;

        public ProductController(DPContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Shop()
        {
            dynamic Model = new ExpandoObject();

            Model.SanPham = _context.SanPham.Include(p => p.LoaiSanPham);
            return View(Model);
        }
        public async Task<IActionResult> ShopSingle(int id)
        {
            var item = _context.SanPham.SingleOrDefault(hh => hh.Id == id );
            if (item != null)
            {
                return View(item);
            }

            return RedirectToAction("Shop");
        }
    }
}
