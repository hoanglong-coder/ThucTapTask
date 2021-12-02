using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components;
using Radzen;
using Radzen.Blazor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TASK.Application.MChiTietTuan;
using TASK.Application.MCongViec;
using TASK.Application.MToDoList;
using TASK.Application.MTuanLamViec;
using TASK.Application.MUser;
using TASK.Data.Entities;
using TASK.Data.Enums;
using TASK.WebApp.Repository.Interface;

namespace TASK.WebApp.Pages.QuanLyCongViec
{
    public partial class QuanLyCongViec
    {
        DateTime? value = DateTime.Now;

        [Inject] ILocalStorageService localstorage { get; set; }

        [Inject] IToDoServiceClient toDoServiceClient { get; set; }

        [Inject] ICongViecServiceClient congViecServiceClient { get; set; }

        [Inject] ITuanLamViecServiceClient tuanLamViecServiceClient { get; set; }

        [Inject] TooltipService tooltipService { get; set; }

        [Inject] DialogService dialogService { get; set; }

        [Inject] NotificationService NotificationService { get; set; }

        [Inject] IChiTietTuanServiceClient ChiTietTuanServiceClient { get; set; }

        [Inject] IUserServiceClient userServiceClient { get; set; }

        List<Module> Listmodule = new List<Module>();

        List<TuanLamViecResponse> TuanLamViecs = new List<TuanLamViecResponse>();

        List<ChiTietTuanResponse> ChiTietTuans = new List<ChiTietTuanResponse>();

        List<UserResponse> userResponses = new List<UserResponse>();

        RadzenDataGrid<CongViecResponse> congviecsGrid;

        public ToDoListResponse toDoList { get; set; }

        public List<ToDoListDTO> toDoListDTOs = new List<ToDoListDTO>();

        IList<CongViecResponse> selectedCongViec;

        List<CongViecResponse> congViecResponses = new List<CongViecResponse>();

        List<TrangThaiCongViec> trangThaiCongViecs { get; set; }

        CongViecSearch congViecSearch = new CongViecSearch();

        int Role;

        int count = 30;

        int pageSize = 4;

        bool timkiemncao { get; set; } = true;

        bool pushpin { get; set; } = true;

        int dem = 1;

        string chuoipush;

        bool checkpush;

        bool isKhoaTuan = false;

        Guid MaUser;

        protected override async Task OnInitializedAsync()
        {

            Role = await localstorage.GetItemAsync<int>("Role");

            trangThaiCongViecs = ((STT_CongViec[])Enum.GetValues(typeof(STT_CongViec))).Select(c => new TrangThaiCongViec() { Value = (int)c, Name = GetNameTrangThai(c) }).ToList();

            dialogService.OnClose += Close;

            int MaDuAn = await localstorage.GetItemAsync<int>("MaDuAn");

            MaUser = await localstorage.GetItemAsync<Guid>("UserID");

            toDoList = await toDoServiceClient.GetAllToDoByDuAn(MaDuAn, MaUser);

            TuanLamViecs = await tuanLamViecServiceClient.GetTuanLamViecByDuAn(MaDuAn);

            Listmodule = await congViecServiceClient.GetAllModule();

            userResponses = await userServiceClient.GetAllByDuAn(MaDuAn);

            if (toDoList.Count > 0)
            {
                checkpush = false;              
                toDoListDTOs = toDoList.ListToDo;
                chuoipush = $"Có {toDoList.Count} to do đang được ghim | Đến hạn: {toDoListDTOs.Take(1).FirstOrDefault().NgayDenHang.ToString("dd/MM/yyy")} " +sub(toDoListDTOs.Take(1).FirstOrDefault().NoiDung);
            }
            else
            {
                checkpush = true;
            }
        }

        void changepush()
        {
            dem = 1;
            pushpin = !pushpin;
        }

        void change()
        {
            timkiemncao = !timkiemncao;
        }

