using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using TASK.Application.MChiTietTuan;
using TASK.WebApp.Repository.Interface;

namespace TASK.WebApp.Repository.Service
{
    public class ChiTietTuanServiceClient : IChiTietTuanServiceClient
    {
        public HttpClient httpClient;

        public ChiTietTuanServiceClient(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<List<ChiTietTuanResponse>> GetChiTietTuanByTuanLamViec(int id)
        {
            var lstchitiettuan = await httpClient.GetFromJsonAsync<List<ChiTietTuanResponse>>($"/api/chitiettuan/{id}");

            return lstchitiettuan;
        }

        public async Task<int> InsertChiTietTuan(List<ChiTietTuanRequest> lstChitiettuan, int mathanglamviec)
        {
            var chitiettuan =  lstChitiettuan.Select(t => new ChiTietTuanRequest() { 
            
                TenTuan = t.TenTuan,
                GiaTri = t.GiaTri,
                TuNgay = t.TuNgay,
                DenNgay = t.DenNgay,
                SoGioLam = t.SoGioLam,
                TrangThai = t.TrangThai,
                MaThangLamViec = mathanglamviec
            
            });
            var Check = await httpClient.PostAsJsonAsync("/api/ChiTietTuan", chitiettuan);

            var content = await Check.Content.ReadAsStringAsync();

            return int.Parse(content);
        }

        public List<ChiTietTuanRequest> PhatSinhChiTietTuan(DateTime ngaybatdau, DateTime ngayketthuc)
        {
            List<ChiTietTuanRequest> chiTietTuans = new List<ChiTietTuanRequest>();

            DateTime dateTimetemp = ngaybatdau;

            for (int i = 0; i < 4; i++)
            {
                ChiTietTuanRequest chiTietTuan = new ChiTietTuanRequest();
                chiTietTuan.MaTuanChiTiet = i;
                chiTietTuan.TenTuan = "Tuần " + (i + 1);
                chiTietTuan.GiaTri = i + 1;
                chiTietTuan.TuNgay = dateTimetemp;
                chiTietTuan.DenNgay = dateTimetemp.AddDays(4);
                chiTietTuan.SoGioLam = 40;
                chiTietTuan.TrangThai = 0;
                chiTietTuans.Add(chiTietTuan);

                dateTimetemp = chiTietTuan.DenNgay.AddDays(3);
            }

            return chiTietTuans;
        }
    }
}
