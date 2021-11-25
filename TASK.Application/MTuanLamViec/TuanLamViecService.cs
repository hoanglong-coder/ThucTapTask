using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TASK.Data;

namespace TASK.Application.MTuanLamViec
{
    public class TuanLamViecService : ITuanLamViecService
    {
        private readonly TaskDbContext _taskDbContext;

        public TuanLamViecService(TaskDbContext taskDbContext)
        {
            _taskDbContext = taskDbContext;
        }

        public async Task<List<TuanLamViecResponse>> GetTuanLamViecByDuAn(int id)
        {
            var lstTuanLamViec = await _taskDbContext.TuanLamViecs.Where(t => t.MaDuAn == id).Select(t=>new TuanLamViecResponse() { 
                
                MaThangLamViec = t.MaThangLamViec,
                TenThang = t.TenThang,
                GiaTri = t.GiaTri,
                NgayBatDau = t.NgayBatDau,
                NgayKetThuc = t.NgayKetThuc,       
            
            }).ToListAsync();

            return lstTuanLamViec;
        }
    }
}
