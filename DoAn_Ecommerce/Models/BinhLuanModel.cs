using DoAn_Ecommerce.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DoAn_Ecommerce.Models
{
    public class BinhLuanModel
    {
        public int Id { get; set; }
        public int NguoiBinhLuan { get; set; }
        public string NoiDung { get; set; }
        public int SanPhamBinhLuan { get; set; }
        public bool TrangThai { get; set; }
        [ForeignKey("SanPhamBinhLuan")]
        public virtual SanPhamModel SanPham { get; set; }
        [ForeignKey("NguoiBinhLuan")]
        public virtual KhachHangModel KhachHang { set; get; }


    }
}
