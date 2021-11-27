using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK.Application.MToDoList
{
    public interface IToDoListService
    {
        Task<ToDoListResponse> GetToDoByDuAn(int MaDuAn,Guid MaUser,int skip,int take);
    }
}
