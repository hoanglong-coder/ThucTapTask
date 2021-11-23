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
        public string MaCongViec { set; get; }
        public int MaModule { set; get; }
        public Module Module { set; get; }
        public string IssueURL { set; get; }
        public string TenIssue { set; get; }
        public string TenCongViec { set; get; }
        public int Nguon { set; get; }
        public int ThoiGianLam { set; get; }
        public DateTime TuNgay { set; get; }
        public DateTime DenNgay { set; get; }
        public int MaThangLamViec { set; get; }
        public TuanLamViec TuanLamViec { set; get; }
        public int MaTuanChiTiet { set; get; }
        public ChiTietTuan ChiTietTuan { set; get; }
        public string MaUser { get; set; }
        public User User { set; get; }
        public string GhiChu { set; get; }
        public int TrangThai { set; get; }
    }
}
