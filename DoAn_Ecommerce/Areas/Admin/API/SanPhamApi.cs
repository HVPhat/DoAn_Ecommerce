using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DoAn_Ecommerce.Areas.Admin.Data;
using DoAn_Ecommerce.Areas.Admin.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DoAn_Ecommerce.Areas.Admin.API
{
    [Route("Admin/api/SanPhamApi")]
    [ApiController]
    public class SanPhamApi : ControllerBase
    {
        private readonly DPContext _context;

        public SanPhamApi(DPContext context)
        {
            _context = context;
        }
        [HttpGet("thaydoi/{id}")]
        public async Task<ActionResult<SanPhamModel>> thaydoi(int id)
        {
            var sanpham = await _context.SanPham.FindAsync(id);
            if (sanpham == null)
            {
                return NotFound();
            }
            try
            {
                sanpham.TrangThai = !sanpham.TrangThai;
                await _context.SaveChangesAsync();
                return sanpham;
            }
            catch (DbUpdateConcurrencyException)
            {
                throw;
            }
        }
    }
}

    