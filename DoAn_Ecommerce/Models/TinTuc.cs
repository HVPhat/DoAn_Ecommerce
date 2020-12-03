using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
namespace DoAn_Ecommerce.Models
{
    public class TinTuc
    {
        [Key]
        public int Id { set; get; }

        public string TieuDe { set; get; }

        public string TomTat { set; get; }

        public string NoiDung { set; get; }

        public string HinhAnh { get; set; }
        public string NgayViet { get; set; }

        public int LuotXem { get; set; }

        public bool TrangThai { get; set; }

        public int NhanVien { get; set; }

        [ForeignKey("NhanVien")]

        public virtual NhanVien NhanVien { get; set; }
    }
}
