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

        public async Task<int> GetQuyenDuAn(Guid idUser, int maduan)
        {
            var MaQuyen =  _taskDbContext.ChiTietDuAns.Where(t => t.MaDuAn == maduan && t.MaUser == idUser);
            await Task.Delay(100);
            if(KiemTraAdmin(idUser))
            {
                return 0;
            }    
            if (MaQuyen.SingleOrDefault().MaQuyen != null)
            {
                return MaQuyen.FirstOrDefault().MaQuyen.Value;
            }
            return 0;
        }

        public async Task<UserResponse> GetUser(Guid idUser)
        {
           var user= await _taskDbContext.Users.FindAsync(idUser);
            var result = new UserResponse();
            result.TenUser = user.TenUser;
            result.MaQuyen = user.MaQuyenHeThong;
            return result;
        }

        public bool KiemTraAdmin(Guid UserId)
        {
            var check = _taskDbContext.Users.Where(t => t.MaUser == UserId).SingleOrDefault();

            if (check.MaQuyenHeThong == 1)
            {
                return true;
            }
            return false;
        }
    }
}
