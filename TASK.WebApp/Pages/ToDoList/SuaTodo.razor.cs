using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components;
using Radzen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TASK.Application.MToDoList;
using TASK.Application.MUser;
using TASK.WebApp.Repository.Interface;

namespace TASK.WebApp.Pages.ToDoList
{
    public partial class SuaTodo
    {
        [Inject] IUserServiceClient UserServiceClient { get; set; }

        [Inject] ISyncLocalStorageService localstorage { get; set; }

        [Inject] DialogService dialogService { get; set; }

        [Inject] IToDoServiceClient toDoServiceClient { get; set; }

        [Inject] NotificationService NotificationService { get; set; }

        List<UserResponse> userResponses { get; set; }

        ToDoListDTO toDoListDTO { get; set; }

        ToDoListRequest ToDoListRequest = new ToDoListRequest();

        [Parameter] public int MaToDo { get; set; }

        protected override async Task OnInitializedAsync()
        {
            int MaDuAn = int.Parse(localstorage.GetItemAsString("MaDuAn"));

            userResponses = await UserServiceClient.GetAllByDuAn(MaDuAn);

            toDoListDTO = await toDoServiceClient.GetTodoById(MaToDo);

            ToDoListRequest.MaTodo = toDoListDTO.MaTodo;
            ToDoListRequest.MaUser = toDoListDTO.MaUser;
            ToDoListRequest.NgayGiao = toDoListDTO.NgayGiao;
            ToDoListRequest.NgayDenHang = toDoListDTO.NgayDenHang;
            ToDoListRequest.NoiDung = toDoListDTO.NoiDung;
            ToDoListRequest.GhiChu = toDoListDTO.GhiChu;
            ToDoListRequest.TrangThai = toDoListDTO.TrangThai;
            ToDoListRequest.MaDuAn = MaDuAn;

        }
        public async Task UpdateTodo()
        {
            int checktodo = await toDoServiceClient.UpdateToDo(ToDoListRequest);

            if (checktodo == 1)
            {
                NotificationMessage noti = new NotificationMessage { Severity = NotificationSeverity.Success, Summary = "Cập nhật thành công", Duration = 2000 };
                await ShowNotification(noti);
                dialogService.Close(true);
            }
            else
            {
                NotificationMessage noti = new NotificationMessage { Severity = NotificationSeverity.Error, Summary = "Cập nhật thất bại", Duration = 2000 };
                await ShowNotification(noti);
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
    }
}
