using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TASK.Application.MChiTietTuan;

namespace TASK.WebApp.Repository.Interface
{
    public interface IChiTietTuanServiceClient
    {
        Task<List<ChiTietTuanResponse>> GetChiTietTuanByTuanLamViec(int id);

        List<ChiTietTuanRequest> PhatSinhChiTietTuan(DateTime ngaybatdau, DateTime ngayketthuc);

        Task<int> InsertChiTietTuan(List<ChiTietTuanRequest> lstChitiettuan,int mathanglamviec);

        Task<int> DeleteChiTietTuan(IList<ChiTietTuanResponse> machitiettuan);

        Task<int> DeleteChiTietTuanAll(int mathanglamviec);

        Task<int> UpdateChiTietTuanLamViec(List<ChiTietTuanRequest> chiTietTuanRequests);

        Task<int> KhoaKeHoachTuan(List<ChiTietTuanRequest> machitiettuan);

        Task<bool> KiemTraKhoaTuan(int machitiettuan);

        Task<int> TraVeSoGioLam(int machitiettuan);
    }
}
