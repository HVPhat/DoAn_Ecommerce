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
        [ForeignKey("NguoiBinhLuan")]
        public string NoiDung { get; set; }
        public int LstSanPham { get; set; }
        [ForeignKey("SanPham")]
        public bool TrangThai { get; set; }
        public virtual SanPhamModel SanPham { get; set };


    }
}
