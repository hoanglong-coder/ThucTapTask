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
        public int? KhoiLuong { set; get; }
        public int? TienDo { set; get; }
        public int? ChatLuong { set; get; }
        public int? TrungBinhThang { set; get; }
        public int? XepLoai { set; get; }
        public string NhanXet { set; get; }
        public int MaThangLamViec { get; set; }
        public Guid MaUser { get; set; }
        public virtual TuanLamViec TuanLamViec { set; get; }
        public List<DanhGiaTuan> DanhGiaTuans { get; set; }
    }
}
