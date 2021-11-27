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

        Task<TuanLamViecPaging> GetTuanLamViecByDuAnPageing(int id, int skip, int take);

        Task<int> InsertTuanLamViec(TuanLamViecRequest tuanLamViec);

        Task<int> DeleteTuanLamViec(IList<TuanLamViecResponse> tuanLamViecs);

        Task<TuanLamViecResponse> GetTuanLamViecByMaThangLamViec(int id);

        Task<int> UpdateTuanLamViec(TuanLamViecRequest tuanLamViecRequest);
    }
}
