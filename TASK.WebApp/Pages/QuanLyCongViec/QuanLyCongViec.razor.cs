using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components;
using Radzen;
using Radzen.Blazor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TASK.Application.MCongViec;
using TASK.Application.MToDoList;
using TASK.Application.MTuanLamViec;
using TASK.Data.Entities;
using TASK.WebApp.Repository.Interface;

namespace TASK.WebApp.Pages.QuanLyCongViec
{
    public partial class QuanLyCongViec
    {
        DateTime? value = DateTime.Now;

        [Inject] ILocalStorageService localstorage { get; set; }

        [Inject] IToDoServiceClient toDoServiceClient { get; set; }

        [Inject] ITuanLamViecServiceClient tuanLamViecService { get; set; }

        [Inject] ICongViecServiceClient congViecServiceClient { get; set; }

        [Inject] TooltipService tooltipService { get; set; }

        [Inject] DialogService dialogService { get; set; }

        TuanLamViecPaging TuanLamViecPaging { get; set; }

        List<TuanLamViecResponse> TuanLamViecs = new List<TuanLamViecResponse>();

        List<Module> Listmodule = new List<Module>();

        RadzenDataGrid<CongViecResponse> congviecsGrid;

        public ToDoListResponse toDoList { get; set; }

        public List<ToDoListDTO> toDoListDTOs = new List<ToDoListDTO>();

        IList<CongViecResponse> selectedCongViec;

        List<CongViecResponse> congViecResponses { get; set; }


        int count = 30;

        int pageSize = 4;

        bool timkiemncao { get; set; } = true;

        bool pushpin { get; set; } = true;

        int dem = 1;

        string chuoipush;

        bool checkpush;

        protected override async Task OnInitializedAsync()
        {
            dialogService.OnClose += Close;

            int MaDuAn = await localstorage.GetItemAsync<int>("MaDuAn");

            Guid MaUser = await localstorage.GetItemAsync<Guid>("UserID");

            toDoList = await toDoServiceClient.GetAllToDoByDuAn(MaDuAn, MaUser);

            congViecResponses = await congViecServiceClient.GetAll();

            Listmodule = await congViecServiceClient.GetAllModule();

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

            TuanLamViecPaging = await tuanLamViecService.GetTuanLamViecByDuAnPageing(MaDuAn, 0, pageSize);

            count = TuanLamViecPaging.Count;

            TuanLamViecs = TuanLamViecPaging.ListTuanLamViecRequest;
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
        void OnRender(DataGridRenderEventArgs<CongViecResponse> args)
        {
            if (args.FirstRender)
            {
                args.Grid.Groups.Add(new GroupDescriptor() { Property = "MaUser",Title="Mã User" });
                StateHasChanged();
            }
        }
        void Action()
        {
            Console.WriteLine("Thực thi");
        }

        void EditRow(CongViecResponse order)
        {
            congviecsGrid.EditRow(order);
        }

        void SaveRow(CongViecResponse order)
        {
            Console.WriteLine("đã nhấp");
            congviecsGrid.UpdateRow(order);
        }

        void CancelEdit(CongViecResponse order)
        {
            congviecsGrid.CancelEditRow(order);
        }

        void ShowTooltip(ElementReference elementReference, TooltipOptions options = null) => tooltipService.Open(elementReference, "Dời do trể 3 lần", options);


        async Task InsertCongViec()
        {
            await dialogService.OpenAsync<ThemCongViec>("THÊM CÔNG VIỆC TUẦN", null, new DialogOptions() { Width = "772px", Height = "611px", Resizable = true, Draggable = true });
        }

        async void Close(dynamic result)
        {
        }
    }
}
