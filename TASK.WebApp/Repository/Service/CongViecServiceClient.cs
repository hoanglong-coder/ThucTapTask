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

        public async Task<List<CongViecResponse>> GetAll()
        {
            var lst = await httpClient.GetFromJsonAsync<List<CongViecResponse>>($"/api/CongViec");

            return lst;
        }

        public async Task<List<Module>> GetAllModule()
        {           
            var lst = await httpClient.GetFromJsonAsync<List<Module>>($"/api/CongViec/getmoduel");

            return lst;
        }
    }
}
