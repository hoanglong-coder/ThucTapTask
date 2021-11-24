using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TASK.Application.MUser;

namespace TASK.Application.MLogin
{
    public interface ILoginService
    {
        LoginResponse Login(LoginRequest loginRequest);

        int CheckLogin(LoginRequest loginRequest);

    }
}
