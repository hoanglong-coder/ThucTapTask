using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TASK.Application.MTuanLamViec;

namespace TASK.WebApp.Repository.Interface
{
    public interface ITuanLamViecServiceClient
    {
        Task<List<TuanLamViecResponse>> GetTuanLamViecByDuAn(int id);

        Task<int> InsertTuanLamViec(TuanLamViecRequest tuanLamViec);
    }
}
