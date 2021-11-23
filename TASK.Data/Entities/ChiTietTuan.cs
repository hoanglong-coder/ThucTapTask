using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK.Data.Entities
{
    public class ChiTietTuan
    {
        public int MaTuanChiTiet { set; get; }
        public string TenTuan { set; get; }
        public DateTime TuNgay { set; get; }
        public DateTime DenNgay { set; get; }
        public int GiaTri { set; get; }
        public int SoGioLam { set; get; }
        public int TrangThai { set; get; }
        public int? MaThangLamViec { set; get; }
        public virtual TuanLamViec TuanLamViec { set; get; }
        public List<CongViec> CongViecs { get; set; }
    }
}
