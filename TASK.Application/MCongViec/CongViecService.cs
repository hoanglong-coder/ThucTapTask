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
                MaModule= t.MaModule!=null? t.MaModule.Value: 0,
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
                DaDuyet = t.DaDuyet,
                TenUser = _taskDbContext.Users.Where(e => e.MaUser == t.MaUser).Single().TenUser,
                TenModule = (t.MaModule!=null? _taskDbContext.Modules.Where(e => e.MaModule == t.MaModule).Single().TenModule : "")
            }).ToListAsync();

            return lstcongviec;
        }

        public async Task<List<Module>> GetAllModule()
        {
            var listmodule = await _taskDbContext.Modules.Select(t => t).ToListAsync();

            return listmodule;
        }

        public async Task<int> InsertCongViec(CongViecRequest congViecRequest)
        {
            try
            {
                var Congviec = new CongViec();
                Congviec.MaUser = congViecRequest.MaUser;
                Congviec.MaThangLamViec = congViecRequest.MaThangLamViec;
                Congviec.MaTuanChiTiet = congViecRequest.MaTuanChiTiet;
                Congviec.MaModule = congViecRequest.MaModule!=0? congViecRequest.MaModule:null;
                Congviec.TenIssue = congViecRequest.TenIssue;
                Congviec.IssueURL = congViecRequest.IssueURL;
                Congviec.TenCongViec = congViecRequest.TenCongViec;
                Congviec.ThoiGianLam = congViecRequest.ThoiGianLam;
                Congviec.TrangThai = congViecRequest.TrangThai;
                Congviec.TuNgay = congViecRequest.TuNgay;
                Congviec.DenNgay = congViecRequest.DenNgay;
                Congviec.GhiChu = congViecRequest.GhiChu;
                Congviec.Nguon = congViecRequest.Nguon;

                await _taskDbContext.CongViecs.AddAsync(Congviec);

                await _taskDbContext.SaveChangesAsync();

                return 1;
            }
            catch (Exception e)
            {
                String mes = e.Message;
                Console.WriteLine(e.Message);
                return 0;
            }         
        }
    }
}
