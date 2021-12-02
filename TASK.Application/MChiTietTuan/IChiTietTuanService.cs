using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK.Application.MChiTietTuan
{
    public interface IChiTietTuanService
    {
        Task<List<ChiTietTuanResponse>> GetChiTietTuanByTuanLamViec(int id);

        Task<bool> InsertListChiTietTuan(List<ChiTietTuanRequest> chiTietTuanRequests);

        Task<int> DeleteChiTietTuan(List<ChiTietTuanRequest> machitiettuan);

        Task<int> DeleteChiTietTuanAll(int mathanglamviec);

        Task<int> UpdateChiTietTuanLamViec(List<ChiTietTuanRequest> chiTietTuanRequests);

        Task<int> KhoaKeHoachTuan(List<ChiTietTuanRequest> machitiettuan);

        Task<bool> KiemTraKhoaTuan(int machitiettuan);

        Task<int> TraVeSoGioLam(int machitiettuan);
    }
}
