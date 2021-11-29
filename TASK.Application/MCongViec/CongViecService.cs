using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TASK.Data;
using TASK.Data.Entities;

namespace TASK.Application.MCongViec
{
    public class CongViecService : ICongViecService
    {
        private readonly TaskDbContext _taskDbContext;

        public CongViecService(TaskDbContext taskDbContext)
        {
            _taskDbContext = taskDbContext;
        }

        public async Task<List<CongViecResponse>> GetAll()
        {
            var lstcongviec = await _taskDbContext.CongViecs.Select(t => new CongViecResponse() { 
            
                MaCongViec = t.MaCongViec,
                MaModule= t.MaModule.Value,
                IssueURL= t.IssueURL,
                TenIssue = t.TenIssue,
                TenCongViec = t.TenCongViec,
                Nguon = t.Nguon,
                TuNgay = t.TuNgay,
                DenNgay = t.DenNgay,
                MaThangLamViec = t.MaThangLamViec.Value,
                MaTuanChiTiet = t.MaTuanChiTiet.Value,
                ThoiGianLam = t.ThoiGianLam,
                MaUser = t.MaUser.Value,
                GhiChu = t.GhiChu,
                TrangThai = t.TrangThai,
                TenUser = _taskDbContext.Users.Where(e => e.MaUser == t.MaUser).Single().TenUser,
                TenModule = (_taskDbContext.Modules.Where(e=>e.MaModule==t.MaModule).Single().TenModule==null?"": _taskDbContext.Modules.Where(e => e.MaModule == t.MaModule).Single().TenModule)
            }).ToListAsync();

            return lstcongviec;
        }

        public async Task<List<Module>> GetAllModule()
        {
            var listmodule = await _taskDbContext.Modules.Select(t => t).ToListAsync();

            return listmodule;
        }
    }
}
