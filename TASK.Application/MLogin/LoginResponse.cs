using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK.Application.MLogin
{
    public class LoginResponse
    {
        public Guid MaUser { get; set; }

        public string UserName { get; set; }

        public string FullName { get; set; }

        public bool Successful { get; set; }

        public string Error { get; set; }

    }
}
