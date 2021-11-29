using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components;
using Radzen;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TASK.Application.MToDoList;
using TASK.Application.MUser;
using TASK.WebApp.Repository.Interface;

namespace TASK.WebApp.Pages.ToDoList
{
    public partial class ThemTodo
    {
        public ToDoListRequest ToDoListRequest = new ToDoListRequest();

        [Inject] DialogService dialogService { get; set; }

        [Inject] IUserServiceClient UserServiceClient { get; set; }

        [Inject] IToDoServiceClient toDoServiceClient { get; set; }

        List<UserResponse> userResponses { get; set; }

        [Inject] ISyncLocalStorageService localstorage { get; set; }

        [Inject] NotificationService NotificationService { get; set; }

        public int checksave = 0;

        protected override async Task OnInitializedAsync()
        {
            int MaDuAn = int.Parse(localstorage.GetItemAsString("MaDuAn"));

            userResponses = await UserServiceClient.GetAllByDuAn(MaDuAn);

            ToDoListRequest.MaDuAn = MaDuAn;

            ToDoListRequest.NgayGiao = DateTime.Now;

            ToDoListRequest.TrangThai = false;
        }

        async Task InsertTodo()
        {
            if (checksave == 0)
            {
                int check = await toDoServiceClient.InsertToDo(ToDoListRequest);

                if (check == 1)
                {
                    NotificationMessage noti = new NotificationMessage { Severity = NotificationSeverity.Success, Summary = "Thêm thành công", Duration = 2000 };
                    await ShowNotification(noti);
                    ClearTodo();
                }
                else
                {
                    NotificationMessage noti = new NotificationMessage { Severity = NotificationSeverity.Error, Summary = "Thêm thất bại", Duration = 2000 };
                    await ShowNotification(noti);
                }
            }
            else
            {

                int check = await toDoServiceClient.InsertToDo(ToDoListRequest);

                if (check == 1)
                {
                    NotificationMessage noti = new NotificationMessage { Severity = NotificationSeverity.Success, Summary = "Thêm thành công", Duration = 2000 };
                    await ShowNotification(noti);
                    ClearTodo();
                    dialogService.Close(true);

                }
                else
                {
                    NotificationMessage noti = new NotificationMessage { Severity = NotificationSeverity.Error, Summary = "Thêm thất bại", Duration = 2000 };
                    await ShowNotification(noti);
                }
            }
        }

        void OnInvalidSubmit()
        {

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
        void changesave()
        {
            checksave = 1;
        }

        void ClearTodo()
        {
            ToDoListRequest.NoiDung = string.Empty;
            ToDoListRequest.MaUser = Guid.Empty;
            ToDoListRequest.NgayDenHang = DateTime.Now;
            ToDoListRequest.GhiChu = string.Empty;
            ToDoListRequest.TrangThai = false;
        }
    }
}
