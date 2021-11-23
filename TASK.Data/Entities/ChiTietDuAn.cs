using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK.Data.Entities
{
    public class ChiTietDuAn
    {
        public int MaDuAn { get; set; }
        public virtual DuAn DuAn { set; get; }
        public string MaUser { get; set; }
        public virtual User User { set; get; }
        public int MaQuyen { set; get; }
        public virtual Quyen Quyen { set; get; }
    }
}
