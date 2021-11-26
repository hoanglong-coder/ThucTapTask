using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components;
using Radzen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Threading.Tasks;
using TASK.Application.MChiTietTuan;
using TASK.Application.MTuanLamViec;
using TASK.WebApp.Repository.Interface;

namespace TASK.WebApp.Pages.TuanLamViec
{
    public partial class TuanLamViec
    {
        IList<TuanLamViecResponse> selectedTuanLamViec;

        IList<ChiTietTuanResponse> selectedEChitiettuan;

        [Inject] ITuanLamViecServiceClient tuanLamViecService { get; set; }

        [Inject] IChiTietTuanServiceClient chiTietTuanService { get; set; }

        [Inject] ISyncLocalStorageService localstorage { get; set; }

        [Inject] DialogService dialogService { get; set; }

        [Inject] NotificationService NotificationService { get; set; }

        List<TuanLamViecResponse> TuanLamViecs { get; set; }

        List<ChiTietTuanResponse> ChiTietTuans = new List<ChiTietTuanResponse>();

        List<DateTime> Name = new List<DateTime>();



        protected override async Task OnInitializedAsync()
        {
            int MaDuAn = int.Parse(localstorage.GetItemAsString("MaDuAn"));

            TuanLamViecs = await tuanLamViecService.GetTuanLamViecByDuAn(MaDuAn);

            dialogService.OnClose += Close;
        }

        public void Click(TuanLamViecResponse tuanLamViec)
        {
            Console.WriteLine($"Da click{tuanLamViec.TenThang}");
        }

        async Task RowExpandAsync(TuanLamViecResponse TuanLamViec)
        {
            ChiTietTuans = await chiTietTuanService.GetChiTietTuanByTuanLamViec(TuanLamViec.MaThangLamViec);
        }

        public async Task ThemTuanLamViec()
        {
            await dialogService.OpenAsync<ThemSuaTuanLamViec>("THÊM TUẦN LÀM VIỆC",null, new DialogOptions() { Width = "700px", Height = "530px", Resizable = true, Draggable = true });

        }
        void Close(dynamic result)
        {

        }
        async Task reset()
        {
            TuanLamViecs.Clear();

            Console.WriteLine("restet");

            int MaDuAn = int.Parse(localstorage.GetItemAsString("MaDuAn"));

            TuanLamViecs = await tuanLamViecService.GetTuanLamViecByDuAn(MaDuAn);
        }

        async Task DeletteAsync()
        {
            if (selectedTuanLamViec != null)
            {
                int check = await tuanLamViecService.DeleteTuanLamViec(selectedTuanLamViec);

                if (check == 1)
                {
                    NotificationMessage noti = new NotificationMessage { Severity = NotificationSeverity.Success, Summary = "Xóa thành công", Duration = 2000 };
                    ShowNotification(noti);
                    selectedTuanLamViec.Clear();
                    await reset();
                }
                else
                {
                    NotificationMessage noti = new NotificationMessage { Severity = NotificationSeverity.Error, Summary = "Không thể xóa do đã lên công việc", Duration = 2000 };
                    selectedTuanLamViec.Clear();
                    ShowNotification(noti);
                }
            }
            if (selectedEChitiettuan != null)
            {
                int check = await chiTietTuanService.DeleteChiTietTuan(selectedEChitiettuan);
                
                if(check==1)
                {
                    NotificationMessage noti = new NotificationMessage { Severity = NotificationSeverity.Success, Summary = "Xóa thành công", Duration = 2000 };
                    ShowNotification(noti);
                    selectedEChitiettuan.Clear();
                    await reset();
                }
                else
                {
                    NotificationMessage noti = new NotificationMessage { Severity = NotificationSeverity.Error, Summary = "Không thể xóa do đã lên công việc", Duration = 2000 };
                    selectedTuanLamViec.Clear();
                    ShowNotification(noti);
                }
            }
            
        }
        void ShowNotification(NotificationMessage message)
        {
            NotificationService.Notify(message);
        }
    }
}
