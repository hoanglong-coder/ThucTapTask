using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK.Data.Entities
{
    [Table("ToDo")]
    public class ToDo
    {
        [Key]
        [StringLength(50)]
        public string MaTodo { set; get; }

        [Required]
        [StringLength(50)]
        public string MaUser { set; get; }

        [Required]
        public DateTime NgayGiao { set; get; }

        [Required]
        public DateTime NgayDenHang { set; get; }

        [Column(TypeName = "Nvarchar")]
        public string NoiDung { set; get; }

        [Column(TypeName = "Nvarchar")]
        public string GhiChu { set; get; }

        [Required]
        public int TrangThai { set; get; }

        public DuAn DuAn { set; get; }
    }
}
