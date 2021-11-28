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
                    ShowNotification(noti);

                }
                else
                {
                    NotificationMessage noti = new NotificationMessage { Severity = NotificationSeverity.Error, Summary = "Thêm thất bại", Duration = 2000 };
                    ShowNotification(noti);
                }
            }
            else
            {

                int check = await toDoServiceClient.InsertToDo(ToDoListRequest);

                if (check == 1)
                {
                    NotificationMessage noti = new NotificationMessage { Severity = NotificationSeverity.Success, Summary = "Thêm thành công", Duration = 2000 };
                    ShowNotification(noti);

                }
                else
                {
                    NotificationMessage noti = new NotificationMessage { Severity = NotificationSeverity.Error, Summary = "Thêm thất bại", Duration = 2000 };
                    ShowNotification(noti);
                }
            }
        }

        void OnInvalidSubmit()
        {

        }

        void ShowNotification(NotificationMessage message)
        {
            NotificationService.Notify(message);
        }
        void changesave()
        {
            checksave = 1;
        }
    }
}
