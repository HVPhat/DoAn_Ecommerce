﻿using System;
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
    public class SanPhamController : Controller
    {
        private readonly DPContext _context;

        public SanPhamController(DPContext context)
        {
            _context = context;
        }

        // GET: Admin/SanPham
        public async Task<IActionResult> Index()
        {
            var dPContext = _context.SanPham.Include(s => s.LoaiSanPham);
            return View(await dPContext.ToListAsync());
        }

        // GET: Admin/SanPham/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sanPhamModel = await _context.SanPham
                .Include(s => s.LoaiSanPham)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (sanPhamModel == null)
            {
                return NotFound();
            }

            return View(sanPhamModel);
        }

        // GET: Admin/SanPham/Create
        public IActionResult Create()
        {
            ViewData["MaLoai"] = new SelectList(_context.LoaiSP, "Id", "TenLoai");
           //  return View();
          //  SanPhamModel sp = new SanPhamModel();
            return PartialView("_CreateSanPham");
        }

        // POST: Admin/SanPham/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,TenSanPham,HinhAnh,SoLuongTon,Gia,Mota,MaLoai,TrangThai")] SanPhamModel sanPhamModel , IFormFile ful)
        {
            if (ModelState.IsValid)
            {
                _context.Add(sanPhamModel);
                await _context.SaveChangesAsync();
                var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images/pro",
                    sanPhamModel.Id + "." + ful.FileName.Split(".")[ful.FileName.Split(".").Length - 1]);
                using (var stream = new FileStream(path, FileMode.Create))
                {
                    await ful.CopyToAsync(stream);
                }
                sanPhamModel.HinhAnh = sanPhamModel.Id + "." + ful.FileName.Split(".")[ful.FileName.Split(".").Length - 1];
                _context.Update(sanPhamModel);
                await _context.SaveChangesAsync();
                return PartialView("Thongbao");
            }
            
          
         //   ViewData["MaLoai"] = new SelectList(_context.LoaiSP, "Id", "Id", sanPhamModel.MaLoai);
            return View(sanPhamModel);
        }

        // GET: Admin/SanPham/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sanPhamModel = await _context.SanPham.FindAsync(id);
            if (sanPhamModel == null)
            {
                return NotFound();
            }
            ViewData["MaLoai"] = new SelectList(_context.LoaiSP, "Id", "TenLoai", sanPhamModel.MaLoai);
            return PartialView("_EditSanPham", sanPhamModel);
        }

        // POST: Admin/SanPham/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,TenSanPham,HinhAnh,SoLuongTon,Gia,Mota,MaLoai,TrangThai")] SanPhamModel sanPhamModel, IFormFile ful)
        {
            if (id != sanPhamModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(sanPhamModel);
                    if (ful != null)//neu chon hinh moi
                    {
                        var path = Path.Combine(
                    Directory.GetCurrentDirectory(), "wwwroot/images/pro", sanPhamModel.HinhAnh);
                        System.IO.File.Delete(path);//Xoa hinh cu
                                                    //them hinh moi
                        path = Path.Combine(
                   Directory.GetCurrentDirectory(), "wwwroot/images/pro", sanPhamModel.Id + "." + ful.FileName.Split(".")
                   [ful.FileName.Split(".").Length - 1]);
                        using (var stream = new FileStream(path, FileMode.Create))
                        {
                            await ful.CopyToAsync(stream);
                        }
                        sanPhamModel.HinhAnh = sanPhamModel.Id + "." + ful.FileName.Split(".")[ful.FileName.Split(".").Length - 1];
                        //cap nhat du lieu                  
                        _context.Update(sanPhamModel);
                    }
                    //cap nhat du lieu db
                    await _context.SaveChangesAsync();

                    
                    
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SanPhamModelExists(sanPhamModel.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return PartialView("Thongbao");
            }
            ViewData["MaLoai"] = new SelectList(_context.LoaiSP, "Id", "TenLoai", sanPhamModel.MaLoai);
            return PartialView("_EditSanPham", sanPhamModel);
        }

        // GET: Admin/SanPham/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sanPhamModel = await _context.SanPham
                .Include(s => s.LoaiSanPham)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (sanPhamModel == null)
            {
                return NotFound();
            }

            return PartialView("DeleteSanPham", sanPhamModel);
        }

        // POST: Admin/SanPham/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var sanPhamModel = await _context.SanPham.FindAsync(id);
            _context.SanPham.Remove(sanPhamModel);
            await _context.SaveChangesAsync();
            return PartialView("Thongbao");
        }

        private bool SanPhamModelExists(int id)
        {
            return _context.SanPham.Any(e => e.Id == id);
        }
    }
}
