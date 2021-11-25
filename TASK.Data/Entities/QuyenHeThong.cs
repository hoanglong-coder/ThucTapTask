using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK.Data.Entities
{
    public class QuyenHeThong
    {
        public int MaQuyenHeThong { get; set; }
        public string TenQuyen { get; set; }
        public List<User> Users { get; set; }
    }
}
