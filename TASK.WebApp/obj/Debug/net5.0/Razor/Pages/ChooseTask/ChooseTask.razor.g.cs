#pragma checksum "C:\Users\HoangLong\Documents\GitHub\ThucTapTask\TASK.WebApp\Pages\ChooseTask\ChooseTask.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "29a8a7dcf9f667b518f828c9d3ae064e350c7a8d"
// <auto-generated/>
#pragma warning disable 1591
namespace TASK.WebApp.Pages.ChooseTask
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
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(Choose))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/choosetask")]
    public partial class ChooseTask : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 5 "C:\Users\HoangLong\Documents\GitHub\ThucTapTask\TASK.WebApp\Pages\ChooseTask\ChooseTask.razor"
 if (DuAns == null)
{

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<TASK.WebApp.Shared.PageLoading>(0);
            __builder.CloseComponent();
#nullable restore
#line 8 "C:\Users\HoangLong\Documents\GitHub\ThucTapTask\TASK.WebApp\Pages\ChooseTask\ChooseTask.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(1, @"<div class=""container""><center class=""mt-4""><h1><img src=""https://media.ascvn.com.vn/Media/1_HOME_ASC/Images/logo-ascvn9d865d6-77.png"" alt=""Logo"" style=""margin-right:10px"">ASC TASK PLANNING</h1>
            <center><h5>HỆ THỐNG QUẢN LÝ CÔNG VIỆC</h5></center></center></div>
    ");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "container");
            __builder.OpenComponent<Radzen.Blazor.RadzenMenu>(4);
            __builder.AddAttribute(5, "Style", "background-color: rgb(243,245,247);margin:auto;margin-top:81px");
            __builder.AddAttribute(6, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenElement(7, "div");
                __builder2.AddAttribute(8, "class", "row");
                __builder2.AddAttribute(9, "style", "margin:auto");
#nullable restore
#line 20 "C:\Users\HoangLong\Documents\GitHub\ThucTapTask\TASK.WebApp\Pages\ChooseTask\ChooseTask.razor"
                 foreach (var item in DuAns)
                {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(10, "div");
                __builder2.AddAttribute(11, "class", "col-4");
                __builder2.OpenComponent<Radzen.Blazor.RadzenCard>(12);
                __builder2.AddAttribute(13, "Style", "width:300px; margin-bottom: 20px; height:300px;");
                __builder2.AddAttribute(14, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenElement(15, "div");
                    __builder3.AddAttribute(16, "style", "font-size: 20px; margin: auto");
#nullable restore
#line 25 "C:\Users\HoangLong\Documents\GitHub\ThucTapTask\TASK.WebApp\Pages\ChooseTask\ChooseTask.razor"
                                  
                                    if (item.TenDuAn == "Dự án Dev")
                                    {

#line default
#line hidden
#nullable disable
                    __builder3.AddMarkupContent(17, "<i class=\"fas fa-school fa-10x\"></i>");
#nullable restore
#line 29 "C:\Users\HoangLong\Documents\GitHub\ThucTapTask\TASK.WebApp\Pages\ChooseTask\ChooseTask.razor"
                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
                    __builder3.AddMarkupContent(18, "<i class=\"fas fa-tasks fa-10x\"></i>");
#nullable restore
#line 33 "C:\Users\HoangLong\Documents\GitHub\ThucTapTask\TASK.WebApp\Pages\ChooseTask\ChooseTask.razor"
                                    }
                                

#line default
#line hidden
#nullable disable
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(19, "\r\n                            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenButton>(20);
                    __builder3.AddAttribute(21, "Click", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 36 "C:\Users\HoangLong\Documents\GitHub\ThucTapTask\TASK.WebApp\Pages\ChooseTask\ChooseTask.razor"
                                                  args => OnClick(item.MaDuAn.ToString())

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.AddAttribute(22, "Text", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 36 "C:\Users\HoangLong\Documents\GitHub\ThucTapTask\TASK.WebApp\Pages\ChooseTask\ChooseTask.razor"
                                                                                                  item.TenDuAn

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(23, "ButtonStyle", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#nullable restore
#line 36 "C:\Users\HoangLong\Documents\GitHub\ThucTapTask\TASK.WebApp\Pages\ChooseTask\ChooseTask.razor"
                                                                                                                             ButtonStyle.Success

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
#nullable restore
#line 39 "C:\Users\HoangLong\Documents\GitHub\ThucTapTask\TASK.WebApp\Pages\ChooseTask\ChooseTask.razor"
                }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
#nullable restore
#line 43 "C:\Users\HoangLong\Documents\GitHub\ThucTapTask\TASK.WebApp\Pages\ChooseTask\ChooseTask.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
