using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK.Application.MChart
{
    public class NhanXet
    {
        public Guid MaUser { get; set; }

        public string TenUser { get; set; }

        public int? HoanThanh { set; get; }

        public int? XepLoai { set; get; }

        public string NhanXetThang { set; get; }

        public List<ChitietNhanXet> chitietNhanXets { get; set; }
    }
}
