using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK.Data.Entities
{
    [Table("ChiTietDuAn")]
    public class ChiTietDuAn
    {
        [Key]
        public DuAn MaDuAn { set; get; }

        [Key]
        public User User { set; get; }

        public Quyen Quyen { set; get; }
    }
}
