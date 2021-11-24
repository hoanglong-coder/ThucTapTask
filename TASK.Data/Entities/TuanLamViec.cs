using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK.Data.Entities
{
    public class TuanLamViec
    {
        public int MaThangLamViec { set; get; }
        public string TenThang { set; get; }
        public int GiaTri { set; get; }
        public DateTime NgayBatDau { set; get; }
        public DateTime NgayKetThuc { set; get; }
        public int? MaDuAn { get; set; }
        public virtual DuAn DuAn { set; get; }
        public List<ChiTietTuan> ChiTietTuans { get; set; }
        public List<CongViec> CongViecs { get; set; }
        public List<DanhGiaThang> DanhGiaThangs { get; set; }
    }
}
