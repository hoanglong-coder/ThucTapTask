using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK.Data.Entities
{
    public class CongViec
    {
        public int MaCongViec { set; get; }
        public int? MaModule { set; get; }
        public string IssueURL { set; get; }
        public string TenIssue { set; get; }
        public string TenCongViec { set; get; }
        public int Nguon { set; get; }
        public int ThoiGianLam { set; get; }
        public DateTime TuNgay { set; get; }
        public DateTime DenNgay { set; get; }
        public int? MaThangLamViec { set; get; }
        public TuanLamViec TuanLamViec { set; get; }
        public int? MaTuanChiTiet { set; get; }
        public ChiTietTuan ChiTietTuan { set; get; }
        public Guid? MaUser { get; set; }
        public virtual User User { set; get; }
        public string GhiChu { set; get; }
        public int TrangThai { set; get; }
        public int? CountDoiTre { get; set; }
        public int? CountDoiDoDotXuat { get; set; }
        public bool DaDuyet { get; set; }
    }
}
