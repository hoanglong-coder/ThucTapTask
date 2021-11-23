using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK.Data.Entities
{
    [Table("CongViec")]
    public class CongViec
    {
        [Key]
        [StringLength(50)]
        public string MaCongViec { set; get; }
        public Module Module { set; get; }
        [StringLength(500)]
        public string IssueURL { set; get; }
        [StringLength(50)]
        public string TenIssue { set; get; }
        [Required]
        [Column(TypeName = "Nvarchar")]
        public string TenCongViec { set; get; }
        [Required]
        public int Nguon { set; get; }
        [Required]
        public int ThoiGianLam { set; get; }
        [Required]
        public DateTime TuNgay { set; get; }
        [Required]
        public DateTime DenNgay { set; get; }
        public TuanLamViec TuanLamViec { set; get; } //Mã tháng làm việc
        public ChiTietTuan ChiTietTuan { set; get; } //Mã tuần chi tiết
        public User User { set; get; }
        [StringLength(50)]
        [Column(TypeName = "Nvarchar")]
        public string GhiChu { set; get; }
        [Required]
        public int TrangThai { set; get; }
    }
}
