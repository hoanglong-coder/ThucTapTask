using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK.Data.Entities
{
    public class DanhGiaTuan
    {
        public int MaDanhGiaTuan { set; get; }
        public float HoanThanh { set; get; }
        public string KhoiLuong { set; get; }
        public string TienDo { set; get; }
        public string ChatLuong { set; get; }
        public string LoiTrongTuan { set; get; }
        public string NhanXetTuan { set; get; }
        public int? MaDanhGiaThang { get; set; }
        public virtual DanhGiaThang DanhGiaThang { set; get; }
        public int? MaChiTietTuan { get; set; }
        public virtual ChiTietTuan ChiTietTuan { set; get; }
    }
}
