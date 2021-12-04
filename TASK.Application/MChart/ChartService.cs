using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TASK.Data;
using TASK.Application.MDanhGiaNhanSu;
using TASK.Data.Enums;

namespace TASK.Application.MChart
{
    public class ChartService : IChartService
    {
        private readonly TaskDbContext _taskDbContext;

        public ChartService(TaskDbContext taskDbContext)
        {
            _taskDbContext = taskDbContext;
        }

        public async Task<List<ChartDashboard>> GetChartDashboards(Guid MaUser, int MaDuAn)
        {
            if (!KiemTraAdmin(MaUser))
            {
                ChartDashboard chartDashboard = new ChartDashboard();

                List<ChartDashboard> chartDashboards = chartDashboard.DataTemp();

                await Task.Delay(400);

                return chartDashboards;
            }
            else
            {
                ChartDashboard chartDashboard = new ChartDashboard();

                List<ChartDashboard> chartDashboards = chartDashboard.DataTemp();

                await Task.Delay(400);

                return chartDashboards;
            }
        }

        public async Task<List<ChartBaoCaoHieuSuatSoGioLam>> GetChartSoGioLam(int MaDuAn, int MaThangLamViec)
        {
            List<ChartBaoCaoHieuSuatSoGioLam> chart = new List<ChartBaoCaoHieuSuatSoGioLam>();

            var listUser = _taskDbContext.ChiTietDuAns.Where(t => t.MaDuAn == MaDuAn).ToList();

            foreach (var item in listUser)
            {
                ChartBaoCaoHieuSuatSoGioLam t = new ChartBaoCaoHieuSuatSoGioLam();

                t.MaUser = item.MaUser.Value;

                t.TenUser = _taskDbContext.Users.Where(t => t.MaUser == item.MaUser).FirstOrDefault().TenUser;

                t.SoGiolam = TinhSoGioLamNhanSu(item.MaUser.Value, MaThangLamViec);

                chart.Add(t);
            }

            await Task.Delay(100);

            return chart;
        }

        public async Task<List<ChartBaoCaoHieuSuatTrungbinhthang>> GetChartTrungBinhThang(int MaDuAn, int MaThangLamViec)
        {
            List<ChartBaoCaoHieuSuatTrungbinhthang> chart = new List<ChartBaoCaoHieuSuatTrungbinhthang>();

            var listUser = _taskDbContext.ChiTietDuAns.Where(t => t.MaDuAn == MaDuAn).ToList();

            foreach (var item in listUser)
            {
                ChartBaoCaoHieuSuatTrungbinhthang t = new ChartBaoCaoHieuSuatTrungbinhthang();

                t.MaUser = item.MaUser.Value;

                t.TenUser = _taskDbContext.Users.Where(t => t.MaUser == item.MaUser).FirstOrDefault().TenUser;

                t.PhanTramLamViec = TBPhanTramHoanThanh(item.MaUser.Value, MaThangLamViec);

                chart.Add(t);
            }

            await Task.Delay(100);

            return chart;
        }

        public bool KiemTraAdmin(Guid UserId)
        {
            var check = _taskDbContext.Users.Where(t => t.MaUser == UserId).SingleOrDefault();

            if (check.MaQuyenHeThong == 1)
            {
                return true;
            }
            return false;
        }


        public int TinhSoGioLamNhanSu(Guid MaUser, int MaThangLamViec)
        {
            int sum = _taskDbContext.CongViecs.Where(t => t.MaUser == MaUser && t.MaThangLamViec == MaThangLamViec).Sum(t => t.ThoiGianLam);

            if (sum != 0)
            {
                return sum;
            }
            return 0;
        }


        public int TBPhanTramHoanThanh(Guid MaUser, int MaThangLamViec)
        {
            var phantram = _taskDbContext.DanhGiaThangs.Where(t => t.MaUser == MaUser && t.MaThangLamViec == MaThangLamViec).SingleOrDefault();

            if (phantram != null)
            {
                return phantram.TrungBinhThang.Value;
            }
            return 0;
        }

