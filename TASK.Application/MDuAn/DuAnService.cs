using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TASK.Data;

namespace TASK.Application.MDuAn
{
    public class DuAnService : IDuAnService
    {

        private readonly TaskDbContext _taskDbContext;

        public DuAnService(TaskDbContext taskDbContext)
        {
            _taskDbContext = taskDbContext;
        }


        public async Task<List<DuAnResponse>> GetDuAnByUser(Guid UserId)
        {
            if (!KiemTraAdmin(UserId))
            {
                var DuAnUser = _taskDbContext.ChiTietDuAns.Where(t => t.MaUser == UserId);

                var DuAn = _taskDbContext.DuAns.Select(t => t);


                var rs = await (from A in DuAnUser
                                join B in DuAn on A.MaDuAn equals B.MaDuAn
                                select new DuAnResponse()
                                {
                                    MaDuAn = A.MaDuAn,
                                    TenDuAn = B.TenDuAn,
                                    TrangThai = B.TrangThai
                                }).ToListAsync();

                return rs;
            }else
            {
                var ListDuAn = await _taskDbContext.DuAns.Select(t => new DuAnResponse {
                
                    MaDuAn = t.MaDuAn,
                    TenDuAn =t.TenDuAn,
                    TrangThai = t.TrangThai              
                }).ToListAsync();

                return ListDuAn;
            }

        }

        public string GetNameDuAn(int id)
        {
            return _taskDbContext.DuAns.Where(t => t.MaDuAn == id).SingleOrDefault().TenDuAn;
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
