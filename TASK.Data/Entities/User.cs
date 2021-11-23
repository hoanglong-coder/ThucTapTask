using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK.Data.Entities
{
    public class User
    {
        public string MaUser { get; set; }
        public string TenUser { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool TrangThai { get; set; }
        public List<ChiTietDuAn> ChiTietDuAns { get; set; }
        public List<ToDo> ToDos { get; set; }
        public List<CongViec> CongViecs { get; set; }
    }
}
