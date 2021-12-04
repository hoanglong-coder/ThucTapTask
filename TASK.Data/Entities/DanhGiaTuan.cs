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

        public int? HoanThanh { set; get; }

        public int? KhoiLuong { set; get; }

        public int? TienDo { set; get; }

        public int? ChatLuong { set; get; }

        public string LoiTrongTuan { set; get; }

        public string NhanXetTuan { set; get; }

        public int MaDanhGiaThang { get; set; }

        public virtual DanhGiaThang DanhGiaThang { set; get; }

        public int MaChiTietTuan { get; set; }

        public virtual ChiTietTuan ChiTietTuan { set; get; }
    }
}
