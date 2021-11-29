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

        [Inject] NotificationService NotificationService { get; set; }

        [Inject] ILocalStorageService localstorage { get; set; }

        [Inject] IToDoServiceClient toDoServiceClient { get; set; }

        [Inject] DialogService dialogService { get; set; }

        string pagingSummaryFormat = string.Empty;

        int dem = 1;

        int pageSize = 4;

        int count = -1;

        int skippage = 0;

        int takepage = 4;

        int Role;

        protected override async Task OnInitializedAsync()
        {
            int MaDuAn = await localstorage.GetItemAsync<int>("MaDuAn");

            Guid MaUser = await localstorage.GetItemAsync<Guid>("UserID");

            Role = await localstorage.GetItemAsync<int>("Role");

            toDoList = await toDoServiceClient.GetToDoByDuAn(MaDuAn, MaUser, 0, pageSize,true);

            toDoListDTOs = toDoList.ListToDo;

            count = toDoList.Count;

            dialogService.OnClose += Close;


        }
        async Task PageChanged(PagerEventArgs args)
        {
            skippage = args.Skip;
            takepage = args.Top;

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

        public async Task DeleteToDo()
        {
            if (selectedtodo != null)
            {

                int check = await toDoServiceClient.DeleteTodo(selectedtodo);

                if (check == 1)
                {
                    NotificationMessage noti = new NotificationMessage { Severity = NotificationSeverity.Success, Summary = "Xóa thành công", Duration = 2000 };
                    await ShowNotification(noti);
                    selectedtodo = new List<ToDoListDTO>();
                    await reset();
                }else
                {
                    NotificationMessage noti = new NotificationMessage { Severity = NotificationSeverity.Success, Summary = "Xóa thất bại", Duration = 2000 };
                    await ShowNotification(noti);
                    selectedtodo = new List<ToDoListDTO>();
                    await reset();
                }
            }
        }

        public async Task SuaTodo(ToDoListDTO toDoListDTO)
        {

            await dialogService.OpenAsync<SuaTodo>($"Sửa TO-DO",
                                                        new Dictionary<string, object>() { { "MaToDo", toDoListDTO.MaTodo } },
                                                        new DialogOptions() { Width = "700px", Height = "400px", Resizable = true, Draggable = true });

        }

        async void Close(dynamic result)
        {
            await reset();
        }

        async Task reset()
        {
            int MaDuAn = await localstorage.GetItemAsync<int>("MaDuAn");

            Guid MaUser = await localstorage.GetItemAsync<Guid>("UserID");

            toDoList = await toDoServiceClient.GetToDoByDuAn(MaDuAn, MaUser, skippage, takepage, true);

            toDoListDTOs = toDoList.ListToDo;

            count = toDoList.Count;

            StateHasChanged();
        }

        async Task ShowNotification(NotificationMessage message)
        {
            Task task = new Task(() =>
            {
                NotificationService.Notify(message);
            });

            task.Start();

            await task;

        }


    }

}
