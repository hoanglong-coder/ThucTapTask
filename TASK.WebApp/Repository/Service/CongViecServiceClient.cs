using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using TASK.Application.MCongViec;
using TASK.Data.Entities;
using TASK.WebApp.Repository.Interface;

namespace TASK.WebApp.Repository.Service
{
    public class CongViecServiceClient : ICongViecServiceClient
    {
        public HttpClient httpClient;

        public CongViecServiceClient(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<int> DeleteCongViecRange(List<CongViecRequest> congViecRequests)
        {
            var check = await httpClient.PostAsJsonAsync("/api/CongViec/DeleteCongViec", congViecRequests);

            var content = await check.Content.ReadAsStringAsync();

            return int.Parse(content);
        }

        public async Task<int> DuyetKeHoachTuan(List<CongViecRequest> congViecRequests)
        {
            var check = await httpClient.PostAsJsonAsync("/api/CongViec/DuyetCongViecRange", congViecRequests);

            var content = await check.Content.ReadAsStringAsync();

            return int.Parse(content);
        }

        public async Task<List<CongViecResponse>> GetAll(CongViecSearch congViecSearch)
        {

            string url = $"/api/CongViec?MaThangLamViec={congViecSearch.MaThangLamViec}&MaTuanChiTiet={congViecSearch.MaTuanChiTiet}&MaModule={congViecSearch.MaModule}&TenCongViec={congViecSearch.TenCongViec}&MaUser={congViecSearch.MaUser}&TrangThai={congViecSearch.TrangThai}";

            var lst = await httpClient.GetFromJsonAsync<List<CongViecResponse>>(url);

            return lst;
        }

        public async Task<List<Module>> GetAllModule()
        {           
            var lst = await httpClient.GetFromJsonAsync<List<Module>>($"/api/CongViec/getmoduel");

            return lst;
        }

        public async Task<CongViecRequest> GetCongViecById(int MaCongViec)
        {
            var congviecrequest = await httpClient.GetFromJsonAsync<CongViecRequest>($"/api/CongViec/GetCongViecByID?macongviec={MaCongViec}");

            return congviecrequest;
        }

        public async Task<int> InsertCongViec(CongViecRequest congViecRequest)
        {
            var check = await httpClient.PostAsJsonAsync("/api/CongViec/InsertCongViec", congViecRequest);

            var content = await check.Content.ReadAsStringAsync();

            return int.Parse(content);
        }

        public async Task<int> UpdateCongViecRange(List<CongViecRequest> congViecRequests)
        {
            var check = await httpClient.PostAsJsonAsync("/api/CongViec/UpdateCongViecRange", congViecRequests);

            var content = await check.Content.ReadAsStringAsync();

            return int.Parse(content);
        }
    }
}
