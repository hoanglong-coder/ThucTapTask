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
        Task<List<CongViecResponse>> GetAll(CongViecSearch congViecSearch);

        Task<List<Module>> GetAllModule();

        Task<int> InsertCongViec(CongViecRequest congViecRequest);

        Task<int> DeleteCongViecRange(List<CongViecRequest> congViecRequests);

        Task<int> UpdateCongViecRange(List<CongViecRequest> congViecRequests);

        Task<int> DuyetKeHoachTuan(List<CongViecRequest> congViecRequests);
    }
}
