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
    public partial class ThemSuaTuanLamViec
    {

        [Inject] IChiTietTuanServiceClient tietTuanServiceClient { get; set; }

        [Inject] ITuanLamViecServiceClient tuanLamViecServiceClient { get; set; }

        [Inject] NotificationService NotificationService { get; set; }

        public TuanLamViecRequest TuanLamViecRequest = new TuanLamViecRequest();

        List<ChiTietTuanRequest> data = new List<ChiTietTuanRequest>();

        RadzenDataGrid<ChiTietTuanRequest> ordersGrid;

        void PhatSinhTuan()
        {
            data.Clear();
            data = tietTuanServiceClient.PhatSinhChiTietTuan(TuanLamViecRequest.NgayBatDau, TuanLamViecRequest.NgayKetThuc);
        }

        void EditRow(ChiTietTuanRequest order)
        {
            ordersGrid.EditRow(order);
        }

        void SaveRow(ChiTietTuanRequest order)
        {
            ordersGrid.UpdateRow(order);
        }

        void CancelEdit(ChiTietTuanRequest order)
        {
            ordersGrid.CancelEditRow(order);
        }
        void write()
        {
            foreach (var item in data)
            {
                Console.WriteLine($"Tên tuần {item.TenTuan} Số giờ {item.SoGioLam}");
            }
        }


        async Task InsertTuanLamViec(EditContext editContext)
        {
         
            int mathanglamviec = await tuanLamViecServiceClient.InsertTuanLamViec(TuanLamViecRequest);

            int check = await tietTuanServiceClient.InsertChiTietTuan(data, mathanglamviec);

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
        void ShowNotification(NotificationMessage message)
        {
            NotificationService.Notify(message);
        }
    }
}
