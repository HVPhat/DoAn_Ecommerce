using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DoAn_Ecommerce.Areas.Admin.Models
{
    public class NguoiDungModel

    {
        public int Id { get; set; }
        [Required]
        public string TenNguoiDung { get; set; }
        [Required]
        public string NgaySinh { get; set; }
        [Required]
        public int GioiTinh { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string MatKhau { get; set; }
        [Required]
        public string SDT { get; set; }
        [Required]
        public string DiaChi { get; set; }
        [Required]
        public bool TrangThai { get; set; }
        [Required]
        public int QuyenHan { get; set; }
        public ICollection<TinTucModel> lstTinTuc { get; set; }
        public ICollection<BinhLuanModel> lstBinhLuan { get; set; }
        public ICollection<HoaDonModel> lstHoaDon { get; set; }

    }
}