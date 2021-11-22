using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK.Data.Entities
{
    [Table("Module")]
    public class Module
    {
        [Key]
        public int MaModule { set; get; }

        [Required]
        [Column(TypeName = "Nvarchar")]
        [StringLength(50)]
        public string TenModule { set; get; }
    }
}
