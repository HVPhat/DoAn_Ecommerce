using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DoAn_Ecommerce.Areas.Admin.Data;
using DoAn_Ecommerce.Areas.Admin.Models;

namespace DoAn_Ecommerce.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class LoaiSanPhamController : Controller
    {
        private readonly DPContext _context;

        public LoaiSanPhamController(DPContext context)
        {
            _context = context;
        }

        // GET: Admin/LoaiSanPham
        public async Task<IActionResult> Index()
        {
            var dPContext = _context.LoaiSP.Include(t => t.ltsSanPham);
            return View(await dPContext.ToListAsync());
        }

        // GET: Admin/LoaiSanPham/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var loaiSanPhamModel = await _context.LoaiSP
                .FirstOrDefaultAsync(m => m.Id == id);
            if (loaiSanPhamModel == null)
            {
                return NotFound();
            }

            return View(loaiSanPhamModel);
        }

        // GET: Admin/LoaiSanPham/Create
        public IActionResult Create()
        {
            LoaiSanPhamModel LSP = new LoaiSanPhamModel();
            return PartialView("_CreateModalPartial", LSP);
        }

        // POST: Admin/LoaiSanPham/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,TenLoai,TrangThai")] LoaiSanPhamModel loaiSanPhamModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(loaiSanPhamModel);
                await _context.SaveChangesAsync();
                return PartialView("_ActionSuccessPartial");
            }
            ViewData["TenLoai"] = new SelectList(_context.LoaiSP, "Id", "Id" , loaiSanPhamModel.TenLoai);
            return PartialView("_CreateModalPartial",loaiSanPhamModel);
        }

        // GET: Admin/LoaiSanPham/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var loaiSanPhamModel = await _context.LoaiSP.FindAsync(id);
            if (loaiSanPhamModel == null)
            {
                return NotFound();
            }
            ViewData["TenLoai"] = new SelectList(_context.LoaiSP, "Id", "Id", loaiSanPhamModel.TenLoai);
            return PartialView("_EditModalPartial", loaiSanPhamModel);
        }

        // POST: Admin/LoaiSanPham/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,TenLoai,TrangThai")] LoaiSanPhamModel loaiSanPhamModel)
        {
            if (id != loaiSanPhamModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(loaiSanPhamModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LoaiSanPhamModelExists(loaiSanPhamModel.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }                   
                }
                return PartialView("_ActionSuccessPartial");
            }
            return PartialView("_EditModalPartial", loaiSanPhamModel);
        }

        // GET: Admin/LoaiSanPham/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var loaiSanPhamModel = await _context.LoaiSP
                .FirstOrDefaultAsync(m => m.Id == id);
            if (loaiSanPhamModel == null)
            {
                return NotFound();
            }

            return PartialView("_DeleteModalPartial", loaiSanPhamModel);
        }

        // POST: Admin/LoaiSanPham/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var loaiSanPhamModel = await _context.LoaiSP.FindAsync(id);
            _context.LoaiSP.Remove(loaiSanPhamModel);
            await _context.SaveChangesAsync();
            return PartialView("_ActionSuccessPartial");
        }

        private bool LoaiSanPhamModelExists(int id)
        {
            return _context.LoaiSP.Any(e => e.Id == id);
        }
    }
}
