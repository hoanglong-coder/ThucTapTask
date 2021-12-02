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

        public async Task<int> DeleteChiTietTuan(List<ChiTietTuanRequest> machitiettuan)
        {
            try
            {
                foreach (var t in machitiettuan)
                {

                    ChiTietTuan chiTietTuan = _taskDbContext.ChiTietTuans.Find(t.MaTuanChiTiet);

                    _taskDbContext.ChiTietTuans.Remove(chiTietTuan);

                    await _taskDbContext.SaveChangesAsync();

                   
                }
                return 1;
            }
            catch (Exception e)
            {
                string a = e.Message;

                return 0;
            }

           
        }

        public async Task<int> DeleteChiTietTuanAll(int mathanglamviec)
        {
            try
            {

                var Chitiettuan = await _taskDbContext.ChiTietTuans.Where(t => t.MaThangLamViec == mathanglamviec).ToListAsync();

                _taskDbContext.ChiTietTuans.RemoveRange(Chitiettuan);

                await _taskDbContext.SaveChangesAsync();

                return 1;
            }
            catch (Exception)
            {

                return 0;
            }
        }

        public async Task<List<ChiTietTuanResponse>> GetChiTietTuanByTuanLamViec(int id)
        {
            var lstChiTietTuan = await _taskDbContext.ChiTietTuans.Where(t => t.MaThangLamViec == id).Select(t => new ChiTietTuanResponse()
            {

                MaTuanChiTiet = t.MaTuanChiTiet,
                TenTuan = t.TenTuan,
                TenTuanChitiet = t.TenTuan+$"({t.TuNgay.ToString("dd/MM")} - {t.DenNgay.ToString("dd/MM")})",
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

        public async Task<int> KhoaKeHoachTuan(List<ChiTietTuanRequest> machitiettuan)
        {
            try
            {
                foreach (var item in machitiettuan)
                {
                    ChiTietTuan chiTietTuan = await _taskDbContext.ChiTietTuans.FindAsync(item.MaTuanChiTiet);

                    chiTietTuan.TrangThai = true;

                    await _taskDbContext.SaveChangesAsync();
                }

                return 1;
            }
            catch (Exception)
            {

                return 0;
            }
            
        }

        public async Task<int> UpdateChiTietTuanLamViec(List<ChiTietTuanRequest> chiTietTuanRequests)
        {
            try
            {
                var chitiettuan = chiTietTuanRequests.Select(t => new ChiTietTuan()
                {
                    MaTuanChiTiet = t.MaTuanChiTiet,
                    TenTuan = t.TenTuan,
                    TuNgay = t.TuNgay,
                    DenNgay = t.DenNgay,
                    GiaTri = t.GiaTri,
                    SoGioLam = t.SoGioLam,
                    TrangThai = t.TrangThai,
                    MaThangLamViec = t.MaThangLamViec
                });

                _taskDbContext.ChiTietTuans.UpdateRange(chitiettuan);

                await _taskDbContext.SaveChangesAsync();

                return 1;
            }
            catch (Exception)
            {

                return 0;
            }                    
        }
    }
}
