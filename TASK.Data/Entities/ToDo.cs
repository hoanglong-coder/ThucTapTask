using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK.Data.Entities
{
    public class ToDo
    {
        public string MaTodo { set; get; }
        public string MaUser { set; get; }
        public User User { set; get; }
        public DateTime NgayGiao { set; get; }
        public DateTime NgayDenHang { set; get; }
        public string NoiDung { set; get; }
        public string GhiChu { set; get; }
        public int TrangThai { set; get; }
        public string MaDuAn { set; get; }
        public DuAn DuAn { set; get; }
    }
}
