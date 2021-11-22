using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TASK.WebApp.Shared
{
    public partial class MainLayout
    {
        public int checkLogin { get; set; }

        protected override async Task OnInitializedAsync()
        {
            await Task.Delay(1000);
            checkLogin = 1;
        }
    }
}
