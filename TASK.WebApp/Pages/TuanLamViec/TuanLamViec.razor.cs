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

        TuanLamViecPaging TuanLamViecPaging { get; set; }

        List<TuanLamViecResponse> TuanLamViecs { get; set; }

        List<ChiTietTuanResponse> ChiTietTuans = new List<ChiTietTuanResponse>();

        int Role;

        int MaThangLamViec;

        int pageSize = 3;

        int count = -1;

        int skippage = 0;
        int takepage = 3;

        protected override async Task OnInitializedAsync()
        {
            int MaDuAn = int.Parse(localstorage.GetItemAsString("MaDuAn"));

            Role = localstorage.GetItem<int>("Role");

            TuanLamViecPaging = await tuanLamViecService.GetTuanLamViecByDuAnPageing(MaDuAn, 0, pageSize);

            count = TuanLamViecPaging.Count;

            TuanLamViecs = TuanLamViecPaging.ListTuanLamViecRequest;

            dialogService.OnClose += Close;
        }

        public async Task SuaTuanLamViec(TuanLamViecResponse tuanLamViec)
        {
            Console.WriteLine($"Da click{tuanLamViec.TenThang}");

            await dialogService.OpenAsync<SuaTuanLamViec>($"Sửa Tháng {tuanLamViec.TenThang}",
                                                        new Dictionary<string, object>() { { "Mathanglamviec", tuanLamViec.MaThangLamViec}},
                                                        new DialogOptions() { Width = "700px", Height = "530px", Resizable = true, Draggable = true });

        }

        async Task RowExpandAsync(TuanLamViecResponse TuanLamViec)
        {
            ChiTietTuans = await chiTietTuanService.GetChiTietTuanByTuanLamViec(TuanLamViec.MaThangLamViec);
        }

        public async Task ThemTuanLamViec()
        {
            await dialogService.OpenAsync<ThemTuanLamViec>("THÊM TUẦN LÀM VIỆC",null, new DialogOptions() { Width = "700px", Height = "530px", Resizable = true, Draggable = true });

        }
        async void Close(dynamic result)
        {
            await reset();
        }
        async Task reset()
        {
            TuanLamViecs.Clear();

            Console.WriteLine("restet");

            int MaDuAn = int.Parse(localstorage.GetItemAsString("MaDuAn"));

            TuanLamViecPaging = await tuanLamViecService.GetTuanLamViecByDuAnPageing(MaDuAn, skippage, takepage);

            count = TuanLamViecPaging.Count;

            TuanLamViecs = TuanLamViecPaging.ListTuanLamViecRequest;

            StateHasChanged();
        }

        async Task DeleteAsync()
        {
            if (selectedTuanLamViec != null)
            {
                int check = await tuanLamViecService.DeleteTuanLamViec(selectedTuanLamViec);

                if (check == 1)
                {
                    NotificationMessage noti = new NotificationMessage { Severity = NotificationSeverity.Success, Summary = "Xóa thành công", Duration = 2000 };
                    ShowNotification(noti);
                    selectedTuanLamViec = new List<TuanLamViecResponse>();
                    await reset();
                }
                else
                {
                    NotificationMessage noti = new NotificationMessage { Severity = NotificationSeverity.Error, Summary = "Không thể xóa do đã lên công việc", Duration = 2000 };
                    selectedTuanLamViec = new List<TuanLamViecResponse>();
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
                    selectedEChitiettuan = new List<ChiTietTuanResponse>();
                    await reset();
                }
                else
                {
                    NotificationMessage noti = new NotificationMessage { Severity = NotificationSeverity.Error, Summary = "Không thể xóa do đã lên công việc", Duration = 2000 };
                    selectedEChitiettuan = new List<ChiTietTuanResponse>();
                    ShowNotification(noti);
                }
            }
            
        }

        async Task KhoaKeHoach()
        {
            if (selectedEChitiettuan != null)
            {
                var chitiettuanrequest = selectedEChitiettuan.Select(t => new ChiTietTuanRequest()
                {
                    MaTuanChiTiet = t.MaTuanChiTiet,
                    TenTuan = t.TenTuan,
                    GiaTri = t.GiaTri,
                    DenNgay = t.DenNgay,
                    TuNgay = t.TuNgay,
                    TrangThai = t.TrangThai,
                    SoGioLam = t.SoGioLam,
                }).ToList();


                int check = await chiTietTuanService.KhoaKeHoachTuan(chitiettuanrequest);

                if (check == 1)
                {
                    NotificationMessage noti = new NotificationMessage { Severity = NotificationSeverity.Success, Summary = "Khóa thành công", Duration = 2000 };
                    ShowNotification(noti);
                    selectedEChitiettuan = new List<ChiTietTuanResponse>();
                    await reset();
                }
                else
                {
                    NotificationMessage noti = new NotificationMessage { Severity = NotificationSeverity.Error, Summary = "Khóa thất bại", Duration = 2000 };
                    selectedEChitiettuan = new List<ChiTietTuanResponse>();
                    ShowNotification(noti);
                }
            }
        }
        void ShowNotification(NotificationMessage message)
        {
            NotificationService.Notify(message);
        }

        async Task PageChanged(PagerEventArgs args)
        {
            skippage = args.Skip;
            takepage = args.Top;
            int MaDuAn = int.Parse(localstorage.GetItemAsString("MaDuAn"));

            TuanLamViecPaging = await tuanLamViecService.GetTuanLamViecByDuAnPageing(MaDuAn, args.Skip, args.Top);

            TuanLamViecs = TuanLamViecPaging.ListTuanLamViecRequest;
        }
        void OnChange(object value)
        {
            var str = value is IEnumerable<object> ? string.Join(", ", (IEnumerable<object>)value) : value;

            Console.WriteLine($"Value changed to {str}");
        }
    }
}
