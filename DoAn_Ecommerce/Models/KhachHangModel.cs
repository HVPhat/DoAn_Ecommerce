using DoAn_Ecommerce.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DoAn_Ecommerce.Models {
	public class KhachHangModel
	{
		public int Id { get; set; }
		public string TenKhachHang { get; set; }
		public int GioiTinh { get; set; }
		public DateTime NgaySinh { get; set; }
		public string Email { get; set; }
		public string MatKhau { get; set; }
		public string SDT { get; set; }
		public string DiaChi { get; set; }
		public bool TrangThai { get; set; }
		public ICollection<BinhLuanModel> lstBinhLuan { get; set; }
		public ICollection<HoaDonModel> lstHoaDon { get; set; }
	}
}
