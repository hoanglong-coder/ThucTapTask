using Microsoft.AspNetCore.Components.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TASK.Application.MLogin;

namespace TASK.WebApp.Repository.Interface
{
    public interface IAuthService
    {
        Task<LoginResponse> Login(LoginRequest login);
    }
}
