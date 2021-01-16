using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DoAn_Ecommerce.Areas.Admin.Models
{
	public class TinTucModel
	{
		public int Id { get; set; }
		[Required]
		[MaxLength(32), MinLength(10)]
		public string TieuDe { get; set; }
		[Required]
		[MaxLength(100)]
		public string TomTat { get; set; }
		[Required]
		[MaxLength(255)]
		public string NoiDung { get; set; }
		public DateTime NgayDang { get; set; }
		public int LuotXem { get; set; }
		public bool TrangThai { get; set; }
		public int NguoiDang { get; set; }
		public string HinhAnh { get; set; }

		[ForeignKey("NguoiDang")]
		public virtual NguoiDungModel NhanVien { get;set; }
	}
}