        string sub(string text)
        {
            if (text.Length < 50)
            {
                return text;
            }else
            {
                return text.Substring(0, 50) + "...";
            }
        }
        void OnRender(DataGridRenderEventArgs<CongViecResponse> args)
        {
            if (args.FirstRender)
            {
                args.Grid.Groups.Add(new GroupDescriptor() { Property = "MaUser",Title="Mã User" });
                StateHasChanged();
            }
        }
        void Action()
        {
            Console.WriteLine("Thực thi");
        }

        void EditRow(CongViecResponse order)
        {
            congviecsGrid.EditRow(order);
        }

        void SaveRow(CongViecResponse order)
        {
            Console.WriteLine("đã nhấp");
            congviecsGrid.UpdateRow(order);
        }

        void CancelEdit(CongViecResponse order)
        {
            congviecsGrid.CancelEditRow(order);
        }

        void ShowTooltip(ElementReference elementReference, TooltipOptions options = null) => tooltipService.Open(elementReference, "Dời do trể 3 lần", options);


        async Task InsertCongViec()
        {
            await dialogService.OpenAsync<ThemCongViec>("THÊM CÔNG VIỆC TUẦN", null, new DialogOptions() { Width = "772px", Height = "611px", Resizable = true, Draggable = true });
        }

        async Task DeleteCongViec()
        {
            if (selectedCongViec != null)
            {
                if (selectedCongViec.Count() != 0)
                {
                    
                    if (KiemTraCongViecByUser(MaUser, selectedCongViec.ToList()) || Role == 1)
                    {
                        var selectedrequse = selectedCongViec.Select(t => new CongViecRequest() {
                            
                            MaCongViec = t.MaCongViec,
                            DaDuyet = t.DaDuyet

                        }).ToList();

                        int check = await congViecServiceClient.DeleteCongViecRange(selectedrequse);

                        if (check == 1)
                        {
                            NotificationMessage noti = new NotificationMessage { Severity = NotificationSeverity.Success, Summary = "Xóa thành công", Duration = 2000 };
                            await ShowNotification(noti);
                            selectedCongViec = new List<CongViecResponse>();
                            await Reset();
                        }
                        else
                        {
                            NotificationMessage noti = new NotificationMessage { Severity = NotificationSeverity.Error, Summary = "Không thể xóa do tuần này đã duyệt", Duration = 2000 };
                            selectedCongViec = new List<CongViecResponse>();
                            await ShowNotification(noti);
                        }
                    }
                    else
                    {
                        NotificationMessage noti = new NotificationMessage { Severity = NotificationSeverity.Error, Summary = "Bạn chưa chọn đúng công việc của bản thân", Duration = 2000 };
                        await ShowNotification(noti);
                        selectedCongViec = new List<CongViecResponse>();
                    }
                    
                }else
                {
                    NotificationMessage noti = new NotificationMessage { Severity = NotificationSeverity.Error, Summary = "Bạn chưa chọn công việc để xóa", Duration = 2000 };
                    await ShowNotification(noti);
                }
                
            }else
            {
                NotificationMessage noti = new NotificationMessage { Severity = NotificationSeverity.Error, Summary = "Bạn chưa chọn công việc để xóa", Duration = 2000 };
                await ShowNotification(noti);
            }
        }

