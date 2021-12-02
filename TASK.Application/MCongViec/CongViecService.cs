using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TASK.Data;
using TASK.Data.Entities;
using TASK.Data.Enums;

namespace TASK.Application.MCongViec
{
    public class CongViecService : ICongViecService
    {
        private readonly TaskDbContext _taskDbContext;

        public CongViecService(TaskDbContext taskDbContext)
        {
            _taskDbContext = taskDbContext;
        }

        public async Task<int> DeleteCongViecRange(List<CongViecRequest> congViecRequests)
        {
            var liscongviec = new List<CongViec>();

            foreach (var item in congViecRequests)
            {
                var congviec = _taskDbContext.CongViecs.Find(item.MaCongViec);

                liscongviec.Add(congviec);
            }

            if (KiemTraDaDuyet(liscongviec))
            {
                _taskDbContext.CongViecs.RemoveRange(liscongviec);
                await _taskDbContext.SaveChangesAsync();
                return 1;
            }
            return 0;
        }

        public async Task<int> DuyetKeHoachTuan(List<CongViecRequest> congViecRequests)
        {
            try
            {

                foreach (var item in congViecRequests)
                {
                    var congviec = _taskDbContext.CongViecs.Find(item.MaCongViec);

                    congviec.DaDuyet = true;

                    await _taskDbContext.SaveChangesAsync();
                }

                return 1;
            }
            catch (Exception)
            {

                return 0;
            }
        }

        public async Task<List<CongViecResponse>> GetAll(CongViecSearch congViecSearch)
        {
            var query = _taskDbContext.CongViecs.OrderBy(t => t.TuNgay).AsQueryable();

            if (congViecSearch.MaThangLamViec != 0)
                query = query.Where(t => t.MaThangLamViec == congViecSearch.MaThangLamViec);
            if (!string.IsNullOrEmpty(congViecSearch.TenCongViec))
                query = query.Where(t => t.TenCongViec.Contains(congViecSearch.TenCongViec));
            if (congViecSearch.MaTuanChiTiet != 0)
                query = query.Where(t => t.MaTuanChiTiet == congViecSearch.MaTuanChiTiet);
            if (congViecSearch.MaModule != 0)
                query = query.Where(t => t.MaModule == congViecSearch.MaModule);
            if (congViecSearch.MaUser != Guid.Empty)
                query = query.Where(t => t.MaUser == congViecSearch.MaUser);
            if (congViecSearch.TrangThai != 0)
                query = query.Where(t => t.TrangThai == congViecSearch.TrangThai);

            return await query.Select(t => new CongViecResponse()
            {

                MaCongViec = t.MaCongViec,
                MaModule = t.MaModule != null ? t.MaModule.Value : 0,
                IssueURL = t.IssueURL,
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
                TenModule = (t.MaModule != null ? _taskDbContext.Modules.Where(e => e.MaModule == t.MaModule).Single().TenModule : "")
            }).ToListAsync();
        }

        public async Task<List<Module>> GetAllModule()
        {
            var listmodule = await _taskDbContext.Modules.Select(t => t).ToListAsync();

            return listmodule;
        }

        public async Task<int> InsertCongViec(CongViecRequest congViecRequest)
        {

            if (KiemTraDuyetTheoMaTuanChiTiet(congViecRequest.MaTuanChiTiet, congViecRequest.MaUser))
            {
                var Congviec = new CongViec();
                Congviec.MaUser = congViecRequest.MaUser;
                Congviec.MaThangLamViec = congViecRequest.MaThangLamViec;
                Congviec.MaTuanChiTiet = congViecRequest.MaTuanChiTiet;
                Congviec.MaModule = congViecRequest.MaModule != 0 ? congViecRequest.MaModule : null;
                Congviec.TenIssue = congViecRequest.TenIssue;
                Congviec.IssueURL = congViecRequest.IssueURL;
                Congviec.TenCongViec = congViecRequest.TenCongViec;
                Congviec.ThoiGianLam = congViecRequest.ThoiGianLam;
                Congviec.TrangThai = congViecRequest.TrangThai;
                Congviec.TuNgay = congViecRequest.TuNgay;
                Congviec.DenNgay = congViecRequest.DenNgay;
                Congviec.GhiChu = congViecRequest.GhiChu;
                Congviec.Nguon = congViecRequest.Nguon;
                Congviec.DaDuyet = false;

                await _taskDbContext.CongViecs.AddAsync(Congviec);

                await _taskDbContext.SaveChangesAsync();

                return 1;
            }
            return 0;
        }

        public async Task<int> UpdateCongViecRange(List<CongViecRequest> congViecRequests)
        {
            try
            {
                var lstcongviec = congViecRequests.Select(t => new CongViec()
                {
                    MaCongViec = t.MaCongViec,
                    MaUser = t.MaUser,
                    MaThangLamViec = t.MaThangLamViec,
                    MaTuanChiTiet = t.MaTuanChiTiet,
                    MaModule = t.MaModule != 0 ? t.MaModule : null,
                    TenIssue = t.TenIssue,
                    IssueURL = t.IssueURL,
                    TenCongViec = t.TenCongViec,
                    ThoiGianLam = t.ThoiGianLam,
                    TrangThai = t.DaDuyet ? t.TrangThai : (int)STT_CongViec.ChuaLam,
                    TuNgay = t.TuNgay,
                    DenNgay = t.DenNgay,
                    GhiChu = t.GhiChu,
                    Nguon = t.Nguon,
                    DaDuyet = t.DaDuyet
                });

                _taskDbContext.CongViecs.UpdateRange(lstcongviec);

                await _taskDbContext.SaveChangesAsync();

                return 1;
            }
            catch (Exception)
            {

                return 0;
            }
        }

        bool KiemTraDaDuyet(List<CongViec> congViecs)
        {
            foreach (var item in congViecs)
            {
                if (item.DaDuyet)
                {
                    return false;
                }
            }
            return true;
        }

        bool KiemTraDuyetTheoMaTuanChiTiet(int matuanchitiet, Guid MaUser)
        {
            var chitiettuannull = _taskDbContext.CongViecs.Where(t => t.MaUser == MaUser && t.MaTuanChiTiet == matuanchitiet).Count();
            if (chitiettuannull == 0)
            {
                return true;
            }
            var chitiettuan = _taskDbContext.CongViecs.Where(t => t.MaUser == MaUser && t.MaTuanChiTiet == matuanchitiet).FirstOrDefault().DaDuyet;

            if (chitiettuan)
            {
                return false;
            }
            return true;
        }
    }
}
