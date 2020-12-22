﻿using System;
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
    public class NguoiDungController : Controller
    {
        private readonly DPContext _context;

        public NguoiDungController(DPContext context)
        {
            _context = context;
        }

        // GET: Admin/NguoiDung
        public async Task<IActionResult> Index()
        {
            return View(await _context.NguoiDung.ToListAsync());
        }

        // GET: Admin/NguoiDung/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nguoiDungModel = await _context.NguoiDung
                .FirstOrDefaultAsync(m => m.Id == id);
            if (nguoiDungModel == null)
            {
                return NotFound();
            }

            return View(nguoiDungModel);
        }

        // GET: Admin/NguoiDung/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/NguoiDung/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,TenNguoiDung,NgaySinh,GioiTinh,Email,MatKhau,SDT,DiaChi,TrangThai,QuyenHan")] NguoiDungModel nguoiDungModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(nguoiDungModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(nguoiDungModel);
        }

        // GET: Admin/NguoiDung/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nguoiDungModel = await _context.NguoiDung.FindAsync(id);
            if (nguoiDungModel == null)
            {
                return NotFound();
            }
            return View(nguoiDungModel);
        }

        // POST: Admin/NguoiDung/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,TenNguoiDung,NgaySinh,GioiTinh,Email,MatKhau,SDT,DiaChi,TrangThai,QuyenHan")] NguoiDungModel nguoiDungModel)
        {
            if (id != nguoiDungModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(nguoiDungModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!NguoiDungModelExists(nguoiDungModel.Id))
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
            return View(nguoiDungModel);
        }

        // GET: Admin/NguoiDung/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nguoiDungModel = await _context.NguoiDung
                .FirstOrDefaultAsync(m => m.Id == id);
            if (nguoiDungModel == null)
            {
                return NotFound();
            }

            return View(nguoiDungModel);
        }

        // POST: Admin/NguoiDung/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var nguoiDungModel = await _context.NguoiDung.FindAsync(id);
            _context.NguoiDung.Remove(nguoiDungModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool NguoiDungModelExists(int id)
        {
            return _context.NguoiDung.Any(e => e.Id == id);
        }
    }
}
