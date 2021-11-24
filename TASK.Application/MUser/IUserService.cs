using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TASK.Data.Entities;

namespace TASK.Application.MUser
{
    public interface IUserService
    {
        Task<List<UserResponse>> GetAll();

        Task<UserResponse> GetUser(Guid idUser);
    }
}