        async Task UpdateCongViec()
        {
            Guid MaUser = await localstorage.GetItemAsync<Guid>("UserID");          

            if (Role == 2 || Role == 3)
            {
                var congViecRequests = congViecResponses.Where(t=>t.MaUser==MaUser).Select(t => new CongViecRequest() {

                    MaCongViec = t.MaCongViec,
                    MaUser = t.MaUser,
                    MaThangLamViec = t.MaThangLamViec,
                    MaTuanChiTiet = t.MaTuanChiTiet,
                    MaModule = t.MaModule,
                    TenIssue = t.TenIssue,
                    IssueURL = t.IssueURL,
                    TenCongViec = t.TenCongViec,
                    ThoiGianLam = t.ThoiGianLam,
                    TrangThai = t.TrangThai,
                    TuNgay = t.TuNgay,
                    DenNgay = t.DenNgay,
                    GhiChu = t.GhiChu,
                    Nguon = t.Nguon,
                    DaDuyet = t.DaDuyet
                    
                }).ToList();

                int check = await congViecServiceClient.UpdateCongViecRange(congViecRequests);

                if (check == 1)
                {
                    NotificationMessage noti = new NotificationMessage { Severity = NotificationSeverity.Success, Summary = "Lưu thành công", Duration = 2000 };
                    await ShowNotification(noti);
                    await Reset();
                }
                else
                {
                    NotificationMessage noti = new NotificationMessage { Severity = NotificationSeverity.Error, Summary = "Không thể thay thổi do tuần đã khóa", Duration = 2000 };
                    await ShowNotification(noti);
                }

            }
            else
            {
                var congViecRequests = congViecResponses.Select(t => new CongViecRequest()
                {

                    MaCongViec = t.MaCongViec,
                    MaUser = t.MaUser,
                    MaThangLamViec = t.MaThangLamViec,
                    MaTuanChiTiet = t.MaTuanChiTiet,
                    MaModule = t.MaModule,
                    TenIssue = t.TenIssue,
                    IssueURL = t.IssueURL,
                    TenCongViec = t.TenCongViec,
                    ThoiGianLam = t.ThoiGianLam,
                    TrangThai = t.TrangThai,
                    TuNgay = t.TuNgay,
                    DenNgay = t.DenNgay,
                    GhiChu = t.GhiChu,
                    Nguon = t.Nguon,
                    DaDuyet = t.DaDuyet
                }).ToList();

                int check = await congViecServiceClient.UpdateCongViecRange(congViecRequests);

                if (check == 1)
                {
                    NotificationMessage noti = new NotificationMessage { Severity = NotificationSeverity.Success, Summary = "Lưu thành công", Duration = 2000 };
                    await ShowNotification(noti);
                    await Reset();
                }
                else
                {
                    NotificationMessage noti = new NotificationMessage { Severity = NotificationSeverity.Error, Summary = "Không thể thay thổi do tuần đã khóa", Duration = 2000 };
                    await ShowNotification(noti);
                }
            }


        }

