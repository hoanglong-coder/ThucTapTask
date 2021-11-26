using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TASK.Data;
using TASK.Data.Entities;

namespace TASK.Application.MTuanLamViec
{
    public class TuanLamViecService : ITuanLamViecService
    {
        private readonly TaskDbContext _taskDbContext;

        public TuanLamViecService(TaskDbContext taskDbContext)
        {
            _taskDbContext = taskDbContext;
        }

        public async Task<int> DeleteTuanLamViec(List<TuanLamViecRequest> tuanLamViecs)
        {
            try
            {
                foreach (var t in tuanLamViecs)
                {

                    TuanLamViec tuanLamViec = _taskDbContext.TuanLamViecs.Find(t.MaThangLamViec);

                    _taskDbContext.TuanLamViecs.Remove(tuanLamViec);

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

        public async Task<List<TuanLamViecResponse>> GetTuanLamViecByDuAn(int id)
        {
            var lstTuanLamViec = await _taskDbContext.TuanLamViecs.Where(t => t.MaDuAn == id).Select(t => new TuanLamViecResponse()
            {

                MaThangLamViec = t.MaThangLamViec,
                TenThang = t.TenThang,
                GiaTri = t.GiaTri,
                NgayBatDau = t.NgayBatDau,
                NgayKetThuc = t.NgayKetThuc,

            }).ToListAsync();

            return lstTuanLamViec;
        }

        public async Task<int> InsertTuanLamViec(TuanLamViecRequest tuanLamViec)
        {
            try
            {
                TuanLamViec tlv = new TuanLamViec();

                tlv.TenThang = tuanLamViec.TenThang;
                tlv.GiaTri = tuanLamViec.GiaTri;
                tlv.NgayBatDau = tuanLamViec.NgayBatDau;
                tlv.NgayKetThuc = tuanLamViec.NgayKetThuc;
                tlv.MaDuAn = tuanLamViec.MaDuAn;

                await _taskDbContext.TuanLamViecs.AddAsync(tlv);

                await _taskDbContext.SaveChangesAsync();

                int MaThangLamViec = _taskDbContext.TuanLamViecs.OrderByDescending(t=>t.MaThangLamViec).FirstOrDefaultAsync().Result.MaThangLamViec;

                return MaThangLamViec;
            }
            catch (Exception)
            {

                return 0;
            }

        }
    }
}
