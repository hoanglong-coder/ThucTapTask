using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TASK.Data;
using TASK.Data.Entities;
using TASK.Data.Enums;

namespace TASK.Application.MDanhGiaNhanSu
{
    public class DanhGiaTuanService : IDanhGiaTuanService
    {
        private readonly TaskDbContext _taskDbContext;

        public DanhGiaTuanService(TaskDbContext taskDbContext)
        {
            _taskDbContext = taskDbContext;
        }

        public async Task<List<DanhGiaTuanResponse>> GetDanhGiaTuanByDanhGiaThang(int MaDanhGiaThang, Guid MaUser)
        {
            var listtuandanhgia = _taskDbContext.DanhGiaTuans.Where(t => t.MaDanhGiaThang == MaDanhGiaThang).ToList();

            List<DanhGiaTuanResponse> danhgiatuan = new List<DanhGiaTuanResponse>();

            foreach (var item in listtuandanhgia)
            {
                DanhGiaTuanResponse danh = new DanhGiaTuanResponse();

                danh.MaDanhGiaTuan = item.MaDanhGiaTuan;
                danh.HoanThanh = PhanTramHoanThanh(item.MaChiTietTuan,MaUser);
                danh.KhoiLuong = item.KhoiLuong;
                danh.TienDo = item.TienDo;
                danh.ChatLuong = item.ChatLuong;
                danh.LoiTrongTuan = item.LoiTrongTuan;
                danh.NhanXetTuan = item.NhanXetTuan;
                danh.MaDanhGiaThang = item.MaDanhGiaThang;
                danh.MaChiTietTuan = item.MaChiTietTuan;
                danh.TenTuan = _taskDbContext.ChiTietTuans.Where(e => e.MaTuanChiTiet == item.MaChiTietTuan).FirstOrDefault()
                .TenTuan + $"({_taskDbContext.ChiTietTuans.Where(e => e.MaTuanChiTiet == item.MaChiTietTuan).FirstOrDefault().TuNgay.ToString("dd/MM")}-{_taskDbContext.ChiTietTuans.Where(e => e.MaTuanChiTiet == item.MaChiTietTuan).FirstOrDefault().DenNgay.ToString("dd/MM")})";
                danh.TuNgay = _taskDbContext.ChiTietTuans.Where(e => e.MaTuanChiTiet == item.MaChiTietTuan).FirstOrDefault().TuNgay;
                danh.Denngay = _taskDbContext.ChiTietTuans.Where(e => e.MaTuanChiTiet == item.MaChiTietTuan).FirstOrDefault().DenNgay;
                danh.DaKhoa = _taskDbContext.ChiTietTuans.Where(e => e.MaTuanChiTiet == item.MaChiTietTuan).FirstOrDefault().TrangThai;
            
            danhgiatuan.Add(danh);
            }
            await Task.Delay(100);
            return danhgiatuan;
        }

        public async Task<int> UpdateDanhGiaTuan(List<DanhGiaTuanResponse> danhGiaThangResponses)
        {
            try
            {
                var lstdanhgiatuan = danhGiaThangResponses.Select(t => new DanhGiaTuan() { 
                MaDanhGiaTuan = t.MaDanhGiaTuan,
                HoanThanh = t.HoanThanh,
                KhoiLuong = t.KhoiLuong,
                TienDo = t.TienDo,
                ChatLuong = t.ChatLuong,
                LoiTrongTuan = t.LoiTrongTuan,
                NhanXetTuan = t.NhanXetTuan,
                MaDanhGiaThang = t.MaDanhGiaThang,
                MaChiTietTuan = t.MaChiTietTuan                           
                });

                _taskDbContext.DanhGiaTuans.UpdateRange(lstdanhgiatuan);

                await _taskDbContext.SaveChangesAsync();
                return 1;
            }
            catch (Exception)
            {

                return 0;
            }
        }

        public int PhanTramHoanThanh(int MaTuanChiTiet, Guid MaUser)
        {
            var lsscongviec = _taskDbContext.CongViecs.Where(t => t.MaUser == MaUser && t.MaTuanChiTiet == MaTuanChiTiet).ToList();

            int TongThoiGianLamXong = lsscongviec.Where(t => t.TrangThai == (int)STT_CongViec.DaXong || t.TrangThai == (int)STT_CongViec.Vang || t.TrangThai == (int)STT_CongViec.DaXongTaskDotXuat || t.TrangThai == (int)STT_CongViec.ChuaXongBanTaskKhacDaDuyet).Sum(t => t.ThoiGianLam);

            int TongThoiGianDaGiao = lsscongviec.Select(t => t).Sum(t => t.ThoiGianLam);

            double MucDoHoanThanh = (double)TongThoiGianLamXong / TongThoiGianDaGiao;

            int Result = (int)Math.Round(MucDoHoanThanh * 100);

            if (Result < 0)
            {
                return 0;
            }

            return Result;
        }
    }
}
