using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using Radzen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TASK.Application.MLogin;
using TASK.WebApp.Repository.Interface;

namespace TASK.WebApp.Pages.Login
{
    public partial class Login
    {
        [Inject] NavigationManager muav { get; set; }

        [Inject] IAuthService _authService { get; set; }

        [Inject] AuthenticationStateProvider authenticationStateProvider { get; set; }

        [Inject] ILocalStorageService LocalStorage { get; set; }

        [Inject] ISyncLocalStorageService localstorage { get; set; }

        [Inject] NotificationService NotificationService { get; set; }

        private LoginRequest loginRequest = new LoginRequest();

        protected override void OnInitialized()
        {
            localstorage.RemoveItem("UserID");
            localstorage.RemoveItem("Username");
            localstorage.RemoveItem("FullName");
            localstorage.RemoveItem("Role");
            localstorage.RemoveItem("RoleDuAn");
        }

        public async Task OnLogin()
        {
            var result = await _authService.Login(loginRequest);

            if (result.Successful)
            {
                await LocalStorage.SetItemAsync<Guid>("UserID", result.MaUser);
                await LocalStorage.SetItemAsync<string>("Username", result.UserName);
                await LocalStorage.SetItemAsync<string>("FullName", result.FullName);
                await LocalStorage.SetItemAsync<int>("Role", result.MaQuyenHeThong);
                await authenticationStateProvider.GetAuthenticationStateAsync();
                muav.NavigateTo("/choosetask");
            }
            else
            {
                NotificationMessage noti = new NotificationMessage { Severity = NotificationSeverity.Error, Summary = result.Error, Duration = 4000 };
                ShowNotification(noti);             
            }                 
        }
        void ShowNotification(NotificationMessage message)
        {
            NotificationService.Notify(message);
        }
    }
}
