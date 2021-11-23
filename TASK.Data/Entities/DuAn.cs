using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK.Data.Entities
{
    public class DuAn
    {
        public string MaDuAn { set; get; }
        public string TenDuAn { set; get; }
        public int TrangThai { set; get; }
        public List<ToDo> ToDos { get; set; }
        public List<TuanLamViec> TuanLamViecs { get; set; }
        public List<ChiTietDuAn> ChiTietDuAns { get; set; }
    }
}
