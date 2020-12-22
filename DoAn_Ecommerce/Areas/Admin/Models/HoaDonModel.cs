using DoAn_Ecommerce.Areas.Admin.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DoAn_Ecommerce.Areas.Admin.Models
{
    public class HoaDonModel
    {
        public int Id { get; set; }
        public int KhachHang { get; set; }
        public DateTime NgayLapHD { get; set; }
        public int TrangThaiGiaoHang { get; set; }
        public bool TrangThai { set; get; }
        [ForeignKey("KhachHang")]
        public virtual NguoiDungModel KH { set; get; }
        public ICollection<ChiTietHoaDonModel> lstCTHD { set; get; }
    }
}
