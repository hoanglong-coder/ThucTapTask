#pragma checksum "C:\Users\HoangLong\Documents\GitHub\ThucTapTask\TASK.WebApp\Shared\Choose.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f0741954017682cd7cd90de19e24b4fdd24f4b05"
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
#nullable restore
#line 14 "C:\Users\HoangLong\Documents\GitHub\ThucTapTask\TASK.WebApp\_Imports.razor"
using ChartJs.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\HoangLong\Documents\GitHub\ThucTapTask\TASK.WebApp\_Imports.razor"
using ChartJs.Blazor.Common;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\HoangLong\Documents\GitHub\ThucTapTask\TASK.WebApp\_Imports.razor"
using ChartJs.Blazor.Common.Axes;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\HoangLong\Documents\GitHub\ThucTapTask\TASK.WebApp\_Imports.razor"
using ChartJs.Blazor.Common.Axes.Ticks;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\HoangLong\Documents\GitHub\ThucTapTask\TASK.WebApp\_Imports.razor"
using ChartJs.Blazor.Common.Enums;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\HoangLong\Documents\GitHub\ThucTapTask\TASK.WebApp\_Imports.razor"
using ChartJs.Blazor.Common.Handlers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\HoangLong\Documents\GitHub\ThucTapTask\TASK.WebApp\_Imports.razor"
using ChartJs.Blazor.Common.Time;

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Users\HoangLong\Documents\GitHub\ThucTapTask\TASK.WebApp\_Imports.razor"
using ChartJs.Blazor.Util;

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\Users\HoangLong\Documents\GitHub\ThucTapTask\TASK.WebApp\_Imports.razor"
using ChartJs.Blazor.Interop;

#line default
#line hidden
#nullable disable
    public partial class Choose : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(0);
            __builder.AddAttribute(1, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenElement(2, "h1");
                __builder2.AddMarkupContent(3, "Chưa đăng nhập vào lại trang ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenLink>(4);
                __builder2.AddAttribute(5, "Path", "/");
                __builder2.AddAttribute(6, "Text", "đăng nhập");
                __builder2.CloseComponent();
                __builder2.CloseElement();
            }
            ));
            __builder.AddAttribute(7, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
#nullable restore
#line 7 "C:\Users\HoangLong\Documents\GitHub\ThucTapTask\TASK.WebApp\Shared\Choose.razor"
__builder2.AddContent(8, Body);

#line default
#line hidden
#nullable disable
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
