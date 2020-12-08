using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DoAn_Ecommerce.Models
{
	public class TinTucModel
	{
		public int Id { get; set; }
		public string TieuDe { get; set; }
		public string TomTat { get; set; }
		public string NoiDung { get; set; }
		public DateTime NgayDang { get; set; }
		public int LuotXem { get; set; }
		public bool TrangThai { get; set; }
		public int NguoiDang { get; set; }
		public string HinhAnh { get; set; }

		[ForeignKey("NguoiDang")]
		public virtual NhanVienModel NhanVien { get;set; }
	}
}