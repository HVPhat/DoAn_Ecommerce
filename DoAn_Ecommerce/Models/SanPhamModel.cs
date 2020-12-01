using System;
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

       public string NoiDung { set; get; }
        public int id_LoaiSanPham { set; get; }
        [ForeignKey("id_LoaiSanPham")]
        public virtual LoaiSanPhamModel LoaiSanPham { set; get; }
    }
}
