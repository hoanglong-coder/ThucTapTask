using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK.Data.Entities
{
    public class DanhGiaThang
    {
        public int MaDanhGiaThang { set; get; }
        public string KhoiLuong { set; get; }
        public string TienDo { set; get; }
        public string ChatLuong { set; get; }
        public char XepLoai { set; get; }
        public string NhanXet { set; get; }
        public int? MaTuanLamViec { get; set; }
        public virtual TuanLamViec TuanLamViec { set; get; }
        public List<DanhGiaTuan> DanhGiaTuans { get; set; }
    }
}