        async Task DuyetCongViec()
        {
            if (selectedCongViec != null)
            {
                if (selectedCongViec.Count() != 0)
                {
                    var selectedrequse = selectedCongViec.GroupBy(t => t.MaUser);

                    foreach (var GroupUser in selectedrequse)
                    {
                        if (KiemTraDuyetCongViec(GroupUser.Count(), congViecResponses, GroupUser.Key))
                        {
                            var selectedrequest = GroupUser.Select(t => new CongViecRequest() {
                                MaCongViec = t.MaCongViec                                                                                  
                            }).ToList();

                            int sogioquydinh = await ChiTietTuanServiceClient.TraVeSoGioLam(GroupUser.Select(t => t).FirstOrDefault().MaTuanChiTiet);

                            int sogiodangky = GroupUser.Sum(t => t.ThoiGianLam);

                            if (sogiodangky < sogioquydinh)
                            {
                               var result =  await dialogService.Confirm("Số giờ làm việc đã tạo chưa đủ so với số giờ quy định trong tuần bạn có muốn duyệt", "Xác nhận duyệt công việc", new ConfirmOptions() { OkButtonText = "Yes", CancelButtonText = "No" });

                               if (result==true)
                               {
                                    int check = await congViecServiceClient.DuyetKeHoachTuan(selectedrequest);

                                    if (check == 1)
                                    {
                                        NotificationMessage noti = new NotificationMessage { Severity = NotificationSeverity.Success, Summary = "Duyệt thành công", Duration = 2000 };
                                        await ShowNotification(noti);
                                        selectedCongViec = new List<CongViecResponse>();
                                        await Reset();
                                    }
                                    else
                                    {
                                        NotificationMessage noti = new NotificationMessage { Severity = NotificationSeverity.Error, Summary = "Duyệt thất bại", Duration = 2000 };
                                        selectedCongViec = new List<CongViecResponse>();
                                        await ShowNotification(noti);
                                    }
                                }else
                                {
                                    selectedCongViec = new List<CongViecResponse>();
                                }
                            }else
                            {
                                int check = await congViecServiceClient.DuyetKeHoachTuan(selectedrequest);

                                if (check == 1)
                                {
                                    NotificationMessage noti = new NotificationMessage { Severity = NotificationSeverity.Success, Summary = "Duyệt thành công", Duration = 2000 };
                                    await ShowNotification(noti);
                                    selectedCongViec = new List<CongViecResponse>();
                                    await Reset();
                                }
                                else
                                {
                                    NotificationMessage noti = new NotificationMessage { Severity = NotificationSeverity.Error, Summary = "Duyệt thất bại", Duration = 2000 };
                                    selectedCongViec = new List<CongViecResponse>();
                                    await ShowNotification(noti);
                                }
                            }
                       
                            
                        }
                        else
                        {
                            NotificationMessage noti = new NotificationMessage { Severity = NotificationSeverity.Error, Summary = "Bạn chưa chọn đủ task trong tuần đó", Duration = 2000 };
                            selectedCongViec = new List<CongViecResponse>();
                            await ShowNotification(noti);
                        }
                        
                    }                   
                }
                else
                {
                    NotificationMessage noti = new NotificationMessage { Severity = NotificationSeverity.Error, Summary = "Bạn chưa chọn công việc để duyệt", Duration = 2000 };
                    await ShowNotification(noti);
                }

            }
            else
            {
                NotificationMessage noti = new NotificationMessage { Severity = NotificationSeverity.Error, Summary = "Bạn chưa chọn công việc để duyệt", Duration = 2000 };
                await ShowNotification(noti);
            }
        }

        async void Close(dynamic result)
        {
           await Reset();
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

        async Task Reset()
        {
            if (congViecSearch.MaThangLamViec != 0 && congViecSearch.MaTuanChiTiet!=0)
            {
                congViecResponses.Clear();
                congViecResponses = await congViecServiceClient.GetAll(congViecSearch);

                StateHasChanged();
            }
            
        }


        bool KiemTraCongViecByUser(Guid User, List<CongViecResponse> congViecResponses)
        {
            foreach (var item in congViecResponses)
            {
                if (item.MaUser != User)
                {
                    return false;
                }
            }
            return true;
        }
    
        void OnChange(object value,int MaCongViec)
        {
            Console.WriteLine($"Mã value{(int)value} của Mã công việc {MaCongViec}");

            congViecResponses.Where(t => t.MaCongViec == MaCongViec).Single().TenModule = Listmodule.Where(t=>t.MaModule==(int)value).Single().TenModule;
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

        bool KiemTraDuyetCongViec(int select, List<CongViecResponse> totalCongviec, Guid MaUser)
        {
            int count = totalCongviec.Where(t => t.MaUser == MaUser).Count();

            if (select < count)
            {
                return false;
            }
            return true;
        }

        async Task SearchCongViec()
        {
            if (congViecSearch.MaThangLamViec != 0 && congViecSearch.MaTuanChiTiet != 0)
            {
                congViecResponses = await congViecServiceClient.GetAll(congViecSearch);
            }               
        }
   
        async Task OnChangeThang(object value)
        {
            ChiTietTuans = new List<ChiTietTuanResponse>();
            ChiTietTuans = await ChiTietTuanServiceClient.GetChiTietTuanByTuanLamViec((int)value);
            StateHasChanged();
        }
        async Task OnChangeChitiettuan(object value)
        {
            isKhoaTuan = await ChiTietTuanServiceClient.KiemTraKhoaTuan((int)value);
        }

        
    }
}
