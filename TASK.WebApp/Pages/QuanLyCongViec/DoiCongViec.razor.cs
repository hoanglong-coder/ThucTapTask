using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components;
using Radzen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TASK.Application.MChiTietTuan;
using TASK.Application.MCongViec;
using TASK.Application.MTuanLamViec;
using TASK.Data.Enums;
using TASK.WebApp.Repository.Interface;

namespace TASK.WebApp.Pages.QuanLyCongViec
{
    public partial class DoiCongViec
    {
        [Inject] ITuanLamViecServiceClient tuanLamViecServiceClient { get; set; }

        [Inject] IChiTietTuanServiceClient ChiTietTuanServiceClient { get; set; }

        [Inject] ILocalStorageService localstorage { get; set; }

        [Inject] DialogService dialogService { get; set; }

        [Inject] NotificationService NotificationService { get; set; }

        [Inject] ICongViecServiceClient congViecServiceClient { get; set; }

        CongViecRequest congViecRequest = new CongViecRequest();

        List<TuanLamViecResponse> tuanLamViecResponses = new List<TuanLamViecResponse>();

        List<ChiTietTuanResponse> chiTietTuanResponses = new List<ChiTietTuanResponse>();


        [Parameter] public int MaCongViec { get; set; }


        protected override async Task OnInitializedAsync()
        {
            int MaDuAn = await localstorage.GetItemAsync<int>("MaDuAn");

            tuanLamViecResponses = await tuanLamViecServiceClient.GetTuanLamViecByDuAn(MaDuAn);

            congViecRequest = await congViecServiceClient.GetCongViecById(MaCongViec);

        }

        async Task SubmitDoiCongViec()
        {

            if (congViecRequest.TrangThai == (int)STT_CongViec.ChuaXong)
            {
                congViecRequest.Nguon = (int)STT_NguonGoc.DOIDOTRE;

                congViecRequest.CountDoiTre = congViecRequest.CountDoiTre == null ? 1 : congViecRequest.CountDoiTre+1;
            }
            if (congViecRequest.TrangThai == (int)STT_CongViec.ChuaXongBanTaskKhacDaDuyet)
            {
                congViecRequest.Nguon = (int)STT_NguonGoc.DOIDOTXUAT;

                congViecRequest.CountDoiDoDotXuat = congViecRequest.CountDoiDoDotXuat == null ? 1 : congViecRequest.CountDoiDoDotXuat + 1;
            }
            congViecRequest.TrangThai = (int)STT_CongViec.ChuaLam;

            int check = await congViecServiceClient.InsertCongViec(congViecRequest);

            if (check == 1)
            {
                NotificationMessage noti = new NotificationMessage { Severity = NotificationSeverity.Success, Summary = "Dời thành công", Duration = 2000 };
                await ShowNotification(noti);
                dialogService.Close(true);
            }
            else if (check == 0)
            {
                NotificationMessage noti = new NotificationMessage { Severity = NotificationSeverity.Error, Summary = "Không thể dời do tuần sắp dời đã duyệt", Duration = 2000 };
                await ShowNotification(noti);
            }
            else
            {
                NotificationMessage noti = new NotificationMessage { Severity = NotificationSeverity.Error, Summary = "Không thể dời do tuần sắp dời đã khóa", Duration = 2000 };
                await ShowNotification(noti);
            }
        }

        async Task OnChange(object value)
        {
            chiTietTuanResponses = new List<ChiTietTuanResponse>();
            congViecRequest.MaTuanChiTiet = 0;
            chiTietTuanResponses = await ChiTietTuanServiceClient.GetChiTietTuanByTuanLamViec((int)value);
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
