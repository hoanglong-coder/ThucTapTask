using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TASK.Application.MToDoList;

namespace TASK.WebApp.Repository.Interface
{
    public interface IToDoServiceClient
    {
        Task<ToDoListResponse> GetToDoByDuAn(int MaDuAn, Guid MaUser, int skip, int take,bool trangthai);

        Task<ToDoListResponse> GetAllToDoByDuAn(int MaDuAn, Guid MaUser);

        Task<int> InsertToDo(ToDoListRequest toDoListRequest);

        Task<int> DeleteTodo(IList<ToDoListDTO> MaToDo);

        Task<int> UpdateToDo(ToDoListRequest toDoListRequest);

        Task<ToDoListDTO> GetTodoById(int MaToDo);

        Task<int> XacNhanXongToDo(int MaToDo);
    }
}
