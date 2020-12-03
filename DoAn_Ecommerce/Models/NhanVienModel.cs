using System.ComponentModel.DataAnnotations.Schema;

namespace DoAn_Ecommerce.Models
{
    public class NhanVienModel

    {
        public int Id { get; set; }

        public string TenNhanVien { get; set; }

        public string NgaySinh { get; set; }
        public string GioiTinh { get; set; }
        public string Email { get; set; }
        public string PassWord { get; set; }
        public int QuyenHan { get; set; }
        [ForeignKey("Quyen")]
        public virtual Quyen Quyen { get; set; }
    }
}