using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TASK.Data.Entities;

namespace TASK.Application.MCongViec
{
    public interface ICongViecService
    {
        Task<List<CongViecResponse>> GetAll();

        Task<List<Module>> GetAllModule();
    }
}
