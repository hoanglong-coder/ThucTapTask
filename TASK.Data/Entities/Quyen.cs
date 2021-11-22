using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK.Data.Entities
{
    [Table("Quyen")]
    public class Quyen
    {
        [Key]
        public int MaQuyen { get; set; }

        public string TenQuyen { get; set; }
    }
}
