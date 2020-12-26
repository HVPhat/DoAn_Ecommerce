using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DoAn_Ecommerce.Areas.Admin.Data;
using DoAn_Ecommerce.Areas.Admin.Models;
using Microsoft.AspNetCore.Http;
using System.IO;

namespace DoAn_Ecommerce.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class TinTucController : Controller
    {
        private readonly DPContext _context;

        public TinTucController(DPContext context)
        {
            _context = context;
        }

        // GET: Admin/TinTuc
        public async Task<IActionResult> Index()
        {
            var dPContext = _context.TinTuc.Include(t => t.NhanVien);
            return View(await dPContext.ToListAsync());
        }

        // GET: Admin/TinTuc/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tinTucModel = await _context.TinTuc
                .Include(t => t.NhanVien)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tinTucModel == null)
            {
                return NotFound();
            }

            return View(tinTucModel);
        }

        // GET: Admin/TinTuc/Create
        public IActionResult Create()
        {
            ViewData["NguoiDang"] = new SelectList(_context.NguoiDung, "Id", "Id");
            return View();
        }

        // POST: Admin/TinTuc/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,TieuDe,TomTat,NoiDung,NgayDang,LuotXem,TrangThai,NguoiDang,HinhAnh")] TinTucModel tinTucModel,IFormFile ful)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tinTucModel);
                await _context.SaveChangesAsync();
                var path = Path.Combine(Directory.GetCurrentDirectory(),"wwwroot/images/pro",
                    tinTucModel.Id + "." + ful.FileName.Split(".")[ful.FileName.Split(".").Length - 1]);
                using (var stream = new  FileStream(path,FileMode.Create))
                {
                    await ful.CopyToAsync(stream);
                }
                tinTucModel.HinhAnh = tinTucModel.Id + "." + ful.FileName.Split(".")[ful.FileName.Split(".").Length - 1];
                _context.Update(tinTucModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["NguoiDang"] = new SelectList(_context.NguoiDung, "Id", "Id", tinTucModel.NguoiDang);
            return View(tinTucModel);
        }

        // GET: Admin/TinTuc/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tinTucModel = await _context.TinTuc.FindAsync(id);
            if (tinTucModel == null)
            {
                return NotFound();
            }
            ViewData["NguoiDang"] = new SelectList(_context.NguoiDung, "Id", "Id", tinTucModel.NguoiDang);
            return View(tinTucModel);
        }

        // POST: Admin/TinTuc/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,TieuDe,TomTat,NoiDung,NgayDang,LuotXem,TrangThai,NguoiDang,HinhAnh")] TinTucModel tinTucModel,IFormFile ful)
        {
            if (id != tinTucModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tinTucModel);
                    if (ful != null)//neu chon hinh moi
                    {
                        var path = Path.Combine(
                    Directory.GetCurrentDirectory(), "wwwroot/images/pro", tinTucModel.HinhAnh);
                        System.IO.File.Delete(path);//Xoa hinh cu
                                                    //them hinh moi
                        path = Path.Combine(
                   Directory.GetCurrentDirectory(), "wwwroot/images/pro", tinTucModel.Id + "." + ful.FileName.Split(".")
                   [ful.FileName.Split(".").Length - 1]);
                        using (var stream = new FileStream(path, FileMode.Create))
                        {
                            await ful.CopyToAsync(stream);
                        }
                        tinTucModel.HinhAnh = tinTucModel.Id + "." + ful.FileName.Split(".")[ful.FileName.Split(".").Length - 1];
                        //cap nhat du lieu                  
                        _context.Update(tinTucModel);
                    }
                    //cap nhat du lieu db
                    await _context.SaveChangesAsync();
                }


                catch (DbUpdateConcurrencyException)
                {
                    if (!TinTucModelExists(tinTucModel.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["NguoiDang"] = new SelectList(_context.NguoiDung, "Id", "Id", tinTucModel.NguoiDang);
            return View(tinTucModel);
        }

        // GET: Admin/TinTuc/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tinTucModel = await _context.TinTuc
                .Include(t => t.NhanVien)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tinTucModel == null)
            {
                return NotFound();
            }

            return View(tinTucModel);
        }

        // POST: Admin/TinTuc/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tinTucModel = await _context.TinTuc.FindAsync(id);
            _context.TinTuc.Remove(tinTucModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TinTucModelExists(int id)
        {
            return _context.TinTuc.Any(e => e.Id == id);
        }
    }
}
