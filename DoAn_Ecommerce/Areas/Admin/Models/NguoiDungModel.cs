using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace DoAn_Ecommerce.Areas.Admin.Models
{
    public class NguoiDungModel

    {
        public int Id { get; set; }

        public string TenNguoiDung { get; set; }

        public string NgaySinh { get; set; }
        public int GioiTinh { get; set; }
        public string Email { get; set; }
        public string MatKhau { get; set; }
        public string SDT { get; set; }
        public string DiaChi { get; set; }
        public bool TrangThai { get; set; }
        public int QuyenHan { get; set; }
        public ICollection<TinTucModel> lstTinTuc { get; set; }
        public ICollection<BinhLuanModel> lstBinhLuan { get; set; }
        public ICollection<HoaDonModel> lstHoaDon { get; set; }

    }
}