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
                TenModule = (t.MaModule != null ? _taskDbContext.Modules.Where(e => e.MaModule == t.MaModule).Single().TenModule : ""),
                CountDoiDoDotXuat = t.CountDoiDoDotXuat,
                CountDoiTre = t.CountDoiTre
            }).ToListAsync();
        }

        public async Task<List<Module>> GetAllModule()
        {
            var listmodule = await _taskDbContext.Modules.Select(t => t).ToListAsync();

            return listmodule;
        }

        public async Task<int> InsertCongViec(CongViecRequest congViecRequest)
        {
            if (await KiemTraKhoaTuan(congViecRequest.MaTuanChiTiet))
            {
                return 2;
            }
            else if (KiemTraDuyetTheoMaTuanChiTiet(congViecRequest.MaTuanChiTiet, congViecRequest.MaUser))
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
                Congviec.CountDoiTre = congViecRequest.CountDoiTre;
                Congviec.CountDoiDoDotXuat = congViecRequest.CountDoiDoDotXuat;

                int kiemtra = InsertDanhGiaNhanSuThang(congViecRequest.MaThangLamViec, congViecRequest.MaUser);

                if (kiemtra != 0)
                {
                    InsertDanhGiaTuan(kiemtra, congViecRequest.MaThangLamViec);
                }

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
                    DaDuyet = t.DaDuyet,
                    CountDoiDoDotXuat = t.CountDoiDoDotXuat,
                    CountDoiTre = t.CountDoiTre
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

        public async Task<bool> KiemTraKhoaTuan(int machitiettuan)
        {
            var chitiettuan = await _taskDbContext.ChiTietTuans.FindAsync(machitiettuan);

            if (chitiettuan.TrangThai)
            {
                return true;
            }
            return false;
        }

        public async Task<CongViecRequest> GetCongViecById(int MaCongViec)
        {
            CongViec congviec = await _taskDbContext.CongViecs.FindAsync(MaCongViec);

            CongViecRequest congViecRequest = new CongViecRequest();
            congViecRequest.MaModule = congviec.MaModule==null?0: congviec.MaModule.Value;
            congViecRequest.IssueURL = congviec.IssueURL;
            congViecRequest.TenIssue = congviec.TenIssue;
            congViecRequest.TenCongViec = congviec.TenCongViec;
            congViecRequest.Nguon = congviec.Nguon;
            congViecRequest.ThoiGianLam = congviec.ThoiGianLam;
            congViecRequest.TuNgay = congviec.TuNgay;
            congViecRequest.DenNgay = congviec.DenNgay;
            congViecRequest.MaThangLamViec = congviec.MaThangLamViec.Value;
            congViecRequest.MaTuanChiTiet = congviec.MaTuanChiTiet.Value;
            congViecRequest.MaUser = congviec.MaUser.Value;
            congViecRequest.GhiChu = congviec.GhiChu;
            congViecRequest.TrangThai = congviec.TrangThai;
            congViecRequest.DaDuyet = congviec.DaDuyet;
            congViecRequest.CountDoiTre = congviec.CountDoiTre;
            congViecRequest.CountDoiDoDotXuat = congviec.CountDoiDoDotXuat;
            return congViecRequest;
        }
    
    
        public int InsertDanhGiaNhanSuThang(int MaThanLamViec,Guid MaUser)
        {
            var IsDanhGia = _taskDbContext.DanhGiaThangs.Where(t => t.MaThangLamViec == MaThanLamViec && t.MaUser == MaUser).Count();

            if (IsDanhGia==0)
            {
                DanhGiaThang danhGiaThang = new DanhGiaThang();
                danhGiaThang.MaThangLamViec = MaThanLamViec;
                danhGiaThang.MaUser = MaUser;

                _taskDbContext.DanhGiaThangs.Add(danhGiaThang);

                _taskDbContext.SaveChanges();
                int rs = _taskDbContext.DanhGiaThangs.OrderByDescending(t => t.MaDanhGiaThang).FirstOrDefault().MaDanhGiaThang;
                return rs;
            }
            return 0;
        }

        public void InsertDanhGiaTuan(int MaDanhGiaThang, int MaThangLamViec)
        {
            List<ChiTietTuan> chiTietTuans = _taskDbContext.ChiTietTuans.Where(t => t.MaThangLamViec==MaThangLamViec).ToList();


            foreach (var item in chiTietTuans)
            {
                DanhGiaTuan danhGiaTuan = new DanhGiaTuan();
                danhGiaTuan.MaDanhGiaThang = MaDanhGiaThang;
                danhGiaTuan.MaChiTietTuan = item.MaTuanChiTiet;

                _taskDbContext.DanhGiaTuans.Add(danhGiaTuan);

                _taskDbContext.SaveChanges();
            }
        }
    }
}
