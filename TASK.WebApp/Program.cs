using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Radzen;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using TASK.WebApp.Repository.Interface;
using TASK.WebApp.Repository.Service;



namespace TASK.WebApp
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");

            builder.Services.AddBlazoredLocalStorage();

            builder.Services.AddScoped<NotificationService>();

            builder.Services.AddScoped<TooltipService>();

            builder.Services.AddScoped<DialogService>();

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://localhost:44380") });

            builder.Services.AddOptions();

            builder.Services.AddAuthorizationCore();

            builder.Services.AddScoped<IAuthService, AuthService>();

            builder.Services.AddScoped<IDuAnServiceClient, DuAnServiceClient>();

            builder.Services.AddScoped<ITuanLamViecServiceClient, TuanLamViecServiceClient>();

            builder.Services.AddScoped<IChiTietTuanServiceClient, ChiTietTuanServiceClient>();

            builder.Services.AddScoped<IToDoServiceClient, ToDoServiceClient>();

            builder.Services.AddScoped<IChartServiceClient, ChartServiceClientcs>();

            builder.Services.AddScoped<IUserServiceClient, UserServiceClient>();

            builder.Services.AddScoped<ICongViecServiceClient, CongViecServiceClient>();

            builder.Services.AddScoped<IDanhGiaNhanSuServiceClient, DanhGiaNhanSuServiceClient>();

            builder.Services.AddScoped<AuthenticationStateProvider, CustomAuthStateProvider>();

            await builder.Build().RunAsync();
        }
    }
}
