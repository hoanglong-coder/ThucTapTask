using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace TASK.Application.MDuAn
{
    public interface IDuAnService 
    {
        Task<List<DuAnResponse>> GetDuAnByUser(Guid UserId);

        string GetNameDuAn(int id);
    }

}