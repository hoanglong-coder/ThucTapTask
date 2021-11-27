using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using Radzen;
using Radzen.Blazor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TASK.Application.MChiTietTuan;
using TASK.Application.MTuanLamViec;
using TASK.WebApp.Repository.Interface;

namespace TASK.WebApp.Pages.TuanLamViec
{
    public partial class ThemTuanLamViec
    {

        [Inject] IChiTietTuanServiceClient tietTuanServiceClient { get; set; }

        [Inject] ITuanLamViecServiceClient tuanLamViecServiceClient { get; set; }

        [Inject] DialogService dialogService { get; set; }

        [Inject] NotificationService NotificationService { get; set; }

        public TuanLamViecRequest TuanLamViecRequest = new TuanLamViecRequest();

        List<ChiTietTuanRequest> data = new List<ChiTietTuanRequest>();

        RadzenDataGrid<ChiTietTuanRequest> chitiettuangrid;

        public int checksave = 0;


        void PhatSinhTuan()
        {
            data.Clear();
            data = tietTuanServiceClient.PhatSinhChiTietTuan(TuanLamViecRequest.NgayBatDau, TuanLamViecRequest.NgayKetThuc);
        }

        void EditRow(ChiTietTuanRequest order)
        {
            chitiettuangrid.EditRow(order);
        }

        void SaveRow(ChiTietTuanRequest order)
        {
            chitiettuangrid.UpdateRow(order);
        }

        void CancelEdit(ChiTietTuanRequest order)
        {
            chitiettuangrid.CancelEditRow(order);
        }
        async Task InsertTuanLamViecLuuThem()
        {
            

            if (checksave == 0)
            {
                int mathanglamviec = await tuanLamViecServiceClient.InsertTuanLamViec(TuanLamViecRequest);

                int check = await tietTuanServiceClient.InsertChiTietTuan(data, mathanglamviec);

                if (check == 1)
                {
                    NotificationMessage noti = new NotificationMessage { Severity = NotificationSeverity.Success, Summary = "Thêm thành công", Duration = 2000 };
                    ShowNotification(noti);
                    data.Clear();
                    TuanLamViecRequest.Clear();

                }
                else
                {
                    NotificationMessage noti = new NotificationMessage { Severity = NotificationSeverity.Error, Summary = "Thêm thất bại", Duration = 2000 };
                    ShowNotification(noti);
                }
            }else
            {
                
                int mathanglamviec = await tuanLamViecServiceClient.InsertTuanLamViec(TuanLamViecRequest);

                int check = await tietTuanServiceClient.InsertChiTietTuan(data, mathanglamviec);

                if (check == 1)
                {
                    NotificationMessage noti = new NotificationMessage { Severity = NotificationSeverity.Success, Summary = "Thêm thành công", Duration = 2000 };
                    ShowNotification(noti);
                    TuanLamViecRequest.Clear();
                    data.Clear();
                    dialogService.Close(true);

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
