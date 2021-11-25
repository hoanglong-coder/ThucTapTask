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
    }
}
