using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK.Application.MCongViec
{
    public class CongViecSearch
    {
        public int MaThangLamViec { set; get; }

        public int MaTuanChiTiet { set; get; }

        public int MaModule { get; set; }

        public string TenCongViec { get; set; }

        public Guid MaUser { get; set; }

        public int TrangThai { set; get; }
    }
}
