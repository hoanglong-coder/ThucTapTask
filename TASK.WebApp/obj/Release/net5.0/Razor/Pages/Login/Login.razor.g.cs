#pragma checksum "C:\Users\HoangLong\Documents\GitHub\ThucTapTask\TASK.WebApp\Pages\Login\Login.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aeef9a26d1760ca02948ff39498c682af965243e"
// <auto-generated/>
#pragma warning disable 1591
namespace TASK.WebApp.Pages.Login
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
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(BaseLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Login : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, @"<div class=""container"" b-9mg2jv3lsg><center class=""mt-4"" b-9mg2jv3lsg><h1 b-9mg2jv3lsg><img src=""https://media.ascvn.com.vn/Media/1_HOME_ASC/Images/logo-ascvn9d865d6-77.png"" alt=""Logo"" style=""margin-right:10px"" b-9mg2jv3lsg>ASC TASK PLANNING</h1>
            <center b-9mg2jv3lsg><h5 b-9mg2jv3lsg>HỆ THỐNG QUẢN LÝ CÔNG VIỆC</h5></center></center></div>
    ");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "container h-100");
            __builder.AddAttribute(3, "b-9mg2jv3lsg");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "d-flex justify-content-center h-100");
            __builder.AddAttribute(6, "b-9mg2jv3lsg");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "user_card");
            __builder.AddAttribute(9, "b-9mg2jv3lsg");
            __builder.AddMarkupContent(10, "<div class=\"d-flex justify-content-center\" b-9mg2jv3lsg><div class=\"brand_logo_container\" b-9mg2jv3lsg><img src=\"https://cdn-icons-png.flaticon.com/128/1077/1077063.png\" class=\"brand_logo\" alt=\"Logo\" b-9mg2jv3lsg></div></div>\r\n                ");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "d-flex justify-content-center form_container");
            __builder.AddAttribute(13, "b-9mg2jv3lsg");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(14);
            __builder.AddAttribute(15, "Model", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 18 "C:\Users\HoangLong\Documents\GitHub\ThucTapTask\TASK.WebApp\Pages\Login\Login.razor"
                                     loginRequest

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(16, "OnValidSubmit", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 18 "C:\Users\HoangLong\Documents\GitHub\ThucTapTask\TASK.WebApp\Pages\Login\Login.razor"
                                                                  OnLogin

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(17, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(18);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(19, "\r\n                        ");
                __builder2.OpenElement(20, "div");
                __builder2.AddAttribute(21, "class", "input-group mb-3");
                __builder2.AddAttribute(22, "b-9mg2jv3lsg");
                __builder2.AddMarkupContent(23, "<div class=\"input-group-append\" b-9mg2jv3lsg><span class=\"input-group-text\" b-9mg2jv3lsg><i class=\"fas fa-user\" b-9mg2jv3lsg></i></span></div>\r\n                            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(24);
                __builder2.AddAttribute(25, "class", "form-control input_user");
                __builder2.AddAttribute(26, "placeholder", "Tên đăng nhập");
                __builder2.AddAttribute(27, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 24 "C:\Users\HoangLong\Documents\GitHub\ThucTapTask\TASK.WebApp\Pages\Login\Login.razor"
                                                                                                                loginRequest.UserName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(28, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => loginRequest.UserName = __value, loginRequest.UserName))));
                __builder2.AddAttribute(29, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => loginRequest.UserName));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(30, "<br b-9mg2jv3lsg>");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(31, "\r\n                        ");
                __builder2.OpenElement(32, "div");
                __builder2.AddAttribute(33, "class", "input-group mb-3");
                __builder2.AddAttribute(34, "b-9mg2jv3lsg");
                __Blazor.TASK.WebApp.Pages.Login.Login.TypeInference.CreateValidationMessage_0(__builder2, 35, 36, "color:white", 37, 
#nullable restore
#line 27 "C:\Users\HoangLong\Documents\GitHub\ThucTapTask\TASK.WebApp\Pages\Login\Login.razor"
                                                                        ()=>loginRequest.UserName

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(38, "\r\n                        ");
                __builder2.OpenElement(39, "div");
                __builder2.AddAttribute(40, "class", "input-group mb-2");
                __builder2.AddAttribute(41, "b-9mg2jv3lsg");
                __builder2.AddMarkupContent(42, "<div class=\"input-group-append\" b-9mg2jv3lsg><span class=\"input-group-text\" b-9mg2jv3lsg><i class=\"fas fa-key\" b-9mg2jv3lsg></i></span></div>\r\n                            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(43);
                __builder2.AddAttribute(44, "type", "password");
                __builder2.AddAttribute(45, "class", "form-control input_pass");
                __builder2.AddAttribute(46, "placeholder", "Mật khẩu");
                __builder2.AddAttribute(47, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 33 "C:\Users\HoangLong\Documents\GitHub\ThucTapTask\TASK.WebApp\Pages\Login\Login.razor"
                                                                                                                           loginRequest.Password

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(48, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => loginRequest.Password = __value, loginRequest.Password))));
                __builder2.AddAttribute(49, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => loginRequest.Password));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(50, "<br b-9mg2jv3lsg>");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(51, "\r\n                        ");
                __builder2.OpenElement(52, "div");
                __builder2.AddAttribute(53, "class", "input-group mb-2");
                __builder2.AddAttribute(54, "b-9mg2jv3lsg");
                __Blazor.TASK.WebApp.Pages.Login.Login.TypeInference.CreateValidationMessage_1(__builder2, 55, 56, "color:white", 57, 
#nullable restore
#line 36 "C:\Users\HoangLong\Documents\GitHub\ThucTapTask\TASK.WebApp\Pages\Login\Login.razor"
                                                                        ()=>loginRequest.Password

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(58, "\r\n                        ");
                __builder2.OpenElement(59, "div");
                __builder2.AddAttribute(60, "class", "d-flex justify-content-center mt-3 login_container");
                __builder2.AddAttribute(61, "b-9mg2jv3lsg");
                __builder2.OpenComponent<Radzen.Blazor.RadzenButton>(62);
                __builder2.AddAttribute(63, "type", "submit");
                __builder2.AddAttribute(64, "Text", "Đăng nhập");
                __builder2.AddAttribute(65, "Icon", "exit_to_app");
                __builder2.AddAttribute(66, "class", "btn login_btn");
                __builder2.CloseComponent();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
namespace __Blazor.TASK.WebApp.Pages.Login.Login
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg1)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "style", __arg0);
        __builder.AddAttribute(__seq1, "For", __arg1);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg1)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "style", __arg0);
        __builder.AddAttribute(__seq1, "For", __arg1);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591