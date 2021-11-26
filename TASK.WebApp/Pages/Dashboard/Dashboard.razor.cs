using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TASK.Application.MChart;
using TASK.Application.MToDoList;
using TASK.WebApp.Repository.Interface;

namespace TASK.WebApp.Pages.Dashboard
{
    public partial class Dashboard
    {
        [Inject] ILocalStorageService localstorage { get; set; }

        [Inject] IToDoServiceClient toDoServiceClient { get; set; }

        [Inject] IChartServiceClient chartServiceClient { get; set; }


        List<ChartDashboard> chartDashboards = new List<ChartDashboard>();

        public List<ToDoListResponse> toDoLists = new List<ToDoListResponse>();

        protected override async Task OnInitializedAsync()
        {
            int MaDuAn = await localstorage.GetItemAsync<int>("MaDuAn");

            Guid MaUser  = await localstorage.GetItemAsync<Guid>("UserID");

            toDoLists = await toDoServiceClient.GetToDoByDuAn(MaDuAn, MaUser);

            chartDashboards = await chartServiceClient.GetChartDashboards(MaUser, MaDuAn);
        }
    }
}
