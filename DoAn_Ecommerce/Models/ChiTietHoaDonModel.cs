﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DoAn_Ecommerce.Models
{
    public class ChiTietHoaDonModel
    {
        [Key, Column(Order = 0)]
        public int HoaDon { get; set; }
        [Key, Column(Order = 1)]
        public int SanPham { get; set; }
        public int SoLuongMua { get; set; }
        public decimal DonGia { get; set; }
        public decimal ThanhTien { get; set; }
        [ForeignKey("SanPham")]
        public virtual SanPhamModel SP { set; get; }
        [ForeignKey("HoaDon")]
        public virtual HoaDonModel HD { set; get; }
    }
}
