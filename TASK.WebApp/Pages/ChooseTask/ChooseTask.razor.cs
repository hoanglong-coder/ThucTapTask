using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components;
using Radzen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TASK.Application.MDuAn;
using TASK.WebApp.Repository.Interface;

namespace TASK.WebApp.Pages.ChooseTask
{
    public partial class ChooseTask
    {

        [Inject] IDuAnServiceClient DuAnServiceClient { get; set; }

        [Inject] IUserServiceClient userServiceClient { get; set; }

        [Inject] ILocalStorageService LocalStorage { get; set; }

        [Inject] ILocalStorageService localStorageService { get; set; }

        [Inject] NavigationManager NavigationManager { get; set; }

        public List<DuAnResponse> DuAns { get; set; }

        protected override async Task OnInitializedAsync()
        {
            Guid id = await LocalStorage.GetItemAsync<Guid>("UserID");

            DuAns = await DuAnServiceClient.GetDuAnByUser(id);

            await localStorageService.RemoveItemAsync("MaDuAn");

            await localStorageService.RemoveItemAsync("RoleDuAn");
        }

        public async Task OnClick(string ma)
        {
            Guid id = await LocalStorage.GetItemAsync<Guid>("UserID");


            int MaQuyen = await userServiceClient.GetQuyenDuAn(id, int.Parse(ma));

            await localStorageService.SetItemAsync<int>("RoleDuAn", MaQuyen);

            await localStorageService.SetItemAsStringAsync("MaDuAn", ma);


            NavigationManager.NavigateTo("/Dashboard");
        }
    }
}
