using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using TASK.Application.MChart;
using TASK.WebApp.Repository.Interface;

namespace TASK.WebApp.Repository.Service
{
    public class ChartServiceClientcs : IChartServiceClient
    {
        public HttpClient httpClient;

        public ChartServiceClientcs(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<List<ChartDashboard>> GetChartDashboards(Guid MaUser, int MaDuAn)
        {          
            var rs = await httpClient.GetFromJsonAsync<List<ChartDashboard>>($"api/Chart/chartDashboard?maduan={MaDuAn}&mauser={MaUser}");
            
            return rs;
        }
    }
}
