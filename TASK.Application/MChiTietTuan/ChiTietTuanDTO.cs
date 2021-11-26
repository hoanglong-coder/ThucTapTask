using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK.Application.MChiTietTuan
{
    public class ChiTietTuanDTO
    {
        public int MaTuanChiTiet { set; get; }

        public string TenTuan { set; get; }

        public DateTime TuNgay { set; get; }

        public DateTime DenNgay { set; get; }

        public int GiaTri { set; get; }

        public int SoGioLam { set; get; }

        public bool TrangThai { set; get; }        
    }
}
