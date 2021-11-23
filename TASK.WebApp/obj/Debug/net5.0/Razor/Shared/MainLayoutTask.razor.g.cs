#pragma checksum "D:\ASC\Project\TASK.WebApp\Shared\MainLayoutTask.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5f3ab25ad4115b1d46fbce89612adc337105fb3d"
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
#line 1 "D:\ASC\Project\TASK.WebApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\ASC\Project\TASK.WebApp\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\ASC\Project\TASK.WebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\ASC\Project\TASK.WebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\ASC\Project\TASK.WebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\ASC\Project\TASK.WebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\ASC\Project\TASK.WebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\ASC\Project\TASK.WebApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\ASC\Project\TASK.WebApp\_Imports.razor"
using TASK.WebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\ASC\Project\TASK.WebApp\_Imports.razor"
using TASK.WebApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\ASC\Project\TASK.WebApp\_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\ASC\Project\TASK.WebApp\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
    public partial class MainLayoutTask : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 5 "D:\ASC\Project\TASK.WebApp\Shared\MainLayoutTask.razor"
 if (checkLogin == 0)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(0, @"<div class=""wrapper"" b-ddu2sm3c4m><div class=""circle"" b-ddu2sm3c4m></div>
        <div class=""circle"" b-ddu2sm3c4m></div>
        <div class=""circle"" b-ddu2sm3c4m></div>
        <div class=""shadow"" b-ddu2sm3c4m></div>
        <div class=""shadow"" b-ddu2sm3c4m></div>
        <div class=""shadow"" b-ddu2sm3c4m></div>
        <span b-ddu2sm3c4m>Loading</span></div>");
#nullable restore
#line 16 "D:\ASC\Project\TASK.WebApp\Shared\MainLayoutTask.razor"

}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<Radzen.Blazor.RadzenCard>(1);
            __builder.AddAttribute(2, "Style", "border:3px solid;border-radius:unset;height:176px");
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<Radzen.Blazor.RadzenMenu>(4);
                __builder2.AddAttribute(5, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<Radzen.Blazor.RadzenImage>(6);
                    __builder3.AddAttribute(7, "Style", "padding:22px");
                    __builder3.AddAttribute(8, "Path", "https://media.ascvn.com.vn/Media/1_HOME_ASC/Images/logo-ascvn9d865d6-77.png");
                    __builder3.AddAttribute(9, "width", "120px");
                    __builder3.AddAttribute(10, "alt", "ASCVN2020");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(11, "\r\n            ");
                    __builder3.AddMarkupContent(12, "<h3 style=\"margin-top:23px\" b-ddu2sm3c4m><strong b-ddu2sm3c4m>ASC<br b-ddu2sm3c4m> TASK PLANNING</strong></h3>\r\n            ");
                    __builder3.AddMarkupContent(13, "<h1 style=\"color: #007bff;margin-left:auto;margin-top:28px\" b-ddu2sm3c4m>DỰ ÁN \"SCHOOL - DEVELOPERS\"</h1>\r\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenProfileMenu>(14);
                    __builder3.AddAttribute(15, "Style", "width:max-content;margin-left:auto;border-left:none");
                    __builder3.AddAttribute(16, "Template", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenElement(17, "p");
                        __builder4.AddAttribute(18, "b-ddu2sm3c4m");
                        __builder4.OpenComponent<Radzen.Blazor.RadzenImage>(19);
                        __builder4.AddAttribute(20, "Path", "https://cdn-icons-png.flaticon.com/128/483/483361.png");
                        __builder4.AddAttribute(21, "width", "50");
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(22, "\r\n                        ");
                        __builder4.AddMarkupContent(23, "<strong style=\"margin-left:3px\" b-ddu2sm3c4m>Lê Hoàng Long</strong>");
                        __builder4.CloseElement();
                    }
                    ));
                    __builder3.AddAttribute(24, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<Radzen.Blazor.RadzenProfileMenuItem>(25);
                        __builder4.AddAttribute(26, "Text", "Hồ sơ người dùng");
                        __builder4.AddAttribute(27, "Path", "#");
                        __builder4.AddAttribute(28, "Icon", "account_circle");
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(29, "\r\n                    ");
                        __builder4.OpenComponent<Radzen.Blazor.RadzenProfileMenuItem>(30);
                        __builder4.AddAttribute(31, "Text", "Đổi mật khẩu");
                        __builder4.AddAttribute(32, "Path", "#");
                        __builder4.AddAttribute(33, "Icon", "cached");
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(34, "\r\n                    ");
                        __builder4.OpenComponent<Radzen.Blazor.RadzenProfileMenuItem>(35);
                        __builder4.AddAttribute(36, "Text", "Chuyển dự án");
                        __builder4.AddAttribute(37, "Path", "#");
                        __builder4.AddAttribute(38, "Icon", "compare_arrows");
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(39, "\r\n                    ");
                        __builder4.OpenComponent<Radzen.Blazor.RadzenProfileMenuItem>(40);
                        __builder4.AddAttribute(41, "Text", "Đăng xuất");
                        __builder4.AddAttribute(42, "Path", "#");
                        __builder4.AddAttribute(43, "Icon", "exit_to_app");
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(44, "\r\n\r\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenMenu>(45);
                __builder2.AddAttribute(46, "Style", "text-decoration:underline; width: max-content; margin: auto; font-size: 20px");
                __builder2.AddAttribute(47, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<Radzen.Blazor.RadzenMenuItem>(48);
                    __builder3.AddAttribute(49, "Text", "Dashboard");
                    __builder3.AddAttribute(50, "Icon", "home");
                    __builder3.AddAttribute(51, "Path", "dashboard");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(52, "\r\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenMenuItem>(53);
                    __builder3.AddAttribute(54, "Text", "Quản lý người dùng");
                    __builder3.AddAttribute(55, "Path", "quanlynguoidung");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(56, "\r\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenMenuItem>(57);
                    __builder3.AddAttribute(58, "Text", "Tuần làm việc");
                    __builder3.AddAttribute(59, "Path", "tuanlamviec");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(60, "\r\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenMenuItem>(61);
                    __builder3.AddAttribute(62, "Text", "Quản lý công việc");
                    __builder3.AddAttribute(63, "Path", "quanlycongviec");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(64, "\r\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenMenuItem>(65);
                    __builder3.AddAttribute(66, "Text", "To-do list");
                    __builder3.AddAttribute(67, "Path", "todolist");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(68, "\r\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenMenuItem>(69);
                    __builder3.AddAttribute(70, "Text", "Báo cáo hiệu suất công việc");
                    __builder3.AddAttribute(71, "Path", "baocaohieusuat");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(72, "\r\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenMenuItem>(73);
                    __builder3.AddAttribute(74, "Text", "Phân bổ công việc");
                    __builder3.AddAttribute(75, "Path", "phanbocongviec");
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(76, "\r\n    ");
            __builder.OpenElement(77, "div");
            __builder.AddAttribute(78, "class", "content");
            __builder.AddAttribute(79, "b-ddu2sm3c4m");
#nullable restore
#line 60 "D:\ASC\Project\TASK.WebApp\Shared\MainLayoutTask.razor"
__builder.AddContent(80, Body);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(81, "\r\n    ");
            __builder.OpenElement(82, "div");
            __builder.AddAttribute(83, "class", "footer");
            __builder.AddAttribute(84, "style", "border: 3px solid");
            __builder.AddAttribute(85, "b-ddu2sm3c4m");
            __builder.OpenElement(86, "div");
            __builder.AddAttribute(87, "class", "row");
            __builder.AddAttribute(88, "b-ddu2sm3c4m");
            __builder.OpenElement(89, "div");
            __builder.AddAttribute(90, "class", "col-4");
            __builder.AddAttribute(91, "b-ddu2sm3c4m");
            __builder.OpenElement(92, "h4");
            __builder.AddAttribute(93, "b-ddu2sm3c4m");
            __builder.AddMarkupContent(94, "<i class=\"fas fa-calendar-check\" style=\"font-size: 25px;margin-right:4px\" b-ddu2sm3c4m></i> ");
#nullable restore
#line 64 "D:\ASC\Project\TASK.WebApp\Shared\MainLayoutTask.razor"
__builder.AddContent(95, DateTime.Now.ToString("dd-MM-yyyy"));

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(96, "\r\n            ");
            __builder.AddMarkupContent(97, "<div class=\"col-4\" style=\"text-align: center; margin: auto; margin-top: auto\" b-ddu2sm3c4m><h4 style b-ddu2sm3c4m>Copyright 2021</h4></div>\r\n            ");
            __builder.AddMarkupContent(98, "<div class=\"col-4\" style=\"text-align: right; margin-top: auto\" b-ddu2sm3c4m><h4 b-ddu2sm3c4m>Designed by ASC</h4></div>");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 73 "D:\ASC\Project\TASK.WebApp\Shared\MainLayoutTask.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 76 "D:\ASC\Project\TASK.WebApp\Shared\MainLayoutTask.razor"
      
    public int checkLogin { get; set; }

    protected override async Task OnInitializedAsync()
    {
        await Task.Delay(4000);
        checkLogin = 1;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
