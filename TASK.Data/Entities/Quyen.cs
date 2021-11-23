using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK.Data.Entities
{
    public class Quyen
    {
        [Key]
        public Guid MaQuyen { get; set; }

        [StringLength(50)]
        [Column(TypeName ="Nvarchar")]
        public string TenQuyen { get; set; }
    }
}
