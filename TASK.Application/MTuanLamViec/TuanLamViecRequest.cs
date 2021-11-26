using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK.Application.MTuanLamViec
{
    public class TuanLamViecRequest:TuanLamViecDTO
    {
        public int? MaDuAn { get; set; }

        public void Clear()
        {
            this.TenThang = string.Empty;
            this.GiaTri = 1;
            this.NgayBatDau = DateTime.Now;
            this.NgayKetThuc = DateTime.Now;
        }
    }
}
