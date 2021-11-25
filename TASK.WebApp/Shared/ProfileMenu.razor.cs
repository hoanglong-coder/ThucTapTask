using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TASK.WebApp.Repository.Interface;

namespace TASK.WebApp.Shared
{
    public partial class ProfileMenu
    {
        [Inject] ISyncLocalStorageService localstorage { get; set; }

        [Inject] NavigationManager muav { get; set; }

        [Inject] AuthenticationStateProvider authenticationStateProvider { get; set; }

        [Inject] IDuAnServiceClient duAnServiceClient { get; set; }

        public string FullName = "";

        public string TenDuAn = "";

        protected async override Task OnInitializedAsync()
        {
            string unicodeString = localstorage.GetItemAsString("FullName");

            string[] arrListStr = unicodeString.Split('"');

            FullName = Encoding.UTF8.GetString(Encoding.Default.GetBytes(arrListStr[1]));

            int MaDuAn = int.Parse(localstorage.GetItemAsString("MaDuAn"));

            TenDuAn = await duAnServiceClient.GetNameDuAn(MaDuAn);

        }
    }
}
