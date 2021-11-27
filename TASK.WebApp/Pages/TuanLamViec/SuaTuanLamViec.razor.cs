using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components;
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
    public partial class SuaTuanLamViec
    {

        [Inject] ITuanLamViecServiceClient tuanLamViecService { get; set; }

        [Inject] IChiTietTuanServiceClient chiTietTuanServiceClient { get; set; }

        [Inject] ISyncLocalStorageService localstorage { get; set; }

        [Inject] DialogService dialogService { get; set; }

        [Inject] NotificationService NotificationService { get; set; }

        [Parameter] public int Mathanglamviec { get; set; }

        public TuanLamViecRequest tuanLamViecrequest { get; set; }

        public TuanLamViecResponse tuanLamViecresponse { get; set; }

        public List<ChiTietTuanResponse> chiTietTuanResponse { get; set; }

        public List<ChiTietTuanRequest> chiTietTuanRequest { get; set; }

        RadzenDataGrid<ChiTietTuanRequest> chitiettuangrid;

        protected override async Task OnInitializedAsync()
        {
            int MaDuAn = int.Parse(localstorage.GetItemAsString("MaDuAn"));

            tuanLamViecresponse = await tuanLamViecService.GetTuanLamViecByMaThangLamViec(Mathanglamviec);

            tuanLamViecrequest = new TuanLamViecRequest();
            tuanLamViecrequest.MaThangLamViec = tuanLamViecresponse.MaThangLamViec;
            tuanLamViecrequest.TenThang = tuanLamViecresponse.TenThang;
            tuanLamViecrequest.GiaTri = tuanLamViecresponse.GiaTri;
            tuanLamViecrequest.NgayBatDau = tuanLamViecresponse.NgayBatDau;
            tuanLamViecrequest.NgayKetThuc = tuanLamViecresponse.NgayKetThuc;
            tuanLamViecrequest.MaDuAn = MaDuAn;


            chiTietTuanResponse = await chiTietTuanServiceClient.GetChiTietTuanByTuanLamViec(Mathanglamviec);

            chiTietTuanRequest = chiTietTuanResponse.Select(t => new ChiTietTuanRequest() {

                 MaTuanChiTiet = t.MaTuanChiTiet,
                 TenTuan = t.TenTuan,
                 GiaTri = t.GiaTri,
                 TuNgay = t.TuNgay,
                 DenNgay = t.DenNgay,
                 SoGioLam = t.SoGioLam,
                 TrangThai = t.TrangThai,
                 MaThangLamViec = Mathanglamviec

            }).ToList();


        }

        async Task UpdateTuanLamViecLuuThem()
        {
            int checktuanlamviec = await tuanLamViecService.UpdateTuanLamViec(tuanLamViecrequest);

            int checkchitiettuanlamviec = await chiTietTuanServiceClient.UpdateChiTietTuanLamViec(chiTietTuanRequest);

            if (checktuanlamviec ==  1&& checkchitiettuanlamviec == 1)
            { 
                NotificationMessage noti = new NotificationMessage { Severity = NotificationSeverity.Success, Summary = "Cập nhật thành công", Duration = 2000 };
                ShowNotification(noti);
                dialogService.Close(true);
            }
            else
            {
                NotificationMessage noti = new NotificationMessage { Severity = NotificationSeverity.Error, Summary = "Cập nhật thất bại", Duration = 2000 };
                ShowNotification(noti);
            }
        }

        void PhatSinhTuan()
        {
            //data.Clear();
            //data = tietTuanServiceClient.PhatSinhChiTietTuan(TuanLamViecRequest.NgayBatDau, TuanLamViecRequest.NgayKetThuc);
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

        void ShowNotification(NotificationMessage message)
        {
            NotificationService.Notify(message);
        }
        void OnInvalidSubmit()
        {

        }
    }
}
