using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace DoAn_Ecommerce.Areas.Admin.Controllers
{
    [Area("Admin")]

    public class AdminHomeController : Controller
    {
        
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Danhsach()
        {
            return View();
        }
        public IActionResult Them()
        {
            return View() ;
        }
    }
}
