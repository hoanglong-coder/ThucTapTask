using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TASK.Data;
using TASK.Data.Entities;

namespace TASK.Application.MChiTietTuan
{
    public class ChiTietTuanService : IChiTietTuanService
    {

        private readonly TaskDbContext _taskDbContext;

        public ChiTietTuanService(TaskDbContext taskDbContext)
        {
            _taskDbContext = taskDbContext;
        }

        public async Task<List<ChiTietTuanResponse>> GetChiTietTuanByTuanLamViec(int id)
        {
            var lstChiTietTuan = await _taskDbContext.ChiTietTuans.Where(t => t.MaThangLamViec == id).Select(t => new ChiTietTuanResponse()
            {

                MaTuanChiTiet = t.MaTuanChiTiet,
                TenTuan = t.TenTuan,
                TuNgay = t.TuNgay,
                DenNgay = t.DenNgay,
                GiaTri = t.GiaTri,
                SoGioLam = t.SoGioLam,
                TrangThai = t.TrangThai
            }).ToListAsync();

            return lstChiTietTuan;

        }

        public async Task<bool> InsertListChiTietTuan(List<ChiTietTuanRequest> chiTietTuanRequests)
        {
            try
            {
                var listChitiettuan = chiTietTuanRequests.Select(t => new ChiTietTuan()
                {

                    TenTuan = t.TenTuan,
                    TuNgay = t.TuNgay,
                    DenNgay = t.DenNgay,
                    GiaTri = t.GiaTri,
                    SoGioLam = t.SoGioLam,
                    TrangThai = t.TrangThai,
                    MaThangLamViec = t.MaThangLamViec

                });

                await _taskDbContext.ChiTietTuans.AddRangeAsync(listChitiettuan);

                await _taskDbContext.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
    }
}
