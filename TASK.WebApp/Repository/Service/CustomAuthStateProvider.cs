using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace TASK.WebApp.Repository.Service
{
    public class CustomAuthStateProvider : AuthenticationStateProvider
    {

        public ILocalStorageService LocalStorage;

        public CustomAuthStateProvider(ILocalStorageService localStorageService)
        {
            this.LocalStorage = localStorageService;
        }

        public override async Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            var state = new AuthenticationState(new ClaimsPrincipal());

            string username = await LocalStorage.GetItemAsStringAsync("Username");

            string userid = await LocalStorage.GetItemAsStringAsync("UserID");

            if (!string.IsNullOrEmpty(userid))
            {
                var identity = new ClaimsIdentity(new[] {

                    new Claim(ClaimTypes.NameIdentifier,userid),
                    new Claim(ClaimTypes.Name,username),
                }, "Test Authen type");

                state = new AuthenticationState(new ClaimsPrincipal(identity));
            }
            NotifyAuthenticationStateChanged(Task.FromResult(state));

            return state;
        }
    }
}
