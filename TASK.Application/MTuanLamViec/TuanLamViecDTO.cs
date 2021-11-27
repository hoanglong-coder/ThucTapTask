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

        [Range(1,100000,
        ErrorMessage = "Giá trị phải lớn hơn 1 ")]
        public int GiaTri { set; get; }

        [Required(ErrorMessage = "Ngày bắt đầu không đc để trống")]
        public DateTime NgayBatDau { set; get; }

        [Required(ErrorMessage = "Ngày kết thúc không đc để trống")]
        public DateTime NgayKetThuc { set; get; }
    }
}
