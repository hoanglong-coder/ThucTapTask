using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TASK.Application.MToDoList;

namespace TASK.WebApp.Repository.Interface
{
    public interface IToDoServiceClient
    {
        Task<List<ToDoListResponse>> GetToDoByDuAn(int MaDuAn, Guid MaUser);
    }
}
