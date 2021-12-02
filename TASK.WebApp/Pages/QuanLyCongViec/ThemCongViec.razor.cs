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
using TASK.Application.MUser;
using TASK.Data.Entities;
using TASK.Data.Enums;
using TASK.WebApp.Repository.Interface;

namespace TASK.WebApp.Pages.QuanLyCongViec
{
    public partial class ThemCongViec
    {
        DateTime? value = DateTime.Now;

        [Inject] IUserServiceClient userServiceClient { get; set; }

        [Inject] ITuanLamViecServiceClient tuanLamViecServiceClient { get; set; }

        [Inject] IChiTietTuanServiceClient ChiTietTuanServiceClient { get; set; }

        [Inject] ICongViecServiceClient congViecServiceClient { get; set; }

        [Inject] ILocalStorageService localstorage { get; set; }

        [Inject] NotificationService NotificationService { get; set; }

        [Inject] DialogService dialogService { get; set; }

        List<UserResponse> userResponses { get; set; }

        List<TuanLamViecResponse> tuanLamViecResponses = new List<TuanLamViecResponse>();

        List<ChiTietTuanResponse> chiTietTuanResponses = new List<ChiTietTuanResponse>();

        List<Module> Listmodule = new List<Module>();

        CongViecRequest congViecRequest = new CongViecRequest();

        Guid MaUser;

        Guid Admin;

        public int checksave = 0;

        List<TrangThaiCongViec> trangThaiCongViecs { get; set; }

        protected override async Task OnInitializedAsync()
        {
            int MaDuAn = await localstorage.GetItemAsync<int>("MaDuAn");

            int Quyen = await localstorage.GetItemAsync<int>("Role");
            
            if (Quyen == 1)
            {
                Admin = await localstorage.GetItemAsync<Guid>("UserID");

            }
            MaUser = await localstorage.GetItemAsync<Guid>("UserID");

            userResponses = await userServiceClient.GetAllByDuAn(MaDuAn);

            tuanLamViecResponses = await tuanLamViecServiceClient.GetTuanLamViecByDuAn(MaDuAn);

            Listmodule = await congViecServiceClient.GetAllModule();

            trangThaiCongViecs = ((STT_CongViec[])Enum.GetValues(typeof(STT_CongViec))).Where(c=>c==STT_CongViec.ChuaLam).Select(c => new TrangThaiCongViec() { Value = (int)c, Name = GetNameTrangThai(c) }).ToList();

        }

        async Task OnChange(object value)
        {
            chiTietTuanResponses = new List<ChiTietTuanResponse>();
            chiTietTuanResponses = await ChiTietTuanServiceClient.GetChiTietTuanByTuanLamViec((int)value);
            StateHasChanged();            
        }

        public string GetNameTrangThai(Enum key)
        {
            STT_CongViec TT = (STT_CongViec)key;

            string Name = "";

            switch (TT)
            {
                case STT_CongViec.ChuaLam:
                    Name = "Chưa làm";
                    break;
                case STT_CongViec.DaXong:
                    Name = "Đã xong";
                    break;
                case STT_CongViec.DaXongTaskDotXuat:
                    Name = "Đã xong(Task đột xuất)";
                    break;
                case STT_CongViec.ChuaXong:
                    Name = "Chưa xong";
                    break;
                case STT_CongViec.ChuaXongBanTaskKhacChuaDuyet:
                    Name = "Chưa xong(bận task khác)-Chưa duyệt";
                    break;
                case STT_CongViec.ChuaXongBanTaskKhacDaDuyet:
                    Name = "Chưa xong(bận task khác)-Đã duyệt";
                    break;
                case STT_CongViec.Vang:
                    Name = "Vắng";
                    break;
                default:
                    break;
            }
            return Name;
        }

        async Task InsertCongViec()
        {
            if (checksave == 0)
            {
                Guid MaUserKiemTra = await localstorage.GetItemAsync<Guid>("UserID");
                if (MaUserKiemTra == MaUser || Admin != Guid.Empty)
                {
                    congViecRequest.MaUser = MaUser;
                    congViecRequest.Nguon = (int)STT_NguonGoc.TAOMOI;
                    int check = await congViecServiceClient.InsertCongViec(congViecRequest);

                    if (check == 1)
                    {
                        NotificationMessage noti = new NotificationMessage { Severity = NotificationSeverity.Success, Summary = "Thêm thành công", Duration = 2000 };
                        await ShowNotification(noti);
                        //ClearTodo();
                    }
                    else
                    {
                        NotificationMessage noti = new NotificationMessage { Severity = NotificationSeverity.Error, Summary = "Không thể thêm do đã duyệt", Duration = 2000 };
                        await ShowNotification(noti);
                    }
                }else
                {
                    NotificationMessage noti = new NotificationMessage { Severity = NotificationSeverity.Error, Summary = "Bạn chưa chọn đúng User", Duration = 2000 };
                    await ShowNotification(noti);
                }
                
            }
            else
            {
                Guid MaUserKiemTra = await localstorage.GetItemAsync<Guid>("UserID");
                if (MaUserKiemTra == MaUser || Admin != Guid.Empty)
                {
                    congViecRequest.MaUser = MaUser;
                    congViecRequest.Nguon = (int)STT_NguonGoc.TAOMOI;
                    int check = await congViecServiceClient.InsertCongViec(congViecRequest);

                    if (check == 1)
                    {
                        NotificationMessage noti = new NotificationMessage { Severity = NotificationSeverity.Success, Summary = "Thêm thành công", Duration = 2000 };
                        await ShowNotification(noti);
                        //ClearTodo();
                        dialogService.Close(true);

                    }
                    else
                    {
                        NotificationMessage noti = new NotificationMessage { Severity = NotificationSeverity.Error, Summary = "Không thể thêm do đã duyệt", Duration = 2000 };
                        await ShowNotification(noti);
                    }
                }
                else
                {

                    NotificationMessage noti = new NotificationMessage { Severity = NotificationSeverity.Error, Summary = "Bạn chưa chọn đúng User", Duration = 2000 };
                    await ShowNotification(noti);
                }
               
            }
        }
        async Task OnInvalidSubmit()
        {
        }
        void changesave()
        {
            checksave = 1;
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
