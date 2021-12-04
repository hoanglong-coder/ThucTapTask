using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK.Application.MDanhGiaNhanSu
{
    public interface IDanhGiaThangService
    {
        Task<DanhGiaThangResponse> GetDanhGiaThang(int MaThangLamViec, Guid MaUser);

        Task<int> UpdateDanhGiaThang(DanhGiaThangResponse danhGiaThangResponse);
    }
}
