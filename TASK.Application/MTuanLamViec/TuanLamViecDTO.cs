using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK.Application.MTuanLamViec
{
    public class TuanLamViecDTO
    {
        
        public int MaThangLamViec { set; get; }

        [Required(ErrorMessage = "Tên tháng không được để trống")]
        public string TenThang { set; get; }

        public int GiaTri { set; get; }

        public DateTime NgayBatDau { set; get; }

        public DateTime NgayKetThuc { set; get; }
    }
}
