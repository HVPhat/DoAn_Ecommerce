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
    [Route("Admin/api/TinTucApi")]
    [ApiController]
    public class TinTucApi : ControllerBase
    {
        private readonly DPContext _context;

        public TinTucApi(DPContext context)
        {
            _context = context;
        }
        [HttpGet("ChangeStates/{id}")]
        public async Task<ActionResult<TinTucModel>> ChangeStates(int id)
        {
            var tt = await _context.TinTuc.FindAsync(id);
            if (tt == null)
            {
                return NotFound();
            }
            try
            {
                tt.TrangThai = !tt.TrangThai;
                await _context.SaveChangesAsync();
                return tt;
            }
            catch (DbUpdateConcurrencyException)
            {
                throw;
            }
        }
    }
}


