using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TASK.Application.MUser;

namespace TASK.WebApp.Repository.Interface
{
    public interface IUserServiceClient
    {
        Task<List<UserResponse>> GetAllByDuAn(int maduan);
    }
}
