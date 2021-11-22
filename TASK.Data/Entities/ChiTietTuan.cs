using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK.Data.Entities
{
    [Table("ChiTietTuan")]
    public class ChiTietTuan
    {
        [Key]
        public int MaTuanChiTiet { set; get; }
        [Required]
        [StringLength(50)]
        [Column(TypeName = "Nvarchar")]
        public string TenTuan { set; get; }
        [Required]
        public DateTime TuNgay { set; get; }
        [Required]
        public DateTime DenNgay { set; get; }
        public int GiaTri { set; get; }
        public int SoGioLam { set; get; }
        public int TrangThai { set; get; }
        public TuanLamViec TuanLamViec { set; get; }
    }
}
