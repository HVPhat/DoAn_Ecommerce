using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DoAn_Ecommerce.Models
{
    public class Quyen
    {
        public int Id { get; set; }
        public string TenQuyen { get; set; }
        public ICollection<NhanVien> lstNhanVien { get; set; }
     }
}
