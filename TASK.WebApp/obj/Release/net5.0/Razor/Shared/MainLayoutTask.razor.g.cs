#pragma checksum "C:\Users\HoangLong\Documents\GitHub\ThucTapTask\TASK.WebApp\Shared\MainLayoutTask.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ffbf625a14deb645f6e5ceb2a7d999adf1c64dbb"
// <auto-generated/>
#pragma warning disable 1591
namespace TASK.WebApp.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\HoangLong\Documents\GitHub\ThucTapTask\TASK.WebApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\HoangLong\Documents\GitHub\ThucTapTask\TASK.WebApp\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\HoangLong\Documents\GitHub\ThucTapTask\TASK.WebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\HoangLong\Documents\GitHub\ThucTapTask\TASK.WebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\HoangLong\Documents\GitHub\ThucTapTask\TASK.WebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\HoangLong\Documents\GitHub\ThucTapTask\TASK.WebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\HoangLong\Documents\GitHub\ThucTapTask\TASK.WebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\HoangLong\Documents\GitHub\ThucTapTask\TASK.WebApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\HoangLong\Documents\GitHub\ThucTapTask\TASK.WebApp\_Imports.razor"
using TASK.WebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\HoangLong\Documents\GitHub\ThucTapTask\TASK.WebApp\_Imports.razor"
using TASK.WebApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\HoangLong\Documents\GitHub\ThucTapTask\TASK.WebApp\_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\HoangLong\Documents\GitHub\ThucTapTask\TASK.WebApp\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\HoangLong\Documents\GitHub\ThucTapTask\TASK.WebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
    public partial class MainLayoutTask : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 5 "C:\Users\HoangLong\Documents\GitHub\ThucTapTask\TASK.WebApp\Shared\MainLayoutTask.razor"
 if (checkLogin == 0)
{

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<TASK.WebApp.Shared.PageLoading>(0);
            __builder.CloseComponent();
#nullable restore
#line 8 "C:\Users\HoangLong\Documents\GitHub\ThucTapTask\TASK.WebApp\Shared\MainLayoutTask.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<Radzen.Blazor.RadzenDialog>(1);
            __builder.CloseComponent();
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenComponent<Radzen.Blazor.RadzenNotification>(3);
            __builder.CloseComponent();
            __builder.AddMarkupContent(4, "\r\n    ");
            __builder.OpenComponent<Radzen.Blazor.RadzenTooltip>(5);
            __builder.CloseComponent();
            __builder.AddMarkupContent(6, "\r\n    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(7);
            __builder.AddAttribute(8, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenElement(9, "h1");
                __builder2.AddAttribute(10, "b-ddu2sm3c4m");
                __builder2.AddMarkupContent(11, "Chưa đăng nhập vào lại trang ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenLink>(12);
                __builder2.AddAttribute(13, "Path", "/");
                __builder2.AddAttribute(14, "Text", "đăng nhập");
                __builder2.CloseComponent();
                __builder2.CloseElement();
            }
            ));
            __builder.AddAttribute(15, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenComponent<Radzen.Blazor.RadzenCard>(16);
                __builder2.AddAttribute(17, "Style", "border:3px solid;border-radius:unset;height:176px");
                __builder2.AddAttribute(18, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<TASK.WebApp.Shared.ProfileMenu>(19);
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(20, "\r\n                ");
                    __builder3.OpenComponent<TASK.WebApp.Shared.NavMenuTask>(21);
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(22, "\r\n            ");
                __builder2.OpenElement(23, "div");
                __builder2.AddAttribute(24, "class", "content");
                __builder2.AddAttribute(25, "style", "margin-top:-19px");
                __builder2.AddAttribute(26, "b-ddu2sm3c4m");
#nullable restore
#line 24 "C:\Users\HoangLong\Documents\GitHub\ThucTapTask\TASK.WebApp\Shared\MainLayoutTask.razor"
__builder2.AddContent(27, Body);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.AddMarkupContent(28, "\r\n            ");
                __builder2.OpenElement(29, "div");
                __builder2.AddAttribute(30, "class", "footer");
                __builder2.AddAttribute(31, "style", "border: 3px solid");
                __builder2.AddAttribute(32, "b-ddu2sm3c4m");
                __builder2.OpenElement(33, "div");
                __builder2.AddAttribute(34, "class", "row");
                __builder2.AddAttribute(35, "b-ddu2sm3c4m");
                __builder2.OpenElement(36, "div");
                __builder2.AddAttribute(37, "class", "col-4");
                __builder2.AddAttribute(38, "b-ddu2sm3c4m");
                __builder2.OpenElement(39, "h4");
                __builder2.AddAttribute(40, "b-ddu2sm3c4m");
                __builder2.AddMarkupContent(41, "<i class=\"fas fa-calendar-check\" style=\"font-size: 25px;margin-right:4px\" b-ddu2sm3c4m></i> ");
#nullable restore
#line 28 "C:\Users\HoangLong\Documents\GitHub\ThucTapTask\TASK.WebApp\Shared\MainLayoutTask.razor"
__builder2.AddContent(42, DateTime.Now.ToString("dd-MM-yyyy"));

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(43, "\r\n                    ");
                __builder2.AddMarkupContent(44, "<div class=\"col-4\" style=\"text-align: center; margin: auto; margin-top: auto\" b-ddu2sm3c4m><h4 style b-ddu2sm3c4m>Copyright 2021</h4></div>\r\n                    ");
                __builder2.AddMarkupContent(45, "<div class=\"col-4\" style=\"text-align: right; margin-top: auto\" b-ddu2sm3c4m><h4 b-ddu2sm3c4m>Designed by ASC</h4></div>");
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
#nullable restore
#line 37 "C:\Users\HoangLong\Documents\GitHub\ThucTapTask\TASK.WebApp\Shared\MainLayoutTask.razor"



}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 43 "C:\Users\HoangLong\Documents\GitHub\ThucTapTask\TASK.WebApp\Shared\MainLayoutTask.razor"
      
    public int checkLogin { get; set; }

    protected override async Task OnInitializedAsync()
    {
        await Task.Delay(100);
        checkLogin = 1;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591