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
		public int id { get; set; }
		public string TieuDe { get; set; }
		public string TomTat { get; set; }
		public string NoiDung { get; set; }
		public DateTime NgayViet { get; set; }
		public int LuotXem { get; set; }
		public bool TrangThai { get; set; }
		public int id_NhanVien { get; set; }
		[ForeignKey("id_NhanVien")]
		public string HinhAnh { get; set; }
		public ICollection<NhanVienModel> lstNhanVien { get; set; }
		public virtual NhanVienModel NhanVien { get;set; }
	}
}