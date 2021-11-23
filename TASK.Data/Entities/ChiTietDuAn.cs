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
        public string MaDuAn { get; set; }
        public DuAn DuAn { set; get; }
        public string MaUser { get; set; }
        public User User { set; get; }
        public int MaQuyen { set; get; }
        public Quyen Quyen { set; get; }
    }
}
