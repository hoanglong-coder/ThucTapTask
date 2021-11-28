using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TASK.Application.MToDoList;
using TASK.Application.MTuanLamViec;
using TASK.WebApp.Repository.Interface;

namespace TASK.WebApp.Pages.QuanLyCongViec
{
    public partial class QuanLyCongViec
    {
        [Inject] ILocalStorageService localstorage { get; set; }

        [Inject] IToDoServiceClient toDoServiceClient { get; set; }

        List<TuanLamViecResponse> TuanLamViecs = new List<TuanLamViecResponse>();

        public ToDoListResponse toDoList { get; set; }

        public List<ToDoListDTO> toDoListDTOs = new List<ToDoListDTO>();

        IList<TuanLamViecResponse> selectedTuanLamViec;

        int count = 30;

        int pageSize = 4;

        bool timkiemncao { get; set; } = true;

        bool pushpin { get; set; } = true;

        int dem = 1;

        string chuoipush;

        bool checkpush;

        protected override async Task OnInitializedAsync()
        {
            int MaDuAn = await localstorage.GetItemAsync<int>("MaDuAn");

            Guid MaUser = await localstorage.GetItemAsync<Guid>("UserID");

            toDoList = await toDoServiceClient.GetAllToDoByDuAn(MaDuAn, MaUser);

            if (toDoList.Count > 0)
            {
                checkpush = false;              
                toDoListDTOs = toDoList.ListToDo;
                chuoipush = $"Có {toDoList.Count} to do đang được ghim | Đến hạn: {toDoListDTOs.Take(1).FirstOrDefault().NgayDenHang.ToString("dd/MM/yyy")} " +sub(toDoListDTOs.Take(1).FirstOrDefault().NoiDung);
            }
            else
            {
                checkpush = true;
            }                   
        }

        void changepush()
        {
            dem = 1;
            pushpin = !pushpin;
        }

        void change()
        {
            timkiemncao = !timkiemncao;
        }

        string sub(string text)
        {
            if (text.Length < 50)
            {
                return text;
            }else
            {
                return text.Substring(0, 50) + "...";
            }
        }
    }
}
