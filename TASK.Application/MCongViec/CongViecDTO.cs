using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK.Application.MCongViec
{
    public class CongViecDTO
    {
        public int MaCongViec { set; get; }
        public int MaModule { set; get; }
        public string TenModule { get; set; }
        public string IssueURL { set; get; }
        public string TenIssue { set; get; }
        public string TenCongViec { set; get; }
        public int Nguon { set; get; }
        public int ThoiGianLam { set; get; }
        public DateTime TuNgay { set; get; }
        public DateTime DenNgay { set; get; }
        public int MaThangLamViec { set; get; }
        public int MaTuanChiTiet { set; get; }
        public Guid MaUser { get; set; }
        public string TenUser { get; set; }
        public string GhiChu { set; get; }
        public int TrangThai { set; get; }
        public bool DaDuyet { get; set; }
    }
}
