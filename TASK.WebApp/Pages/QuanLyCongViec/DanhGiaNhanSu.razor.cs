using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components;
using Radzen;
using Radzen.Blazor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TASK.Application.MDanhGiaNhanSu;
using TASK.Application.MTuanLamViec;
using TASK.Application.MUser;
using TASK.Data.Enums;
using TASK.WebApp.Repository.Interface;

namespace TASK.WebApp.Pages.QuanLyCongViec
{
    public partial class DanhGiaNhanSu
    {
        [Parameter] public int MaThangLamViec { get; set;}

        [Parameter] public Guid MaUser { get; set; }

        [Parameter] public int PhanTramHoanThanh { get; set; }

        [Inject] ILocalStorageService localstorage { get; set; }

        [Inject] ITuanLamViecServiceClient tuanLamViecServiceClient { get; set; }

        [Inject] IUserServiceClient userServiceClient { get; set; }

        [Inject] IDanhGiaNhanSuServiceClient danhGiaNhanSuServiceClient { get; set; }

        [Inject] NotificationService NotificationService { get; set; }

        [Inject] DialogService dialogService { get; set; }

        string TenUser { get; set; }

        List<TuanLamViecResponse> TuanLamViecs { get; set; }

        public DanhGiaThangResponse DanhGiaThangRequest = new DanhGiaThangResponse();

        public List<DanhGiaTuanResponse> danhGiaTuanResponses = new List<DanhGiaTuanResponse>();

        List<DanhGia> KhoiLuong { get; set; }
        
        List<DanhGia> KhoiLuongGird { get; set; }

        List<DanhGia> TienDo { get; set; }

        List<DanhGia> TienDoGird { get; set; }

        List<DanhGia> ChatLuongcombodanhgia { get; set; }

        List<DanhGia> ChatLuongGirddanhgia { get; set; }

        List<DanhGia> XepLoaidanhgia { get; set; }

        RadzenDataGrid<DanhGiaTuanResponse> danhgiatuangird;

        int TrungBinhThang = 0;

        int Role;

        protected override async Task OnInitializedAsync()
        {
            int MaDuAn = await localstorage.GetItemAsync<int>("MaDuAn");

             Role = await localstorage.GetItemAsync<int>("Role");

            TuanLamViecs = await tuanLamViecServiceClient.GetTuanLamViecByDuAn(MaDuAn);

            UserResponse user = await userServiceClient.GetUser(MaUser);

            TenUser = user.TenUser;

            DanhGiaThangRequest = await danhGiaNhanSuServiceClient.GetDanhGiaThang(MaThangLamViec, MaUser);

            KhoiLuong = ((STT_KhoiLuong[])Enum.GetValues(typeof(STT_KhoiLuong))).Select(c => new DanhGia() { Value = (int)c, Name = GetNameKhoiLuong(c) }).ToList();

            KhoiLuongGird = ((STT_KhoiLuong[])Enum.GetValues(typeof(STT_KhoiLuong))).Select(c => new DanhGia() { Value = (int)c, Name = GetNameKhoiLuong(c) }).ToList();

            TienDo = ((STT_TienDo[])Enum.GetValues(typeof(STT_TienDo))).Select(c => new DanhGia() { Value = (int)c, Name = GetNameTienDo(c) }).ToList();

            TienDoGird =((STT_TienDo[])Enum.GetValues(typeof(STT_TienDo))).Select(c => new DanhGia() { Value = (int)c, Name = GetNameTienDo(c) }).ToList();

            ChatLuongcombodanhgia = ((ChatLuongCombobox[])Enum.GetValues(typeof(ChatLuongCombobox))).Select(c => new DanhGia() { Value = (int)c, Name = GetNameChatLuongCombobox(c) }).ToList();

            ChatLuongGirddanhgia = ((ChatLuongGird[])Enum.GetValues(typeof(ChatLuongGird))).Select(c => new DanhGia() { Value = (int)c, Name = GetNameChatLuongGird(c) }).ToList();

            XepLoaidanhgia = ((XepLoai[])Enum.GetValues(typeof(XepLoai))).Select(c => new DanhGia() { Value = (int)c, Name = c.ToString() }).ToList();

            danhGiaTuanResponses = await danhGiaNhanSuServiceClient.GetDanhGiaTuanByDanhGiaThang(DanhGiaThangRequest.MaDanhGiaThang,MaUser);

            int count = danhGiaTuanResponses.Count();

            int sumhoanhthanh =  danhGiaTuanResponses.Select(t => t).Sum(t => t.HoanThanh).Value;

            double Trungbinh = (double)sumhoanhthanh / count;

            int Result = (int)Math.Round(Trungbinh);

            if (Result > 0)
            {
                TrungBinhThang = Result;
            }

        }
        string GetNameKhoiLuong(Enum key)
        {
            STT_KhoiLuong TT = (STT_KhoiLuong)key;

            string Name = "";

            switch (TT)
            {
                case STT_KhoiLuong.BinhThuong:
                    Name = "Bình thường";
                    break;
                case STT_KhoiLuong.Nhieu:
                    Name = "Nhiều";
                    break;
                case STT_KhoiLuong.Thap:
                    Name = "Thắp";
                    break;
                default:
                    break;
            }
            return Name;
        }
        
