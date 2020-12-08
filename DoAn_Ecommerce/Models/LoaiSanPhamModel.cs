using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DoAn_Ecommerce.Models
{
    public class LoaiSanPhamModel
    {
        public int Id { get; set; }
        public string TenLoai { get; set; }
        public bool TrangThai { get; set; }
        public ICollection<SanPhamModel> ltsSanPham { get; set; }
    }
}
