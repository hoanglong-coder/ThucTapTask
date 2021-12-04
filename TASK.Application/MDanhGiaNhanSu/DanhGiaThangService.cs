using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TASK.Data;
using TASK.Data.Entities;

namespace TASK.Application.MDanhGiaNhanSu
{
    public class DanhGiaThangService : IDanhGiaThangService
    {
        private readonly TaskDbContext _taskDbContext;

        public DanhGiaThangService(TaskDbContext taskDbContext)
        {
            _taskDbContext = taskDbContext;
        }

        public async Task<DanhGiaThangResponse> GetDanhGiaThang(int MaThangLamViec, Guid MaUser)
        {
            var DanhGiaThang = _taskDbContext.DanhGiaThangs.Where(t => t.MaThangLamViec == MaThangLamViec && t.MaUser == MaUser).Select(t=> new DanhGiaThangResponse() {
            
                MaDanhGiaThang = t.MaDanhGiaThang,
                KhoiLuong = t.KhoiLuong,
                TienDo = t.TienDo,
                ChatLuong = t.ChatLuong,
                TrungBinhThang = t.TrungBinhThang,
                XepLoai = t.XepLoai,
                NhanXet = t.NhanXet,
                MaThangLamViec = t.MaThangLamViec,
                MaUser = t.MaUser                      
            }).FirstOrDefault();

            await Task.Delay(100);

            return DanhGiaThang;
        }

        public async Task<int> UpdateDanhGiaThang(DanhGiaThangResponse danhGiaThangResponse)
        {
            try
            {
                var danhgiathang = new DanhGiaThang();
                danhgiathang.MaDanhGiaThang = danhGiaThangResponse.MaDanhGiaThang;
                danhgiathang.KhoiLuong = danhGiaThangResponse.KhoiLuong;
                danhgiathang.TienDo = danhGiaThangResponse.TienDo;
                danhgiathang.ChatLuong = danhGiaThangResponse.ChatLuong;
                danhgiathang.TrungBinhThang = danhGiaThangResponse.TrungBinhThang;
                danhgiathang.XepLoai = danhGiaThangResponse.XepLoai;
                danhgiathang.NhanXet = danhGiaThangResponse.NhanXet;
                danhgiathang.MaThangLamViec = danhGiaThangResponse.MaThangLamViec;
                danhgiathang.MaUser = danhGiaThangResponse.MaUser;

                _taskDbContext.DanhGiaThangs.Update(danhgiathang);

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
