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

        public async Task<ToDoListResponse> GetToDoByDuAn(int MaDuAn, Guid MaUser, int skip, int take)
        {
            if (!KiemTraAdmin(MaUser))
            {
                var listtodo = await _taskDbContext.ToDos.Where(t => t.MaUser == MaUser && t.MaDuAn == MaDuAn&&t.TrangThai==false).Select(t=> new ToDoListDTO() {
                
                    MaTodo = t.MaTodo,
                    MaUser = t.MaUser,
                    NgayGiao = t. NgayGiao,
                    NgayDenHang = t.NgayDenHang,
                    NoiDung = t.NoiDung,
                    GhiChu = t.GhiChu,
                    TrangThai = t.TrangThai,
                    MaDuAn = t.MaDuAn               
                }).OrderBy(t=>t.NgayDenHang).Skip(skip).Take(take).ToListAsync();


                int CountSize = _taskDbContext.ToDos.Where(t => t.MaUser == MaUser && t.MaDuAn == MaDuAn && t.TrangThai == false).Count();

                ToDoListResponse toDoListResponse = new ToDoListResponse();

                toDoListResponse.Count = CountSize;

                toDoListResponse.ListToDo = listtodo;

                return toDoListResponse;
            }else
            {
                var listtodo = await _taskDbContext.ToDos.Where(t => t.MaDuAn == MaDuAn && t.TrangThai == false).Select(t => new ToDoListDTO()
                {

                    MaTodo = t.MaTodo,
                    MaUser = t.MaUser,
                    NgayGiao = t.NgayGiao,
                    NgayDenHang = t.NgayDenHang,
                    NoiDung = t.NoiDung,
                    GhiChu = t.GhiChu,
                    TrangThai = t.TrangThai,
                    MaDuAn = t.MaDuAn
                }).OrderBy(t => t.NgayDenHang).Skip(skip).Take(take).ToListAsync();


                int CountSize = await _taskDbContext.ToDos.Where(t => t.MaDuAn == MaDuAn && t.TrangThai == false).CountAsync();

                ToDoListResponse toDoListResponse = new ToDoListResponse();

                toDoListResponse.Count = CountSize;

                toDoListResponse.ListToDo = listtodo;

                return toDoListResponse;
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
