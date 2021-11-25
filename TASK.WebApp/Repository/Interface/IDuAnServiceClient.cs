using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TASK.Application.MDuAn;

namespace TASK.WebApp.Repository.Interface
{
    public interface IDuAnServiceClient
    {
        Task<List<DuAnResponse>> GetDuAnByUser(Guid id);

        Task<string> GetNameDuAn(int id);
    }
}
