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
        public int MaQuyen { get; set; }
        public string TenQuyen { get; set; }
        public List<ChiTietDuAn> ChiTietDuAns { get; set; }
    }
}
