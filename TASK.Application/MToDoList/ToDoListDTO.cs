using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK.Application.MToDoList
{
    public class ToDoListDTO
    {
        public int MaTodo { set; get; }

        public Guid? MaUser { set; get; }

        public string TenUser { get; set; }

        public DateTime NgayGiao { set; get; }

        public DateTime NgayDenHang { set; get; }

        public string NoiDung { set; get; }

        public string GhiChu { set; get; }

        public bool TrangThai { set; get; }

        public int? MaDuAn { set; get; }
    }
}
