using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using TASK.Application.MDanhGiaNhanSu;
using TASK.WebApp.Repository.Interface;

namespace TASK.WebApp.Repository.Service
{
    public class DanhGiaNhanSuServiceClient : IDanhGiaNhanSuServiceClient
    {
        public HttpClient httpClient;

        public DanhGiaNhanSuServiceClient(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<DanhGiaThangResponse> GetDanhGiaThang(int MaThangLamViec, Guid MaUser)
        {
            var danhgiathang = await httpClient.GetFromJsonAsync<DanhGiaThangResponse>($"/api/DanhGiaThang/GetDanhGiaThang?MaThangLamViec={MaThangLamViec}&MaUser={MaUser}");

            return danhgiathang;
        }

        public async Task<List<DanhGiaTuanResponse>> GetDanhGiaTuanByDanhGiaThang(int MaDanhGiaThang, Guid MaUser)
        {
            var danhgiatuan = await httpClient.GetFromJsonAsync<List<DanhGiaTuanResponse>>($"/api/DanhGiaThang/GetDanhGiatuan?MaDanhGiaThang={MaDanhGiaThang}&MaUser={MaUser}");

            return danhgiatuan;
        }

        public async Task<int> UpdateDanhGiaThang(DanhGiaThangResponse danhGiaThangResponse)
        {
            var check = await httpClient.PostAsJsonAsync("/api/DanhGiaThang/UpdateDanhGiaThang", danhGiaThangResponse);

            var content = await check.Content.ReadAsStringAsync();

            return int.Parse(content);
        }

        public async Task<int> UpdateDanhGiaTuan(List<DanhGiaTuanResponse> danhGiaThangResponses)
        {
            var check = await httpClient.PostAsJsonAsync("/api/DanhGiaThang/UpdateDanhGiaTuan", danhGiaThangResponses);

            var content = await check.Content.ReadAsStringAsync();

            return int.Parse(content);
        }
    }
}
