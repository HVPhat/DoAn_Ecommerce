using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DoAn_Ecommerce.Models
{
    public class QuyenModel
    {
        public int Id { get; set; }
        public string TenQuyen { get; set; }
        public bool TrangThai { get; set; }
        public ICollection<NhanVienModel> lstNhanVien { get; set; }
     }
}
