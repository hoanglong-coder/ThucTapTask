using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK.Application.MDanhGiaNhanSu
{
    public interface IDanhGiaTuanService
    {
        Task<List<DanhGiaTuanResponse>> GetDanhGiaTuanByDanhGiaThang(int MaDanhGiaThang, Guid MaUser);

        Task<int> UpdateDanhGiaTuan(List<DanhGiaTuanResponse> danhGiaThangResponses);
    }
}
