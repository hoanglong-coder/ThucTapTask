using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK.Application.MDanhGiaNhanSu
{
    public class DanhGiaTuanDTO
    {
        public int MaDanhGiaTuan { set; get; }

        public int? HoanThanh { set; get; }

        public int? KhoiLuong { set; get; }

        public int? TienDo { set; get; }

        public int? ChatLuong { set; get; }

        public string LoiTrongTuan { set; get; }

        public string NhanXetTuan { set; get; }

        public int MaDanhGiaThang { get; set; }

        public int MaChiTietTuan { get; set; }
    }
}
