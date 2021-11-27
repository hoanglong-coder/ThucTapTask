using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components;
using Radzen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TASK.Application.MToDoList;
using TASK.WebApp.Repository.Interface;

namespace TASK.WebApp.Pages.Dashboard
{
    public partial class ToDoListDashboard
    {
        public ToDoListResponse toDoList = new ToDoListResponse();

        public List<ToDoListDTO> toDoListDTOs = new List<ToDoListDTO>();

        [Inject] ILocalStorageService localstorage { get; set; }

        [Inject] IToDoServiceClient toDoServiceClient { get; set; }

        string pagingSummaryFormat = string.Empty;

        int dem = 1;

        int pageSize = 4;

        int count = -1;

        protected override async Task OnInitializedAsync()
        {
            int MaDuAn = await localstorage.GetItemAsync<int>("MaDuAn");

            Guid MaUser = await localstorage.GetItemAsync<Guid>("UserID");

            toDoList = await toDoServiceClient.GetToDoByDuAn(MaDuAn, MaUser, 0, pageSize);

            toDoListDTOs = toDoList.ListToDo;

            count = toDoList.Count;
        }
        async Task PageChanged(PagerEventArgs args)
        {
            int MaDuAn = await localstorage.GetItemAsync<int>("MaDuAn");

            Guid MaUser = await localstorage.GetItemAsync<Guid>("UserID");

            toDoList = await toDoServiceClient.GetToDoByDuAn(MaDuAn, MaUser, args.Skip, args.Top);

            toDoListDTOs = toDoList.ListToDo;

            dem = args.Skip + 1;
        }

    }
}
