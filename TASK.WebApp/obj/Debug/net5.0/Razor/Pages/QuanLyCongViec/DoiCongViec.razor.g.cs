#pragma checksum "C:\Users\HoangLong\Documents\GitHub\ThucTapTask\TASK.WebApp\Pages\QuanLyCongViec\DoiCongViec.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f95f0de7d24513ab386f90d3b498ffb374e8c7e3"
// <auto-generated/>
#pragma warning disable 1591
namespace TASK.WebApp.Pages.QuanLyCongViec
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
#line 3 "C:\Users\HoangLong\Documents\GitHub\ThucTapTask\TASK.WebApp\Pages\QuanLyCongViec\DoiCongViec.razor"
using TASK.Application.MCongViec;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/doicongviec/{macongviec}")]
    public partial class DoiCongViec : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Radzen.Blazor.RadzenTemplateForm<CongViecRequest>>(0);
            __builder.AddAttribute(1, "Data", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<CongViecRequest>(
#nullable restore
#line 6 "C:\Users\HoangLong\Documents\GitHub\ThucTapTask\TASK.WebApp\Pages\QuanLyCongViec\DoiCongViec.razor"
                                                  congViecRequest

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "Submit", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<CongViecRequest>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<CongViecRequest>(this, 
#nullable restore
#line 6 "C:\Users\HoangLong\Documents\GitHub\ThucTapTask\TASK.WebApp\Pages\QuanLyCongViec\DoiCongViec.razor"
                                                                          SubmitDoiCongViec

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenElement(4, "div");
                __builder2.AddAttribute(5, "class", "row");
                __builder2.AddMarkupContent(6, "<div class=\"col-2\">Tháng*</div>\r\n        ");
                __builder2.OpenElement(7, "div");
                __builder2.AddAttribute(8, "class", "col-4");
                __Blazor.TASK.WebApp.Pages.QuanLyCongViec.DoiCongViec.TypeInference.CreateRadzenDropDown_0(__builder2, 9, 10, 
#nullable restore
#line 10 "C:\Users\HoangLong\Documents\GitHub\ThucTapTask\TASK.WebApp\Pages\QuanLyCongViec\DoiCongViec.razor"
                                        true

#line default
#line hidden
#nullable disable
                , 11, 
#nullable restore
#line 10 "C:\Users\HoangLong\Documents\GitHub\ThucTapTask\TASK.WebApp\Pages\QuanLyCongViec\DoiCongViec.razor"
                                                    tuanLamViecResponses

#line default
#line hidden
#nullable disable
                , 12, "width: 100%", 13, 
#nullable restore
#line 11 "C:\Users\HoangLong\Documents\GitHub\ThucTapTask\TASK.WebApp\Pages\QuanLyCongViec\DoiCongViec.razor"
                                            true

#line default
#line hidden
#nullable disable
                , 14, "Chọn tháng", 15, "Thang", 16, "TenThang", 17, "MaThangLamViec", 18, Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Object>(this, 
#nullable restore
#line 11 "C:\Users\HoangLong\Documents\GitHub\ThucTapTask\TASK.WebApp\Pages\QuanLyCongViec\DoiCongViec.razor"
                                                                                                                                                                                                     args => OnChange(args)

#line default
#line hidden
#nullable disable
                ), 19, 
#nullable restore
#line 11 "C:\Users\HoangLong\Documents\GitHub\ThucTapTask\TASK.WebApp\Pages\QuanLyCongViec\DoiCongViec.razor"
                                                                                                                                                            congViecRequest.MaThangLamViec

#line default
#line hidden
#nullable disable
                , 20, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => congViecRequest.MaThangLamViec = __value, congViecRequest.MaThangLamViec)), 21, () => congViecRequest.MaThangLamViec);
                __builder2.AddMarkupContent(22, "\r\n            ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenRequiredValidator>(23);
                __builder2.AddAttribute(24, "DefaultValue", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 12 "C:\Users\HoangLong\Documents\GitHub\ThucTapTask\TASK.WebApp\Pages\QuanLyCongViec\DoiCongViec.razor"
                                                   0

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(25, "Component", "Thang");
                __builder2.AddAttribute(26, "Text", "Phải chọn tháng");
                __builder2.AddAttribute(27, "Popup", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 12 "C:\Users\HoangLong\Documents\GitHub\ThucTapTask\TASK.WebApp\Pages\QuanLyCongViec\DoiCongViec.razor"
                                                                                                     true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(28, "Style", "width:136px");
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(29, "\r\n        ");
                __builder2.AddMarkupContent(30, "<div class=\"col-2\">Tuần*</div>\r\n        ");
                __builder2.OpenElement(31, "div");
                __builder2.AddAttribute(32, "class", "col-4");
                __Blazor.TASK.WebApp.Pages.QuanLyCongViec.DoiCongViec.TypeInference.CreateRadzenDropDown_1(__builder2, 33, 34, 
#nullable restore
#line 16 "C:\Users\HoangLong\Documents\GitHub\ThucTapTask\TASK.WebApp\Pages\QuanLyCongViec\DoiCongViec.razor"
                                        true

#line default
#line hidden
#nullable disable
                , 35, 
#nullable restore
#line 16 "C:\Users\HoangLong\Documents\GitHub\ThucTapTask\TASK.WebApp\Pages\QuanLyCongViec\DoiCongViec.razor"
                                                    chiTietTuanResponses

#line default
#line hidden
#nullable disable
                , 36, "width: 100%", 37, 
#nullable restore
#line 17 "C:\Users\HoangLong\Documents\GitHub\ThucTapTask\TASK.WebApp\Pages\QuanLyCongViec\DoiCongViec.razor"
                                            true

#line default
#line hidden
#nullable disable
                , 38, "Chọn tuần", 39, "Tuan", 40, "TenTuanChitiet", 41, "MaTuanChiTiet", 42, 
#nullable restore
#line 17 "C:\Users\HoangLong\Documents\GitHub\ThucTapTask\TASK.WebApp\Pages\QuanLyCongViec\DoiCongViec.razor"
                                                                                                                                                               congViecRequest.MaTuanChiTiet

#line default
#line hidden
#nullable disable
                , 43, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => congViecRequest.MaTuanChiTiet = __value, congViecRequest.MaTuanChiTiet)), 44, () => congViecRequest.MaTuanChiTiet);
                __builder2.AddMarkupContent(45, "\r\n            ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenRequiredValidator>(46);
                __builder2.AddAttribute(47, "DefaultValue", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 18 "C:\Users\HoangLong\Documents\GitHub\ThucTapTask\TASK.WebApp\Pages\QuanLyCongViec\DoiCongViec.razor"
                                                   0

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(48, "Component", "Tuan");
                __builder2.AddAttribute(49, "Text", "Phải chọn tuần");
                __builder2.AddAttribute(50, "Popup", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 18 "C:\Users\HoangLong\Documents\GitHub\ThucTapTask\TASK.WebApp\Pages\QuanLyCongViec\DoiCongViec.razor"
                                                                                                   true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(51, "Style", "width:136px");
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(52, "\r\n        ");
                __builder2.OpenElement(53, "div");
                __builder2.AddAttribute(54, "class", "row");
                __builder2.AddAttribute(55, "style", "margin-top:52px");
                __builder2.AddMarkupContent(56, "<div class=\"col-2\">Từ ngày*</div>\r\n            ");
                __builder2.OpenElement(57, "div");
                __builder2.AddAttribute(58, "class", "col-4");
                __Blazor.TASK.WebApp.Pages.QuanLyCongViec.DoiCongViec.TypeInference.CreateRadzenDatePicker_2(__builder2, 59, 60, "TuNgay", 61, "d", 62, "width:100%", 63, 
#nullable restore
#line 24 "C:\Users\HoangLong\Documents\GitHub\ThucTapTask\TASK.WebApp\Pages\QuanLyCongViec\DoiCongViec.razor"
                                               congViecRequest.TuNgay

#line default
#line hidden
#nullable disable
                , 64, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => congViecRequest.TuNgay = __value, congViecRequest.TuNgay)), 65, () => congViecRequest.TuNgay);
                __builder2.AddMarkupContent(66, "\r\n                ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenRequiredValidator>(67);
                __builder2.AddAttribute(68, "DefaultValue", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 25 "C:\Users\HoangLong\Documents\GitHub\ThucTapTask\TASK.WebApp\Pages\QuanLyCongViec\DoiCongViec.razor"
                                                       1/1/0001

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(69, "Component", "TuNgay");
                __builder2.AddAttribute(70, "Text", "Phải chọn từ ngày");
                __builder2.AddAttribute(71, "Popup", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 25 "C:\Users\HoangLong\Documents\GitHub\ThucTapTask\TASK.WebApp\Pages\QuanLyCongViec\DoiCongViec.razor"
                                                                                                                   true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(72, "Style", "width:136px");
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(73, "\r\n            ");
                __builder2.AddMarkupContent(74, "<div class=\"col-2\">Đến ngày</div>\r\n            ");
                __builder2.OpenElement(75, "div");
                __builder2.AddAttribute(76, "class", "col-4");
                __Blazor.TASK.WebApp.Pages.QuanLyCongViec.DoiCongViec.TypeInference.CreateRadzenDatePicker_3(__builder2, 77, 78, "d", 79, "DenNgay", 80, "width:100%", 81, 
#nullable restore
#line 29 "C:\Users\HoangLong\Documents\GitHub\ThucTapTask\TASK.WebApp\Pages\QuanLyCongViec\DoiCongViec.razor"
                                               congViecRequest.DenNgay

#line default
#line hidden
#nullable disable
                , 82, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => congViecRequest.DenNgay = __value, congViecRequest.DenNgay)), 83, () => congViecRequest.DenNgay);
                __builder2.AddMarkupContent(84, "\r\n                ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenRequiredValidator>(85);
                __builder2.AddAttribute(86, "DefaultValue", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 30 "C:\Users\HoangLong\Documents\GitHub\ThucTapTask\TASK.WebApp\Pages\QuanLyCongViec\DoiCongViec.razor"
                                                       1/1/0001

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(87, "Component", "DenNgay");
                __builder2.AddAttribute(88, "Text", "Phải chọn đến ngày");
                __builder2.AddAttribute(89, "Popup", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 30 "C:\Users\HoangLong\Documents\GitHub\ThucTapTask\TASK.WebApp\Pages\QuanLyCongViec\DoiCongViec.razor"
                                                                                                                     true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(90, "Style", "width:136px");
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(91, "\r\n        ");
                __builder2.OpenElement(92, "center");
                __builder2.OpenElement(93, "div");
                __builder2.AddAttribute(94, "class", "row");
                __builder2.AddAttribute(95, "style", "margin-left:auto;margin-right:auto;margin-top:37px");
                __builder2.OpenElement(96, "div");
                __builder2.AddAttribute(97, "class", "col-md-6");
                __builder2.OpenComponent<Radzen.Blazor.RadzenButton>(98);
                __builder2.AddAttribute(99, "Text", "OK");
                __builder2.AddAttribute(100, "ButtonStyle", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#nullable restore
#line 36 "C:\Users\HoangLong\Documents\GitHub\ThucTapTask\TASK.WebApp\Pages\QuanLyCongViec\DoiCongViec.razor"
                                                         ButtonStyle.Secondary

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(101, "Icon", "save");
                __builder2.AddAttribute(102, "Style", "float:right");
                __builder2.AddAttribute(103, "ButtonType", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonType>(
#nullable restore
#line 36 "C:\Users\HoangLong\Documents\GitHub\ThucTapTask\TASK.WebApp\Pages\QuanLyCongViec\DoiCongViec.razor"
                                                                                                                            ButtonType.Submit

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(104, "\r\n                ");
                __builder2.OpenElement(105, "div");
                __builder2.AddAttribute(106, "class", "col-md-6");
                __builder2.OpenComponent<Radzen.Blazor.RadzenButton>(107);
                __builder2.AddAttribute(108, "Text", "Hủy bỏ");
                __builder2.AddAttribute(109, "ButtonStyle", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#nullable restore
#line 39 "C:\Users\HoangLong\Documents\GitHub\ThucTapTask\TASK.WebApp\Pages\QuanLyCongViec\DoiCongViec.razor"
                                                             ButtonStyle.Secondary

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(110, "Click", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 39 "C:\Users\HoangLong\Documents\GitHub\ThucTapTask\TASK.WebApp\Pages\QuanLyCongViec\DoiCongViec.razor"
                                                                                             args=>dialogService.Close(true)

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(111, "Style", "float: left ");
                __builder2.AddAttribute(112, "Icon", "cancel");
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
namespace __Blazor.TASK.WebApp.Pages.QuanLyCongViec.DoiCongViec
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateRadzenDropDown_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Boolean __arg0, int __seq1, global::System.Collections.IEnumerable __arg1, int __seq2, global::System.String __arg2, int __seq3, global::System.Boolean __arg3, int __seq4, global::System.String __arg4, int __seq5, global::System.String __arg5, int __seq6, global::System.String __arg6, int __seq7, global::System.String __arg7, int __seq8, global::Microsoft.AspNetCore.Components.EventCallback<global::System.Object> __arg8, int __seq9, global::System.Object __arg9, int __seq10, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg10, int __seq11, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg11)
        {
        __builder.OpenComponent<global::Radzen.Blazor.RadzenDropDown<TValue>>(seq);
        __builder.AddAttribute(__seq0, "AllowClear", __arg0);
        __builder.AddAttribute(__seq1, "Data", __arg1);
        __builder.AddAttribute(__seq2, "Style", __arg2);
        __builder.AddAttribute(__seq3, "AllowFiltering", __arg3);
        __builder.AddAttribute(__seq4, "Placeholder", __arg4);
        __builder.AddAttribute(__seq5, "Name", __arg5);
        __builder.AddAttribute(__seq6, "TextProperty", __arg6);
        __builder.AddAttribute(__seq7, "ValueProperty", __arg7);
        __builder.AddAttribute(__seq8, "Change", __arg8);
        __builder.AddAttribute(__seq9, "Value", __arg9);
        __builder.AddAttribute(__seq10, "ValueChanged", __arg10);
        __builder.AddAttribute(__seq11, "ValueExpression", __arg11);
        __builder.CloseComponent();
        }
        public static void CreateRadzenDropDown_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Boolean __arg0, int __seq1, global::System.Collections.IEnumerable __arg1, int __seq2, global::System.String __arg2, int __seq3, global::System.Boolean __arg3, int __seq4, global::System.String __arg4, int __seq5, global::System.String __arg5, int __seq6, global::System.String __arg6, int __seq7, global::System.String __arg7, int __seq8, global::System.Object __arg8, int __seq9, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg9, int __seq10, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg10)
        {
        __builder.OpenComponent<global::Radzen.Blazor.RadzenDropDown<TValue>>(seq);
        __builder.AddAttribute(__seq0, "AllowClear", __arg0);
        __builder.AddAttribute(__seq1, "Data", __arg1);
        __builder.AddAttribute(__seq2, "Style", __arg2);
        __builder.AddAttribute(__seq3, "AllowFiltering", __arg3);
        __builder.AddAttribute(__seq4, "Placeholder", __arg4);
        __builder.AddAttribute(__seq5, "Name", __arg5);
        __builder.AddAttribute(__seq6, "TextProperty", __arg6);
        __builder.AddAttribute(__seq7, "ValueProperty", __arg7);
        __builder.AddAttribute(__seq8, "Value", __arg8);
        __builder.AddAttribute(__seq9, "ValueChanged", __arg9);
        __builder.AddAttribute(__seq10, "ValueExpression", __arg10);
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
        public static void CreateRadzenDatePicker_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, global::System.String __arg1, int __seq2, global::System.String __arg2, int __seq3, global::System.Object __arg3, int __seq4, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg4, int __seq5, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg5)
        {
        __builder.OpenComponent<global::Radzen.Blazor.RadzenDatePicker<TValue>>(seq);
        __builder.AddAttribute(__seq0, "DateFormat", __arg0);
        __builder.AddAttribute(__seq1, "Name", __arg1);
        __builder.AddAttribute(__seq2, "Style", __arg2);
        __builder.AddAttribute(__seq3, "Value", __arg3);
        __builder.AddAttribute(__seq4, "ValueChanged", __arg4);
        __builder.AddAttribute(__seq5, "ValueExpression", __arg5);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
