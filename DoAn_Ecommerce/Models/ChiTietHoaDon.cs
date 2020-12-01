using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DoAn_Ecommerce.Models
{
    public class ChiTietHoaDon
    {
        public int HoaDon { get; set; }
        public int SanPham { get; set; }
        public int SoLuongMua { get; set; }
        public decimal DonGia { get; set; }
        public decimal ThanhTien { get; set; }
    }
}
