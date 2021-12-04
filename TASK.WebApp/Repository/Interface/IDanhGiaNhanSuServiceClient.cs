using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TASK.Application.MDanhGiaNhanSu;

namespace TASK.WebApp.Repository.Interface
{
    public interface IDanhGiaNhanSuServiceClient
    {
        Task<DanhGiaThangResponse> GetDanhGiaThang(int MaThangLamViec, Guid MaUser);

        Task<List<DanhGiaTuanResponse>> GetDanhGiaTuanByDanhGiaThang(int MaDanhGiaThang, Guid MaUser);

        Task<int> UpdateDanhGiaThang(DanhGiaThangResponse danhGiaThangResponse);

        Task<int> UpdateDanhGiaTuan(List<DanhGiaTuanResponse> danhGiaThangResponses);
    }
}
