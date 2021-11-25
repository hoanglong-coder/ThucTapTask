using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK.Application.MTuanLamViec
{
    public class TuanLamViecDTO
    {
        public int MaThangLamViec { set; get; }

        public string TenThang { set; get; }

        public int GiaTri { set; get; }

        public DateTime NgayBatDau { set; get; }

        public DateTime NgayKetThuc { set; get; }
    }
}
