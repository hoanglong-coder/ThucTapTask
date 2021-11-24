using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TASK.Data;
using TASK.Data.Entities;

namespace TASK.Application.MUser
{
    public class UserService : IUserService
    {

        private readonly TaskDbContext _taskDbContext;


        public UserService(TaskDbContext taskDbContext)
        {
            _taskDbContext = taskDbContext;
        }


        public async Task<List<UserResponse>> GetAll()
        {
            var ListUser = await _taskDbContext.Users.Select(t => new UserResponse
            {
                MaUser = t.MaUser,
                TenUser = t.TenUser,
                UserName = t.UserName,
                TrangThai = t.TrangThai
            }).ToListAsync();


            return ListUser;
        }

        public Task<UserResponse> GetUser(Guid idUser)
        {
            throw new NotImplementedException();
        }
    }
}
