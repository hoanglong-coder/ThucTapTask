using Blazored.LocalStorage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using TASK.Application.MTuanLamViec;
using TASK.WebApp.Repository.Interface;

namespace TASK.WebApp.Repository.Service
{
    public class TuanLamViecServiceClient : ITuanLamViecServiceClient
    {
        public HttpClient httpClient;

        public ILocalStorageService localStorageService;

        public TuanLamViecServiceClient(HttpClient httpClient, ILocalStorageService localStorageService)
        {
            this.httpClient = httpClient;
            this.localStorageService = localStorageService;
        }

        public async Task<List<TuanLamViecResponse>> GetTuanLamViecByDuAn(int id)
        {
            var lstTuanLamViec = await httpClient.GetFromJsonAsync<List<TuanLamViecResponse>>($"/api/TuanLamViec/{id}");

            return lstTuanLamViec;
        }

        public async Task<int> InsertTuanLamViec(TuanLamViecRequest tuanLamViec)
        {

            int MaDuAn = await localStorageService.GetItemAsync<int>("MaDuAn");

            TuanLamViecRequest tlv = new TuanLamViecRequest();
            tlv.TenThang = tuanLamViec.TenThang;
            tlv.NgayBatDau = tuanLamViec.NgayBatDau;
            tlv.NgayKetThuc = tuanLamViec.NgayKetThuc;
            tlv.GiaTri = tuanLamViec.GiaTri;
            tlv.MaDuAn = MaDuAn;


            var MaTuanLamViec = await httpClient.PostAsJsonAsync("/api/TuanLamViec", tlv);

            var content = await MaTuanLamViec.Content.ReadAsStringAsync();

            return int.Parse(content);
        }
    }
}
