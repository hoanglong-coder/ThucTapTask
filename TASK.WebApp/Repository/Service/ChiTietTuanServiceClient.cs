using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using TASK.Application.MChiTietTuan;
using TASK.Application.MTuanLamViec;
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

    }
}
