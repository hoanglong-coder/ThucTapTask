using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using TASK.Application.MDuAn;
using TASK.WebApp.Repository.Interface;

namespace TASK.WebApp.Repository.Service
{
    public class DuAnServiceClient : IDuAnServiceClient
    {

        public HttpClient httpClient;

        public DuAnServiceClient(HttpClient httpClient)
        {
            this.httpClient = httpClient;

        }

        public async Task<List<DuAnResponse>> GetDuAnByUser(Guid id)
        {
            var rs = await httpClient.GetFromJsonAsync<List<DuAnResponse>>($"/api/DuAn/{id}");

            return rs;
        }

        async Task<string> IDuAnServiceClient.GetNameDuAn(int id)
        {
            var rs = await httpClient.GetStringAsync($"/api/DuAn/tenduan/{id}");

            return rs;
        }
    }
}
