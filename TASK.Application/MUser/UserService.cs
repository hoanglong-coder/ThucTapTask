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

        public async Task<List<UserResponse>> GetAllByDuAn(int maduan)
        {
            var ListUser =  _taskDbContext.Users.Select(t => t);

            var ListChitietDuAn = _taskDbContext.ChiTietDuAns.Where(t=>t.MaDuAn==maduan).Select(t => t);

            var ListUserChitietDuan = await (from User in ListUser
                                      join ChitietDuan in ListChitietDuAn on User.MaUser equals ChitietDuan.MaUser
                                      select new UserResponse
                                      {
                                          MaUser = User.MaUser,
                                          TenUser = User.TenUser,
                                          UserName = User.UserName,
                                          TrangThai = User.TrangThai
                                      }).ToListAsync();
            return ListUserChitietDuan;
        }

        public Task<UserResponse> GetUser(Guid idUser)
        {
            throw new NotImplementedException();
        }
    }
}
