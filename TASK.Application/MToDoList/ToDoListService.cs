using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TASK.Data;
using TASK.Data.Entities;

namespace TASK.Application.MToDoList
{
    public class ToDoListService : IToDoListService
    {
        private readonly TaskDbContext _taskDbContext;

        public ToDoListService(TaskDbContext taskDbContext)
        {
            _taskDbContext = taskDbContext;
        }

        public async Task<int> DeleteTodo(List<ToDoListDTO> MaToDo)
        {
            try
            {
                List<ToDo> toDos = new List<ToDo>();

                foreach (var item in MaToDo)
                {
                    ToDo toDo = await _taskDbContext.ToDos.FindAsync(item.MaTodo);
                    toDos.Add(toDo);
                }

                _taskDbContext.ToDos.RemoveRange(toDos);

                await _taskDbContext.SaveChangesAsync();

                return 1;
            }
            catch (Exception)
            {

                return 0;
            }          
        }

        public async Task<ToDoListResponse> GetAllToDoByDuAn(int MaDuAn, Guid MaUser)
        {
            if (!KiemTraAdmin(MaUser))
            {
                int CountSize = _taskDbContext.ToDos.Where(t => t.MaUser == MaUser && t.MaDuAn == MaDuAn && t.TrangThai == false).Count();
                if (CountSize != 0)
                {
                    var getall = await GetToDoByDuAn(MaDuAn, MaUser, 0, CountSize,false);

                    return getall;
                }
                ToDoListResponse rs = new ToDoListResponse();
                rs.Count = 0;
                return rs;
            }
            else
            {
                int CountSize = _taskDbContext.ToDos.Where(t => t.MaDuAn == MaDuAn && t.TrangThai == false).Count();

                var getall = await GetToDoByDuAn(MaDuAn, MaUser, 0, CountSize,false);

                return getall;
            }
        }

        public async Task<ToDoListResponse> GetToDoByDuAn(int MaDuAn, Guid MaUser, int skip, int take, bool trangthai)
        {
            if (!trangthai)
            {
                if (!KiemTraAdmin(MaUser))
                {
                    var listtodo = await _taskDbContext.ToDos.Where(t => t.MaUser == MaUser && t.MaDuAn == MaDuAn && t.TrangThai == false).Select(t => new ToDoListDTO()
                    {

                        MaTodo = t.MaTodo,
                        MaUser = t.MaUser,
                        NgayGiao = t.NgayGiao,
                        NgayDenHang = t.NgayDenHang,
                        NoiDung = t.NoiDung,
                        GhiChu = t.GhiChu,
                        TrangThai = t.TrangThai,
                        MaDuAn = t.MaDuAn,
                        TenUser = _taskDbContext.Users.Where(e => e.MaUser == t.MaUser).SingleOrDefault().TenUser

                    }).OrderBy(t => t.NgayDenHang).Skip(skip).Take(take).ToListAsync();


                    int CountSize = _taskDbContext.ToDos.Where(t => t.MaUser == MaUser && t.MaDuAn == MaDuAn && t.TrangThai == false).Count();

                    ToDoListResponse toDoListResponse = new ToDoListResponse();

                    toDoListResponse.Count = CountSize;

                    toDoListResponse.ListToDo = listtodo;

                    return toDoListResponse;
                }
                else
                {
                    var listtodo = _taskDbContext.ToDos.Where(t => t.MaDuAn == MaDuAn && t.TrangThai == false).Select(t => new ToDoListDTO()
                    {

                        MaTodo = t.MaTodo,
                        MaUser = t.MaUser,
                        NgayGiao = t.NgayGiao,
                        NgayDenHang = t.NgayDenHang,
                        NoiDung = t.NoiDung,
                        GhiChu = t.GhiChu,
                        TrangThai = t.TrangThai,
                        MaDuAn = t.MaDuAn,
                        TenUser = _taskDbContext.Users.Where(e => e.MaUser == t.MaUser).SingleOrDefault().TenUser

                    }).OrderBy(t => t.NgayDenHang).Skip(skip).Take(take).ToList();


                    int CountSize = await _taskDbContext.ToDos.Where(t => t.MaDuAn == MaDuAn && t.TrangThai == false).CountAsync();

                    ToDoListResponse toDoListResponse = new ToDoListResponse();

                    toDoListResponse.Count = CountSize;

                    toDoListResponse.ListToDo = listtodo;

                    return toDoListResponse;
                }
            }
            else
            {
                if (!KiemTraAdmin(MaUser))
                {
                    var listtodo = await _taskDbContext.ToDos.Where(t => t.MaUser == MaUser && t.MaDuAn == MaDuAn).Select(t => new ToDoListDTO()
                    {

                        MaTodo = t.MaTodo,
                        MaUser = t.MaUser,
                        NgayGiao = t.NgayGiao,
                        NgayDenHang = t.NgayDenHang,
                        NoiDung = t.NoiDung,
                        GhiChu = t.GhiChu,
                        TrangThai = t.TrangThai,
                        MaDuAn = t.MaDuAn,
                        TenUser = _taskDbContext.Users.Where(e => e.MaUser == t.MaUser).SingleOrDefault().TenUser

                    }).OrderBy(t => t.NgayDenHang).Skip(skip).Take(take).ToListAsync();


                    int CountSize = _taskDbContext.ToDos.Where(t => t.MaUser == MaUser && t.MaDuAn == MaDuAn).Count();

                    ToDoListResponse toDoListResponse = new ToDoListResponse();

                    toDoListResponse.Count = CountSize;

                    toDoListResponse.ListToDo = listtodo;

                    return toDoListResponse;
                }
                else
                {
                    var listtodo = _taskDbContext.ToDos.Where(t => t.MaDuAn == MaDuAn).Select(t => new ToDoListDTO()
                    {

                        MaTodo = t.MaTodo,
                        MaUser = t.MaUser,
                        NgayGiao = t.NgayGiao,
                        NgayDenHang = t.NgayDenHang,
                        NoiDung = t.NoiDung,
                        GhiChu = t.GhiChu,
                        TrangThai = t.TrangThai,
                        MaDuAn = t.MaDuAn,
                        TenUser = _taskDbContext.Users.Where(e => e.MaUser == t.MaUser).SingleOrDefault().TenUser

                    }).OrderBy(t => t.NgayDenHang).Skip(skip).Take(take).ToList();


                    int CountSize = await _taskDbContext.ToDos.Where(t => t.MaDuAn == MaDuAn).CountAsync();

                    ToDoListResponse toDoListResponse = new ToDoListResponse();

                    toDoListResponse.Count = CountSize;

                    toDoListResponse.ListToDo = listtodo;

                    return toDoListResponse;
                }
            }

            
        }

