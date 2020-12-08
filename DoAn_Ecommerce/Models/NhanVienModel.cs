using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace DoAn_Ecommerce.Models
{
    public class NhanVienModel

    {
        public int Id { get; set; }

        public string TenNhanVien { get; set; }

        public string NgaySinh { get; set; }
        public int GioiTinh { get; set; }
        public string Email { get; set; }
        public string MatKhau { get; set; }
        public bool TrangThai { get; set; }
        public int QuyenHan { get; set; }
        [ForeignKey("QuyenHan")]
        public virtual QuyenModel Quyen { get; set; }
        public ICollection<TinTucModel> lstTinTuc { get; set; }

    }
}