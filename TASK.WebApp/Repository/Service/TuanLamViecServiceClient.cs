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

        public TuanLamViecServiceClient(HttpClient httpClient)
        {
            this.httpClient = httpClient;

        }

        public async Task<List<TuanLamViecResponse>> GetTuanLamViecByDuAn(int id)
        {
            var lstTuanLamViec = await httpClient.GetFromJsonAsync<List<TuanLamViecResponse>>($"/api/TuanLamViec/{id}");

            return lstTuanLamViec;
        }
    }
}
