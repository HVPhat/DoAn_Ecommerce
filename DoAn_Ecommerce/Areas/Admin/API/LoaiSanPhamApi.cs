using DoAn_Ecommerce.Areas.Admin.Data;
using DoAn_Ecommerce.Areas.Admin.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DoAn_Ecommerce.Areas.Admin.API
{
    [Route("Admin/api/LoaiSanPhamApi")]
    [ApiController]
    public class LoaiSanPhamApi : ControllerBase
    {
        private readonly DPContext _context;

        public LoaiSanPhamApi(DPContext context)
        {
            _context = context;
        }
        [HttpGet("ChangeState/{id}")]
        public async Task<ActionResult<LoaiSanPhamModel>> ChangeState (int id)
        {
            var user = await _context.LoaiSP.FindAsync(id);
            if (user == null)
            {
                return NotFound();
            }
            try
            {
                user.TrangThai = !user.TrangThai;
                await _context.SaveChangesAsync();
                return user;
            }
            catch (DbUpdateConcurrencyException)
            {
                throw;
            }
        }
    }
}

