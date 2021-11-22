using Microsoft.AspNetCore.Components;
using Radzen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace TASK.WebApp.Pages.TuanLamViec
{
    public partial class TuanLamViec
    {
        [Inject] DialogService DialogService { get; set; }
        private IEnumerable<WeatherForecast> forecasts;
        IList<WeatherForecast> selectedEmployees;
        IList<WeatherForecast> selectedEmployeesdDetail;
        IList<WeatherForecast> selectedEmployeesdKhoa;
        bool checkBox1Value;
        protected override async Task OnInitializedAsync()
        {
            forecasts = await Http.GetFromJsonAsync<IEnumerable<WeatherForecast>>("sample-data/weather.json");
        }

        public void Click(WeatherForecast forecasts)
        {
            Console.WriteLine($"Da click{forecasts.TemperatureF}");
        }

        void RowRender(RowRenderEventArgs<WeatherForecast> args)
        {

        }

        void RowExpand(WeatherForecast order)
        {

        }
        public async Task OpenOrder()
        {
            await DialogService.OpenAsync<ThemSuaTuanLamViec>("Thêm tuần làm việc");
        }

        public class WeatherForecast
        {
            public DateTime Date { get; set; }

            public int TemperatureC { get; set; }

            public string Summary { get; set; }

            public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
        }
    }
}
