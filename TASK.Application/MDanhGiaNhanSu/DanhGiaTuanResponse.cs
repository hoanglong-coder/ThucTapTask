using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK.Application.MDanhGiaNhanSu
{
    public class DanhGiaTuanResponse:DanhGiaTuanDTO
    {
       public string TenTuan { get; set; }

       public DateTime TuNgay { get; set; }

       public DateTime Denngay { get; set; }

       public bool DaKhoa { get; set; }
    }
}
