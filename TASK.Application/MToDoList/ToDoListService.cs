using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TASK.Data;

namespace TASK.Application.MToDoList
{
    public class ToDoListService : IToDoListService
    {
        private readonly TaskDbContext _taskDbContext;

        public ToDoListService(TaskDbContext taskDbContext)
        {
            _taskDbContext = taskDbContext;
        }

        public async Task<List<ToDoListResponse>> GetToDoByDuAn(int MaDuAn, Guid MaUser)
        {
            if (!KiemTraAdmin(MaUser))
            {
                var listtodo = await _taskDbContext.ToDos.Where(t => t.MaUser == MaUser && t.MaDuAn == MaDuAn&&t.TrangThai==false).Select(t=> new ToDoListResponse() {
                
                    MaTodo = t.MaTodo,
                    MaUser = t.MaUser,
                    NgayGiao = t. NgayGiao,
                    NgayDenHang = t.NgayDenHang,
                    NoiDung = t.NoiDung,
                    GhiChu = t.GhiChu,
                    TrangThai = t.TrangThai,
                    MaDuAn = t.MaDuAn               
                }).OrderBy(t=>t.NgayDenHang).ToListAsync();

                return listtodo;
            }else
            {
                var listtodo = await _taskDbContext.ToDos.Where(t => t.MaDuAn == MaDuAn && t.TrangThai == false).Select(t => new ToDoListResponse()
                {

                    MaTodo = t.MaTodo,
                    MaUser = t.MaUser,
                    NgayGiao = t.NgayGiao,
                    NgayDenHang = t.NgayDenHang,
                    NoiDung = t.NoiDung,
                    GhiChu = t.GhiChu,
                    TrangThai = t.TrangThai,
                    MaDuAn = t.MaDuAn
                }).OrderBy(t => t.NgayDenHang).ToListAsync();

                return listtodo;
            }
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
