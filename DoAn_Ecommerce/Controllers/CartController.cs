using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DoAn_Ecommerce.Areas.Admin.Data;
using DoAn_Ecommerce.Areas.Admin.Models;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DoAn_Ecommerce.Controllers
{
    public class CartController : Controller
    {
        private readonly DPContext _context;

        public CartController(DPContext context)
        {
            _context = context;
        }
        
        public IActionResult Index()
        {
            return View();
        }
    }
}
