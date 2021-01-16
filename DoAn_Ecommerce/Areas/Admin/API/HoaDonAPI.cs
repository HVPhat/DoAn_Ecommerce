using DoAn_Ecommerce.Areas.Admin.Data;
using DoAn_Ecommerce.Areas.Admin.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DoAn_Ecommerce.Areas.Admin.API
{
    [Route("Admin/api/HoaDonAPI")]
    [ApiController]
    public class HoaDonAPI : ControllerBase
    {
        private readonly DPContext _context;

        public HoaDonAPI(DPContext context)
        {
            _context = context;
        }
        [HttpGet("ChangeUserState/{id}")]
        public async Task<ActionResult<HoaDonModel>> ChangeUserState(int id)
        {
            var hoadon = await _context.HoaDon.FindAsync(id);
            if (hoadon == null)
            {
                return NotFound();
            }
            try
            {
                hoadon.TrangThai = !hoadon.TrangThai;
                await _context.SaveChangesAsync();
                return hoadon;
            }
            catch (DbUpdateConcurrencyException)
            {
                throw;
            }
        }
    }
}
