using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TASK.WebApp.Pages.Login
{
    public partial class Login
    {
       [Inject] NavigationManager muav { get; set; }

       public void OnLogin()
       {

            muav.NavigateTo("/dashboard");
       }
    }
}
