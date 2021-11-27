using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TASK.Application.MChart;
using TASK.WebApp.Repository.Interface;

namespace TASK.WebApp.Pages.Dashboard
{
    public partial class Dashboard
    {
        [Inject] ILocalStorageService localstorage { get; set; }

        [Inject] IChartServiceClient chartServiceClient { get; set; }

        List<ChartDashboard> chartDashboards { get; set; }
       
        string[] colordashboard;

        protected override async Task OnInitializedAsync()
        {
            int MaDuAn = await localstorage.GetItemAsync<int>("MaDuAn");

            Guid MaUser = await localstorage.GetItemAsync<Guid>("UserID");
         
            chartDashboards = await chartServiceClient.GetChartDashboards(MaUser, MaDuAn);

            colordashboard = new string[chartDashboards.Count];

            for (int i = 0; i < chartDashboards.Count; i++)
            {
                colordashboard[i] = GetColor(chartDashboards[i].MucDoHoanThanh);
            }


        }     
        public string GetColor(int mucdo)
        {
            if (mucdo >= 90)
            {
                return "#006400";
            }else if(mucdo >= 75)
            {
                return "#ffff00";
            }
            else if (mucdo >= 60)
            {
                return "#ff8c00";
            }
            else 
            {
                return "#ee4000";
            }
            
        }
    }
}
