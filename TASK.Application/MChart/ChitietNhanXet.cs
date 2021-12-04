using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK.Application.MChart
{
    public class ChitietNhanXet
    {
        public int MaTuanChiTiet { set; get; }

        public string TenTuan { set; get; }

        public DateTime TuNgay { set; get; }

        public DateTime DenNgay { set; get; }

        public int SoGioLam { set; get; }

        public int? HoanThanh { set; get; }

        public string LoiTrongTuan { get; set; }

        public string NhanXetTuan { get; set; }

    }
}
