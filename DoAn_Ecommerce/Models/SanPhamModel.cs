﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DoAn_Ecommerce.Models
{
    public class SanPhamModel
    {
        public int Id { set; get; }
        
        public string TenSanPham { set; get; }

        public string HinhAnh { set; get; }

        public int SoLuongTon { set; get; }

        public decimal Gia { set; get; }
        public string Mota { set; get; }
        public int MaLoai { set; get; }
        public bool TrangThai { get; set; }
        [ForeignKey("MaLoai")]
        public virtual LoaiSanPhamModel LoaiSanPham { set; get; }

        public ICollection<BinhLuanModel> lstBinhLuan { set; get; }
        public ICollection<ChiTietHoaDonModel> lstCTHD { set; get; }
    }
}