        public async Task<ToDoListDTO> GetTodoById(int MaToDo)
        {
            var todo = await _taskDbContext.ToDos.FindAsync(MaToDo);

            var tododto = new ToDoListDTO();
            tododto.MaTodo = todo.MaTodo;
            tododto.MaUser = todo.MaUser;
            tododto.NgayGiao = todo.NgayGiao;
            tododto.NgayDenHang = todo.NgayDenHang;
            tododto.NoiDung = todo.NoiDung;
            tododto.GhiChu = todo.GhiChu;
            tododto.TrangThai = todo.TrangThai;
            tododto.MaDuAn = todo.MaDuAn;
            return tododto;
        }

        public async Task<int> InsertToDo(ToDoListRequest toDoListRequest)
        {
            try
            {
                var todo = new ToDo();
                todo.MaUser = toDoListRequest.MaUser;
                todo.NgayGiao = toDoListRequest.NgayGiao;
                todo.NgayDenHang = toDoListRequest.NgayDenHang;
                todo.NoiDung = toDoListRequest.NoiDung;
                todo.GhiChu = toDoListRequest.GhiChu;
                todo.TrangThai = toDoListRequest.TrangThai;
                todo.MaDuAn = toDoListRequest.MaDuAn;

                await _taskDbContext.ToDos.AddAsync(todo);

                await _taskDbContext.SaveChangesAsync();

                return 1;
            }
            catch (Exception)
            {

                return 0;
            }
        }

        public bool KiemTraAdmin(Guid UserId)
        {
            var check = _taskDbContext.Users.Where(t => t.MaUser == UserId).SingleOrDefault();

            if (check.MaQuyenHeThong == 1||check.MaQuyenHeThong==2)
            {
                return true;
            }
            return false;
        }

        public async Task<int> UpdateToDo(ToDoListRequest toDoListRequest)
        {
            try
            {
                var todo = new ToDo();
                todo.MaTodo = toDoListRequest.MaTodo;
                todo.MaUser = toDoListRequest.MaUser;
                todo.NgayGiao = toDoListRequest.NgayGiao;
                todo.NgayDenHang = toDoListRequest.NgayDenHang;
                todo.NoiDung = toDoListRequest.NoiDung;
                todo.GhiChu = toDoListRequest.GhiChu;
                todo.TrangThai = toDoListRequest.TrangThai;
                todo.MaDuAn = toDoListRequest.MaDuAn;

                 _taskDbContext.ToDos.Update(todo);

                await _taskDbContext.SaveChangesAsync();

                return 1;
            }
            catch (Exception)
            {

                return 0;
            }
        }
    }
}
