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
        //private IEnumerable<WeatherForecast> forecasts;
        IList<TuanLamViecResponse> selectedTuanLamViec;
        IList<ChiTietTuanResponse> selectedEmployeesdDetail;

        [Inject] ITuanLamViecServiceClient tuanLamViecService { get; set; }

        [Inject] IChiTietTuanServiceClient chiTietTuanService { get; set; }

        [Inject] ISyncLocalStorageService localstorage { get; set; }

        [Inject] DialogService dialogService { get; set; }

        
        List<TuanLamViecResponse> TuanLamViecs { get; set; }

        List<ChiTietTuanResponse> ChiTietTuans = new List<ChiTietTuanResponse>();

        List<DateTime> Name = new List<DateTime>();



        protected override async Task OnInitializedAsync()
        {
            int MaDuAn = int.Parse(localstorage.GetItemAsString("MaDuAn"));

            TuanLamViecs = await tuanLamViecService.GetTuanLamViecByDuAn(MaDuAn);
        }

        public void Click(TuanLamViecResponse tuanLamViec)
        {
            Console.WriteLine($"Da click{tuanLamViec.TenThang}");
        }

        async Task RowExpandAsync(TuanLamViecResponse TuanLamViec)
        {
            Console.WriteLine($"Bạn đã bắm vào tuần mã {TuanLamViec.MaThangLamViec}");

            ChiTietTuans = await chiTietTuanService.GetChiTietTuanByTuanLamViec(TuanLamViec.MaThangLamViec);
        }

        public async Task ThemTuanLamViec()
        {
            await dialogService.OpenAsync<ThemSuaTuanLamViec>("THÊM/SỬA TUẦN LÀM VIỆC",null, new DialogOptions() { Width = "700px", Height = "530px", Resizable = true, Draggable = true });

        }
    }
}
