using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK.Data.Entities
{
    [Table("TuanLamViec")]
    public class TuanLamViec
    {
        [Key]
        public int MaThangLamViec { set; get; }

        [Required]
        [Column(TypeName = "Nvarchar")]
        [StringLength(50)]
        public string TenThang { set; get; }

        [Required]
        public int GiaTri { set; get; }

        [Required]
        public DateTime NgayBatDau { set; get; }

        [Required]
        public DateTime NgayKetThuc { set; get; }
        [Key]
        public DuAn DuAn { set; get; }
    }
}
