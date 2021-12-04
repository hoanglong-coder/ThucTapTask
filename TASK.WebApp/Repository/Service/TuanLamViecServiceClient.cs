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

        public async Task<int> DeleteTuanLamViec(IList<TuanLamViecResponse> tuanLamViecs)
        {
            var Check = await httpClient.PostAsJsonAsync("/api/TuanLamViec/DeleteTuanLamViec", tuanLamViecs);

            var content = await Check.Content.ReadAsStringAsync();

            return int.Parse(content);
        }

        public async Task<int> GetTongGio1Thang(int MaThangLamViec)
        {
            var sogio = await httpClient.GetFromJsonAsync<int>($"/api/TuanLamViec/gettonggio1thang?mathanglamviec={MaThangLamViec}");

            return sogio;
        }

        public async Task<List<TuanLamViecResponse>> GetTuanLamViecByDuAn(int id)
        {
            var lstTuanLamViec = await httpClient.GetFromJsonAsync<List<TuanLamViecResponse>>($"/api/TuanLamViec/{id}");

            return lstTuanLamViec;
        }

        public async Task<TuanLamViecPaging> GetTuanLamViecByDuAnPageing(int id, int skip, int take)
        {
            var lstTuanLamViec = await httpClient.GetFromJsonAsync<TuanLamViecPaging>($"/api/TuanLamViec/gettuanlamviecpaging?id={id}&skip={skip}&take={take}");

            return lstTuanLamViec;
        }

        public async Task<TuanLamViecResponse> GetTuanLamViecByMaThangLamViec(int id)
        {
           
            var tuanlamviec = await httpClient.GetFromJsonAsync<TuanLamViecResponse>($"/api/TuanLamViec/Getchitiettuanlamviec?id={id}");

            return tuanlamviec;

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

        public async Task<int> UpdateTuanLamViec(TuanLamViecRequest tuanLamViecRequest)
        {
            var response = await httpClient.PostAsJsonAsync("/api/TuanLamViec/Updatetuanlamviec", tuanLamViecRequest);

            var content = await response.Content.ReadAsStringAsync();

            return int.Parse(content);
        }
    }
}