        public async Task<List<NhanXet>> getnhanxet(int MaDuAn, int MaThangLamViec)
        {
            var listuser = _taskDbContext.ChiTietDuAns.Where(t => t.MaDuAn == MaDuAn).ToList();
            var listnhanxet = new List<NhanXet>();

            foreach (var item in listuser)
            {
                NhanXet n = new NhanXet();

                n.MaUser = item.MaUser.Value;
                n.TenUser = _taskDbContext.Users.Where(t => t.MaUser == item.MaUser).SingleOrDefault().TenUser;
                n.XepLoai = GetXepLoai(MaThangLamViec, item.MaUser.Value);
                n.NhanXetThang = GetNhanXetThang(MaThangLamViec, item.MaUser.Value);
                n.HoanThanh = GetTrungBinhThang(MaThangLamViec, item.MaUser.Value);

                var MaDanhGiaThang = _taskDbContext.DanhGiaThangs.Where(t => t.MaThangLamViec == MaThangLamViec && t.MaUser == item.MaUser).Count();
                if (MaDanhGiaThang != 0)
                {
                    var list = await GetDanhGiaTuanByDanhGiaThang(_taskDbContext.DanhGiaThangs.Where(t => t.MaThangLamViec == MaThangLamViec && t.MaUser == item.MaUser).SingleOrDefault().MaDanhGiaThang, item.MaUser.Value);
                    n.chitietNhanXets = list.Select(t => new ChitietNhanXet()
                    {

                        MaTuanChiTiet = t.MaChiTietTuan,
                        TenTuan = t.TenTuan,
                        DenNgay = t.Denngay,
                        TuNgay = t.TuNgay,
                        HoanThanh = t.HoanThanh,
                        LoiTrongTuan = t.LoiTrongTuan,
                        NhanXetTuan = t.NhanXetTuan,
                        SoGioLam = _taskDbContext.CongViecs.Where(e => e.MaThangLamViec == MaThangLamViec && e.MaTuanChiTiet == t.MaChiTietTuan && e.MaUser == item.MaUser).Sum(t => t.ThoiGianLam)

                    }).ToList();
                }

               


                listnhanxet.Add(n);
            }
            await Task.Delay(100);
            return listnhanxet;
        }


        public int? GetXepLoai(int MaThangLamViec, Guid MaUser)
        {
            try
            {
                var xeploai = _taskDbContext.DanhGiaThangs.Where(t => t.MaThangLamViec == MaThangLamViec && t.MaUser == MaUser).Count();

                if (xeploai != 0)
                {
                    return _taskDbContext.DanhGiaThangs.Where(t => t.MaThangLamViec == MaThangLamViec && t.MaUser == MaUser).FirstOrDefault().XepLoai.Value;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception)
            {

                return null;
            }

        }

        public string GetNhanXetThang(int MaThangLamViec, Guid MaUser)
        {
            var nhanxet = _taskDbContext.DanhGiaThangs.Where(t => t.MaThangLamViec == MaThangLamViec && t.MaUser == MaUser).Count();

            if (nhanxet != 0)
            {
                return _taskDbContext.DanhGiaThangs.Where(t => t.MaThangLamViec == MaThangLamViec && t.MaUser == MaUser).SingleOrDefault().NhanXet;
            }
            else
            {
                return "";
            }
        }
        public int? GetTrungBinhThang(int MaThangLamViec, Guid MaUser)
        {
            var nhanxet = _taskDbContext.DanhGiaThangs.Where(t => t.MaThangLamViec == MaThangLamViec && t.MaUser == MaUser).Count();

            if (nhanxet != 0)
            {
                return _taskDbContext.DanhGiaThangs.Where(t => t.MaThangLamViec == MaThangLamViec && t.MaUser == MaUser).SingleOrDefault().TrungBinhThang.Value;
            }
            else
            {
                return null;
            }
        }

        public Task<List<ChitietNhanXet>> getchitietnhanxet(int MaDuAn, int MaThangLamViec)
        {
            throw new NotImplementedException();
        }

        public async Task<List<DanhGiaTuanResponse>> GetDanhGiaTuanByDanhGiaThang(int MaDanhGiaThang, Guid MaUser)
        {
            var listtuandanhgia = _taskDbContext.DanhGiaTuans.Where(t => t.MaDanhGiaThang == MaDanhGiaThang).ToList();

            List<DanhGiaTuanResponse> danhgiatuan = new List<DanhGiaTuanResponse>();

            foreach (var item in listtuandanhgia)
            {
                DanhGiaTuanResponse danh = new DanhGiaTuanResponse();

                danh.MaDanhGiaTuan = item.MaDanhGiaTuan;
                danh.HoanThanh = PhanTramHoanThanh(item.MaChiTietTuan, MaUser);
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
