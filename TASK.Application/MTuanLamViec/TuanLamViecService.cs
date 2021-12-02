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
            var lstTuanLamViec = await _taskDbContext.TuanLamViecs.Where(t => t.MaDuAn == id).OrderBy(t=>t.GiaTri).Select(t => new TuanLamViecResponse()
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

        public async Task<TuanLamViecResponse> GetTuanLamViecByMaThangLamViec(int id)
        {
            var tuanlamviec = await _taskDbContext.TuanLamViecs.FindAsync(id);

            var tuanlamviecresponse = new TuanLamViecResponse();
            tuanlamviecresponse.MaThangLamViec = tuanlamviec.MaThangLamViec;
            tuanlamviecresponse.TenThang = tuanlamviec.TenThang;
            tuanlamviecresponse.GiaTri = tuanlamviec.GiaTri;
            tuanlamviecresponse.NgayBatDau = tuanlamviec.NgayBatDau;
            tuanlamviecresponse.NgayKetThuc = tuanlamviec.NgayKetThuc;


            return tuanlamviecresponse;

        }

        public async Task<int> UpdateTuanLamViec(TuanLamViecRequest tuanLamViecRequest)
        {
            try
            {
                TuanLamViec tuanLamViec = new TuanLamViec();
                tuanLamViec.MaThangLamViec = tuanLamViecRequest.MaThangLamViec;
                tuanLamViec.TenThang = tuanLamViecRequest.TenThang;
                tuanLamViec.GiaTri = tuanLamViecRequest.GiaTri;
                tuanLamViec.NgayBatDau = tuanLamViecRequest.NgayBatDau;
                tuanLamViec.NgayKetThuc = tuanLamViecRequest.NgayKetThuc;
                tuanLamViec.MaDuAn = tuanLamViecRequest.MaDuAn;

                _taskDbContext.TuanLamViecs.Update(tuanLamViec);

                await _taskDbContext.SaveChangesAsync();

                return 1;
            }
            catch (Exception)
            {

                return 0;
            }
        }

        public async Task<TuanLamViecPaging> GetTuanLamViecByDuAnPageing(int id, int skip, int take)
        {
            var lstTuanLamViec = await _taskDbContext.TuanLamViecs.Where(t => t.MaDuAn == id).Select(t => new TuanLamViecResponse()
            {

                MaThangLamViec = t.MaThangLamViec,
                TenThang = t.TenThang,
                GiaTri = t.GiaTri,
                NgayBatDau = t.NgayBatDau,
                NgayKetThuc = t.NgayKetThuc,

            }).OrderBy(t=>t.GiaTri).Skip(skip).Take(take).ToListAsync();

            int Count = _taskDbContext.TuanLamViecs.Where(t => t.MaDuAn == id).Count();

            TuanLamViecPaging tuanLamViecPaging = new TuanLamViecPaging() {
                Count = Count,
                ListTuanLamViecRequest = lstTuanLamViec            
            };
            return tuanLamViecPaging;
        }
    }
}
