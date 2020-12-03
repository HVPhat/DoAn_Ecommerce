using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DDoAn_Ecommerce.Models {
	public class KhachHangModel
	{
		public int Id { get; set; }
		public string TenKhachHang { get; set; }
		public string GioiTinh { get; set; }
		public DateTime NgaySinh { get; set; }
		public string Email { get; set; }
		public string MatKhau { get; set; }
		public char SDT { get; set; }
		public string DiaChi { get; set; }
	}
}
