using Radzen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TASK.WebApp.Pages.ChooseTask
{
    public partial class ChooseTask
    {
        public int checkLogin { get; set; }

        protected override async Task OnInitializedAsync()
        {
            await Task.Delay(4000);
            checkLogin = 1;
        }
    }
}
