#pragma checksum "C:\Users\HoangLong\Documents\GitHub\ThucTapTask\TASK.WebApp\Pages\ToDoList\SuaTodo.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3cbc8fcd8b11b4b55e3bb5903ca125c289a4eb24"
// <auto-generated/>
#pragma warning disable 1591
namespace TASK.WebApp.Pages.ToDoList
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
#line 2 "C:\Users\HoangLong\Documents\GitHub\ThucTapTask\TASK.WebApp\Pages\ToDoList\SuaTodo.razor"
using TASK.Application.MToDoList;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/suatodo/{matodo}")]
    public partial class SuaTodo : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<style>\r\n    form .row {\r\n        margin-bottom: 16px;\r\n    }\r\n</style>");
#nullable restore
#line 8 "C:\Users\HoangLong\Documents\GitHub\ThucTapTask\TASK.WebApp\Pages\ToDoList\SuaTodo.razor"
 if (toDoListDTO == null)
{

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<TASK.WebApp.Shared.PageLoading>(1);
            __builder.CloseComponent();
#nullable restore
#line 11 "C:\Users\HoangLong\Documents\GitHub\ThucTapTask\TASK.WebApp\Pages\ToDoList\SuaTodo.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<Radzen.Blazor.RadzenTemplateForm<ToDoListRequest>>(2);
            __builder.AddAttribute(3, "Data", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<ToDoListRequest>(
#nullable restore
#line 14 "C:\Users\HoangLong\Documents\GitHub\ThucTapTask\TASK.WebApp\Pages\ToDoList\SuaTodo.razor"
                                                      ToDoListRequest

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "Submit", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<ToDoListRequest>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<ToDoListRequest>(this, 
#nullable restore
#line 14 "C:\Users\HoangLong\Documents\GitHub\ThucTapTask\TASK.WebApp\Pages\ToDoList\SuaTodo.razor"
                                                                              UpdateTodo

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(5, "InvalidSubmit", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Radzen.FormInvalidSubmitEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Radzen.FormInvalidSubmitEventArgs>(this, 
#nullable restore
#line 14 "C:\Users\HoangLong\Documents\GitHub\ThucTapTask\TASK.WebApp\Pages\ToDoList\SuaTodo.razor"
                                                                                                        OnInvalidSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(6, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenElement(7, "div");
                __builder2.AddAttribute(8, "class", "row");
                __builder2.OpenElement(9, "div");
                __builder2.AddAttribute(10, "class", "col-md-3 align-items-center d-flex");
                __builder2.OpenComponent<Radzen.Blazor.RadzenLabel>(11);
                __builder2.AddAttribute(12, "Text", "Nội dung*");
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(13, "\r\n            ");
                __builder2.OpenElement(14, "div");
                __builder2.AddAttribute(15, "class", "col-md-5");
                __builder2.OpenComponent<Radzen.Blazor.RadzenTextBox>(16);
                __builder2.AddAttribute(17, "style", "width: 100%;");
                __builder2.AddAttribute(18, "Name", "NoiDung");
                __builder2.AddAttribute(19, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 20 "C:\Users\HoangLong\Documents\GitHub\ThucTapTask\TASK.WebApp\Pages\ToDoList\SuaTodo.razor"
                                                                                ToDoListRequest.NoiDung

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(20, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => ToDoListRequest.NoiDung = __value, ToDoListRequest.NoiDung))));
                __builder2.AddAttribute(21, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => ToDoListRequest.NoiDung));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(22, "\r\n                ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenRequiredValidator>(23);
                __builder2.AddAttribute(24, "Component", "NoiDung");
                __builder2.AddAttribute(25, "Text", "Không được để trống");
                __builder2.AddAttribute(26, "Popup", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 21 "C:\Users\HoangLong\Documents\GitHub\ThucTapTask\TASK.WebApp\Pages\ToDoList\SuaTodo.razor"
                                                                                              true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(27, "Style", "width:136px");
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(28, "\r\n        ");
                __builder2.OpenElement(29, "div");
                __builder2.AddAttribute(30, "class", "row");
                __builder2.OpenElement(31, "div");
                __builder2.AddAttribute(32, "class", "col-md-3 align-items-center d-flex");
                __builder2.OpenComponent<Radzen.Blazor.RadzenLabel>(33);
                __builder2.AddAttribute(34, "Text", "Người thực hiện*");
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(35, "\r\n            ");
                __builder2.OpenElement(36, "div");
                __builder2.AddAttribute(37, "class", "col-md-5");
                __Blazor.TASK.WebApp.Pages.ToDoList.SuaTodo.TypeInference.CreateRadzenDropDown_0(__builder2, 38, 39, 
#nullable restore
#line 29 "C:\Users\HoangLong\Documents\GitHub\ThucTapTask\TASK.WebApp\Pages\ToDoList\SuaTodo.razor"
                                            true

#line default
#line hidden
#nullable disable
                , 40, 
#nullable restore
#line 29 "C:\Users\HoangLong\Documents\GitHub\ThucTapTask\TASK.WebApp\Pages\ToDoList\SuaTodo.razor"
                                                        userResponses

#line default
#line hidden
#nullable disable
                , 41, 
#nullable restore
#line 29 "C:\Users\HoangLong\Documents\GitHub\ThucTapTask\TASK.WebApp\Pages\ToDoList\SuaTodo.razor"
                                                                                            true

#line default
#line hidden
#nullable disable
                , 42, "width: 100%", 43, 
#nullable restore
#line 30 "C:\Users\HoangLong\Documents\GitHub\ThucTapTask\TASK.WebApp\Pages\ToDoList\SuaTodo.razor"
                                                true

#line default
#line hidden
#nullable disable
                , 44, "Chọn người thực hiện", 45, "User", 46, "TenUser", 47, "MaUser", 48, 
#nullable restore
#line 30 "C:\Users\HoangLong\Documents\GitHub\ThucTapTask\TASK.WebApp\Pages\ToDoList\SuaTodo.razor"
                                                                                                                                                                ToDoListRequest.MaUser

#line default
#line hidden
#nullable disable
                , 49, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => ToDoListRequest.MaUser = __value, ToDoListRequest.MaUser)), 50, () => ToDoListRequest.MaUser);
                __builder2.AddMarkupContent(51, "\r\n                ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenRequiredValidator>(52);
                __builder2.AddAttribute(53, "Component", "User");
                __builder2.AddAttribute(54, "Text", "Phải chọn người thực hiện");
                __builder2.AddAttribute(55, "Popup", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 31 "C:\Users\HoangLong\Documents\GitHub\ThucTapTask\TASK.WebApp\Pages\ToDoList\SuaTodo.razor"
                                                                                                 true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(56, "Style", "width:171px");
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(57, "\r\n        ");
                __builder2.OpenElement(58, "div");
                __builder2.AddAttribute(59, "class", "row");
                __builder2.OpenElement(60, "div");
                __builder2.AddAttribute(61, "class", "col-md-3 align-items-center d-flex");
                __builder2.OpenComponent<Radzen.Blazor.RadzenLabel>(62);
                __builder2.AddAttribute(63, "Text", "Ngày giao*");
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(64, "\r\n            ");
                __builder2.OpenElement(65, "div");
                __builder2.AddAttribute(66, "class", "col-md-3");
                __Blazor.TASK.WebApp.Pages.ToDoList.SuaTodo.TypeInference.CreateRadzenDatePicker_1(__builder2, 67, 68, "d", 69, "width: 100%", 70, 
#nullable restore
#line 39 "C:\Users\HoangLong\Documents\GitHub\ThucTapTask\TASK.WebApp\Pages\ToDoList\SuaTodo.razor"
                                               ToDoListRequest.NgayGiao

#line default
#line hidden
#nullable disable
                , 71, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => ToDoListRequest.NgayGiao = __value, ToDoListRequest.NgayGiao)), 72, () => ToDoListRequest.NgayGiao);
                __builder2.CloseElement();
                __builder2.AddMarkupContent(73, "\r\n            ");
                __builder2.OpenElement(74, "div");
                __builder2.AddAttribute(75, "class", "col-md-2 align-items-center d-flex");
                __builder2.OpenComponent<Radzen.Blazor.RadzenLabel>(76);
                __builder2.AddAttribute(77, "Text", "Đến hạn*");
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(78, "\r\n            ");
                __builder2.OpenElement(79, "div");
                __builder2.AddAttribute(80, "class", "col-md-3");
                __Blazor.TASK.WebApp.Pages.ToDoList.SuaTodo.TypeInference.CreateRadzenDatePicker_2(__builder2, 81, 82, "DenHan", 83, "d", 84, "width: 100%", 85, 
#nullable restore
#line 45 "C:\Users\HoangLong\Documents\GitHub\ThucTapTask\TASK.WebApp\Pages\ToDoList\SuaTodo.razor"
                                               ToDoListRequest.NgayDenHang

#line default
#line hidden
#nullable disable
                , 86, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => ToDoListRequest.NgayDenHang = __value, ToDoListRequest.NgayDenHang)), 87, () => ToDoListRequest.NgayDenHang);
                __builder2.AddMarkupContent(88, "\r\n                ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenRequiredValidator>(89);
                __builder2.AddAttribute(90, "Component", "DenHan");
                __builder2.AddAttribute(91, "Text", "Phải chọn thời gian đến hạn");
                __builder2.AddAttribute(92, "Popup", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 46 "C:\Users\HoangLong\Documents\GitHub\ThucTapTask\TASK.WebApp\Pages\ToDoList\SuaTodo.razor"
                                                                                                     true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(93, "Style", "width:195px;");
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(94, "\r\n        ");
                __builder2.OpenElement(95, "div");
                __builder2.AddAttribute(96, "class", "row");
                __builder2.OpenElement(97, "div");
                __builder2.AddAttribute(98, "class", "col-md-3 align-items-center d-flex");
                __builder2.OpenComponent<Radzen.Blazor.RadzenLabel>(99);
                __builder2.AddAttribute(100, "Text", "Ghi chú");
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(101, "\r\n            ");
                __builder2.OpenElement(102, "div");
                __builder2.AddAttribute(103, "class", "col-md-9");
                __builder2.OpenComponent<Radzen.Blazor.RadzenTextBox>(104);
                __builder2.AddAttribute(105, "Style", "width: 100%");
                __builder2.AddAttribute(106, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 54 "C:\Users\HoangLong\Documents\GitHub\ThucTapTask\TASK.WebApp\Pages\ToDoList\SuaTodo.razor"
                                                                ToDoListRequest.GhiChu

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(107, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => ToDoListRequest.GhiChu = __value, ToDoListRequest.GhiChu))));
                __builder2.AddAttribute(108, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => ToDoListRequest.GhiChu));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(109, "\r\n        ");
                __builder2.OpenElement(110, "div");
                __builder2.AddAttribute(111, "class", "row");
                __builder2.OpenElement(112, "div");
                __builder2.AddAttribute(113, "class", "col-md-4 align-items-center d-flex");
                __builder2.OpenComponent<Radzen.Blazor.RadzenLabel>(114);
                __builder2.AddAttribute(115, "Text", "Trạng thái");
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(116, "\r\n            ");
                __builder2.OpenElement(117, "div");
                __builder2.AddAttribute(118, "class", "col-md-8");
                __builder2.OpenComponent<Radzen.Blazor.RadzenRadioButtonList<bool>>(119);
                __builder2.AddAttribute(120, "Style", "margin-left:-58px");
                __builder2.AddAttribute(121, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<bool>(
#nullable restore
#line 62 "C:\Users\HoangLong\Documents\GitHub\ThucTapTask\TASK.WebApp\Pages\ToDoList\SuaTodo.razor"
                                                                  ToDoListRequest.TrangThai

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(122, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<bool>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<bool>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => ToDoListRequest.TrangThai = __value, ToDoListRequest.TrangThai))));
                __builder2.AddAttribute(123, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<bool>>>(() => ToDoListRequest.TrangThai));
                __builder2.AddAttribute(124, "Items", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __Blazor.TASK.WebApp.Pages.ToDoList.SuaTodo.TypeInference.CreateRadzenRadioButtonListItem_3(__builder3, 125, 126, "Chưa xong", 127, 
#nullable restore
#line 64 "C:\Users\HoangLong\Documents\GitHub\ThucTapTask\TASK.WebApp\Pages\ToDoList\SuaTodo.razor"
                                                                           false

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddMarkupContent(128, "\r\n                        ");
                    __Blazor.TASK.WebApp.Pages.ToDoList.SuaTodo.TypeInference.CreateRadzenRadioButtonListItem_4(__builder3, 129, 130, "Xong", 131, 
#nullable restore
#line 65 "C:\Users\HoangLong\Documents\GitHub\ThucTapTask\TASK.WebApp\Pages\ToDoList\SuaTodo.razor"
                                                                      true

#line default
#line hidden
#nullable disable
                    );
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(132, "\r\n        ");
                __builder2.OpenElement(133, "div");
                __builder2.AddAttribute(134, "class", "row mt-3");
                __builder2.OpenElement(135, "div");
                __builder2.AddAttribute(136, "class", "col-md-4");
                __builder2.OpenComponent<Radzen.Blazor.RadzenButton>(137);
                __builder2.AddAttribute(138, "Text", "Cập nhật & đóng");
                __builder2.AddAttribute(139, "ButtonStyle", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#nullable restore
#line 72 "C:\Users\HoangLong\Documents\GitHub\ThucTapTask\TASK.WebApp\Pages\ToDoList\SuaTodo.razor"
                                                                  ButtonStyle.Secondary

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(140, "Icon", "save");
                __builder2.AddAttribute(141, "Style", "float:right;width:207px");
                __builder2.AddAttribute(142, "ButtonType", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonType>(
#nullable restore
#line 72 "C:\Users\HoangLong\Documents\GitHub\ThucTapTask\TASK.WebApp\Pages\ToDoList\SuaTodo.razor"
                                                                                                                                                 ButtonType.Submit

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(143, "\r\n            ");
                __builder2.OpenElement(144, "div");
                __builder2.AddAttribute(145, "class", "col-md-4");
                __builder2.OpenComponent<Radzen.Blazor.RadzenButton>(146);
                __builder2.AddAttribute(147, "Text", "Đóng");
                __builder2.AddAttribute(148, "ButtonStyle", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#nullable restore
#line 75 "C:\Users\HoangLong\Documents\GitHub\ThucTapTask\TASK.WebApp\Pages\ToDoList\SuaTodo.razor"
                                                       ButtonStyle.Secondary

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(149, "Click", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 75 "C:\Users\HoangLong\Documents\GitHub\ThucTapTask\TASK.WebApp\Pages\ToDoList\SuaTodo.razor"
                                                                                       args=>dialogService.Close(true)

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(150, "Style", "float: left ");
                __builder2.AddAttribute(151, "Icon", "cancel");
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
#nullable restore
#line 79 "C:\Users\HoangLong\Documents\GitHub\ThucTapTask\TASK.WebApp\Pages\ToDoList\SuaTodo.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
    }
}
namespace __Blazor.TASK.WebApp.Pages.ToDoList.SuaTodo
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateRadzenDropDown_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Boolean __arg0, int __seq1, global::System.Collections.IEnumerable __arg1, int __seq2, global::System.Boolean __arg2, int __seq3, global::System.String __arg3, int __seq4, global::System.Boolean __arg4, int __seq5, global::System.String __arg5, int __seq6, global::System.String __arg6, int __seq7, global::System.String __arg7, int __seq8, global::System.String __arg8, int __seq9, global::System.Object __arg9, int __seq10, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg10, int __seq11, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg11)
        {
        __builder.OpenComponent<global::Radzen.Blazor.RadzenDropDown<TValue>>(seq);
        __builder.AddAttribute(__seq0, "AllowClear", __arg0);
        __builder.AddAttribute(__seq1, "Data", __arg1);
        __builder.AddAttribute(__seq2, "AllowVirtualization", __arg2);
        __builder.AddAttribute(__seq3, "Style", __arg3);
        __builder.AddAttribute(__seq4, "AllowFiltering", __arg4);
        __builder.AddAttribute(__seq5, "Placeholder", __arg5);
        __builder.AddAttribute(__seq6, "Name", __arg6);
        __builder.AddAttribute(__seq7, "TextProperty", __arg7);
        __builder.AddAttribute(__seq8, "ValueProperty", __arg8);
        __builder.AddAttribute(__seq9, "Value", __arg9);
        __builder.AddAttribute(__seq10, "ValueChanged", __arg10);
        __builder.AddAttribute(__seq11, "ValueExpression", __arg11);
        __builder.CloseComponent();
        }
        public static void CreateRadzenDatePicker_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, global::System.String __arg1, int __seq2, global::System.Object __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4)
        {
        __builder.OpenComponent<global::Radzen.Blazor.RadzenDatePicker<TValue>>(seq);
        __builder.AddAttribute(__seq0, "DateFormat", __arg0);
        __builder.AddAttribute(__seq1, "Style", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateRadzenDatePicker_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, global::System.String __arg1, int __seq2, global::System.String __arg2, int __seq3, global::System.Object __arg3, int __seq4, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg4, int __seq5, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg5)
        {
        __builder.OpenComponent<global::Radzen.Blazor.RadzenDatePicker<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Name", __arg0);
        __builder.AddAttribute(__seq1, "DateFormat", __arg1);
        __builder.AddAttribute(__seq2, "Style", __arg2);
        __builder.AddAttribute(__seq3, "Value", __arg3);
        __builder.AddAttribute(__seq4, "ValueChanged", __arg4);
        __builder.AddAttribute(__seq5, "ValueExpression", __arg5);
        __builder.CloseComponent();
        }
        public static void CreateRadzenRadioButtonListItem_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, TValue __arg1)
        {
        __builder.OpenComponent<global::Radzen.Blazor.RadzenRadioButtonListItem<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Text", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.CloseComponent();
        }
        public static void CreateRadzenRadioButtonListItem_4<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, TValue __arg1)
        {
        __builder.OpenComponent<global::Radzen.Blazor.RadzenRadioButtonListItem<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Text", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
