using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK.Application.MTuanLamViec
{
    public interface ITuanLamViecService
    {
        Task<List<TuanLamViecResponse>> GetTuanLamViecByDuAn(int id);

        Task<TuanLamViecPaging> GetTuanLamViecByDuAnPageing(int id, int skip,int take);

        Task<int> InsertTuanLamViec(TuanLamViecRequest tuanLamViec);

        Task<int> DeleteTuanLamViec(List<TuanLamViecRequest> tuanLamViecs);

        Task<TuanLamViecResponse> GetTuanLamViecByMaThangLamViec(int id);

        Task<int> UpdateTuanLamViec(TuanLamViecRequest tuanLamViecRequest);
    }
}
