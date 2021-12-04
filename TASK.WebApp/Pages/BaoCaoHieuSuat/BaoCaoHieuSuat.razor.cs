using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components;
using Radzen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TASK.Application.MChart;
using TASK.Application.MCongViec;
using TASK.Application.MTuanLamViec;
using TASK.WebApp.Repository.Interface;

namespace TASK.WebApp.Pages.BaoCaoHieuSuat
{
    public partial class BaoCaoHieuSuat
    {
        [Inject] IChartServiceClient chartServiceClient { get; set; }

        [Inject] ITuanLamViecServiceClient tuanLamViecServiceClient { get; set; }

        [Inject] ILocalStorageService localstorage { get; set; }

        [Inject] TooltipService tooltipService { get; set; }

        List<TuanLamViecResponse> TuanLamViecs = new List<TuanLamViecResponse>();

        CongViecSearch congViecSearch = new CongViecSearch();

        List<ChartBaoCaoHieuSuatSoGioLam> chartBaoCaoHieuSuatSoGioLams = new List<ChartBaoCaoHieuSuatSoGioLam>();

        List<NhanXet> nhanXets = new List<NhanXet>();

        int tuanlamviec { get; set; }

        List<ChartBaoCaoHieuSuatTrungbinhthang> chartBaoCaoHieuSuatTrungbinhthangs = new List<ChartBaoCaoHieuSuatTrungbinhthang>();

        int TongGio { get; set; }

        protected override async Task OnInitializedAsync()
        {
            int MaDuAn = await localstorage.GetItemAsync<int>("MaDuAn");

            TuanLamViecs = await tuanLamViecServiceClient.GetTuanLamViecByDuAn(MaDuAn);
        }

        public async Task Search()
        {
            if (congViecSearch.MaThangLamViec != 0)
            {
                int MaDuAn = await localstorage.GetItemAsync<int>("MaDuAn");
                chartBaoCaoHieuSuatSoGioLams = await chartServiceClient.GetChartSoGioLam(MaDuAn, congViecSearch.MaThangLamViec);
                chartBaoCaoHieuSuatTrungbinhthangs = await chartServiceClient.GetChartTrungBinhThang(MaDuAn, congViecSearch.MaThangLamViec);

                TongGio = await tuanLamViecServiceClient.GetTongGio1Thang(congViecSearch.MaThangLamViec);


                nhanXets = await chartServiceClient.getnhanxet(MaDuAn, congViecSearch.MaThangLamViec);
            }
            
        }

        void ShowTooltip(ElementReference elementReference, TooltipOptions options = null) => tooltipService.Open(elementReference, options.Text, options);

    }
}
