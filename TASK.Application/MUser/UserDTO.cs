using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK.Application.MUser
{
    public class UserDTO
    {
        public Guid MaUser { get; set; }

        public string TenUser { get; set; }

        public string UserName { get; set; }

        public bool? TrangThai { get; set; }
    }
}
