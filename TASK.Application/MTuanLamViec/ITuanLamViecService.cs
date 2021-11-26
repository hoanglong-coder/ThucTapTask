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

        Task<int> InsertTuanLamViec(TuanLamViecRequest tuanLamViec);

        Task<int> DeleteTuanLamViec(List<TuanLamViecRequest> tuanLamViecs);
    }
}
