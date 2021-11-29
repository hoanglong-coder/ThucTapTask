using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TASK.Application.MCongViec;
using TASK.Data.Entities;

namespace TASK.WebApp.Repository.Interface
{
    public interface ICongViecServiceClient
    {
        Task<List<CongViecResponse>> GetAll();

        Task<List<Module>> GetAllModule();
    }
}
