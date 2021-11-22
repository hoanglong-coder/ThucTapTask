using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK.Data.Entities
{
    [Table("DuAn")]
    public class DuAn
    {
        [Key]
        [StringLength(50)]
        public string MaDuAn { set; get; }

        [Required]
        [StringLength(250)]
        [Column(TypeName = "Nvarchar")]
        public string TenDuAn { set; get; }

        public int TrangThai { set; get; }
    }
}
