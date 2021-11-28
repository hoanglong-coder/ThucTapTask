using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components;
using Radzen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TASK.Application.MToDoList;
using TASK.WebApp.Repository.Interface;

namespace TASK.WebApp.Pages.ToDoList
{
    public partial class ToDoList
    {
        DateTime? value = DateTime.Now;

        List<ToDoListDTO> toDoListDTOs = new List<ToDoListDTO>();       

        IList<ToDoListDTO> selectedtodo;

        public ToDoListResponse toDoList = new ToDoListResponse();

        [Inject] ILocalStorageService localstorage { get; set; }

        [Inject] IToDoServiceClient toDoServiceClient { get; set; }

        [Inject] DialogService dialogService { get; set; }

        string pagingSummaryFormat = string.Empty;

        int dem = 1;

        int pageSize = 4;

        int count = -1;

        protected override async Task OnInitializedAsync()
        {
            int MaDuAn = await localstorage.GetItemAsync<int>("MaDuAn");

            Guid MaUser = await localstorage.GetItemAsync<Guid>("UserID");

            toDoList = await toDoServiceClient.GetToDoByDuAn(MaDuAn, MaUser, 0, pageSize,true);

            toDoListDTOs = toDoList.ListToDo;

            count = toDoList.Count;
        }
        async Task PageChanged(PagerEventArgs args)
        {
            int MaDuAn = await localstorage.GetItemAsync<int>("MaDuAn");

            Guid MaUser = await localstorage.GetItemAsync<Guid>("UserID");

            toDoList = await toDoServiceClient.GetToDoByDuAn(MaDuAn, MaUser, args.Skip, args.Top,true);

            toDoListDTOs = toDoList.ListToDo;

            dem = args.Skip + 1;
        }

        public async Task InsertToDo()
        {
            await dialogService.OpenAsync<ThemTodo>("THÊM TO-DO", null, new DialogOptions() { Width = "700px", Height = "400px", Resizable = true, Draggable = true });
        }
    }

}
