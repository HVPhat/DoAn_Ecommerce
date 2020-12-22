using DoAn_Ecommerce.Areas.Admin.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DoAn_Ecommerce.Areas.Admin.Data
{
    public class DPContext : DbContext
    {
        public DPContext(DbContextOptions<DPContext> option)
            : base(option)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ChiTietHoaDonModel>()
                .HasKey(c => new { c.HoaDon, c.SanPham });
        }
        public DbSet<BinhLuanModel> BinhLuan { get; set; }
        public DbSet<NguoiDungModel> NguoiDung { get; set; }
        public DbSet<TinTucModel> TinTuc { get; set; }
        public DbSet<LoaiSanPhamModel> LoaiSP { get; set; }
        public DbSet<HoaDonModel> HoaDon { get; set; }
        public DbSet<SanPhamModel> SanPham { get; set; }
        public DbSet<ChiTietHoaDonModel> ChiTietHoaDon { get; set; }

    }
}