        string GetNameTienDo(Enum key)
        {
            STT_TienDo tt = (STT_TienDo)key;

            string Name = "";

            switch (tt)
            {
                case STT_TienDo.KipTienDo:
                    Name = "Kịp tiến độ";
                    break;
                case STT_TienDo.SomHonKH:
                    Name = "Sớm hơn kế hoạch";
                    break;
                case STT_TienDo.TreTienDo:
                    Name = "Trể tiến độ";
                    break;
                default:
                    break;
            }

            return Name;
        }
        
        string GetNameChatLuongGird(Enum key)
        {
            ChatLuongGird tt = (ChatLuongGird)key;

            string Name = "";
            switch (tt)
            {
                case ChatLuongGird.LoiNoiBoTrienKhaiTestLoai1:
                     Name = "<=2 lỗi nội bộ triển khai test";
                    break;
                case ChatLuongGird.LoiNoiBoTrienKhaiTestLoai2:
                    Name = "3 -> 4 lỗi nội bộ triển khai test";
                    break;
                case ChatLuongGird.LoiNoiBoHoacLoiKHBao:
                    Name = ">4 lỗi nội bộ hoặc <= 2 lỗi khách hàng báo";
                    break;
                case ChatLuongGird.LoiNghiemTrong:
                    Name = "Lỗi nghiêm trộng phía khách hàng";
                    break;
                default:
                    break;
            }

            return Name;
        }
        
        string GetNameChatLuongCombobox(Enum key)
        {
            ChatLuongCombobox TT = (ChatLuongCombobox)key;

            string Name = "";

            switch (TT)
            {
                case ChatLuongCombobox.Tot:
                    Name = "Tốt, hầu như không lỗi";
                    break;
                case ChatLuongCombobox.Kha:
                    Name = "Khá, vài lỗi nhỏ";
                    break;
                case ChatLuongCombobox.TrungBinh:
                    Name = "Trung bình, có vài lỗi lớn";
                    break;
                case ChatLuongCombobox.Yeu:
                    Name = "Yếu nhiều lỗi";
                    break;
                default:
                    break;
            }
            return Name;
        }

        void EditRow(DanhGiaTuanResponse order)
        {
            danhgiatuangird.EditRow(order);
        }

        void SaveRow(DanhGiaTuanResponse order)
        {
            danhgiatuangird.UpdateRow(order);
        }

        void CancelEdit(DanhGiaTuanResponse order)
        {
  
        }

        void OnChangeKhoiLuong(object value, int MaDanhGiaTuan)
        {

            danhGiaTuanResponses.Where(t => t.MaDanhGiaTuan == MaDanhGiaTuan).Single().KhoiLuong = KhoiLuongGird.Where(t => t.Value == (int)value).Single().Value;

        }

        void OnChangeTienDo(object value, int MaDanhGiaTuan)
        {

            danhGiaTuanResponses.Where(t => t.MaDanhGiaTuan == MaDanhGiaTuan).Single().TienDo = TienDoGird.Where(t => t.Value == (int)value).Single().Value;
        }

        
        void OnChangeChatLuong(object value, int MaDanhGiaTuan)
        {

            danhGiaTuanResponses.Where(t => t.MaDanhGiaTuan == MaDanhGiaTuan).Single().ChatLuong = ChatLuongGirddanhgia.Where(t => t.Value == (int)value).Single().Value;
        }

        async Task Update()
        {
            DanhGiaThangRequest.TrungBinhThang = TrungBinhThang;
            int check = await danhGiaNhanSuServiceClient.UpdateDanhGiaThang(DanhGiaThangRequest);

            int checkupdatetuan = await danhGiaNhanSuServiceClient.UpdateDanhGiaTuan(danhGiaTuanResponses);

            if (check == 1 && checkupdatetuan == 1)
            {
                NotificationMessage noti = new NotificationMessage { Severity = NotificationSeverity.Success, Summary = "Lưu thành công", Duration = 2000 };
                await ShowNotification(noti);
            }
            else
            {
                NotificationMessage noti = new NotificationMessage { Severity = NotificationSeverity.Error, Summary = "Không thể thay thổi do tuần đã khóa", Duration = 2000 };
                await ShowNotification(noti);
            }
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
