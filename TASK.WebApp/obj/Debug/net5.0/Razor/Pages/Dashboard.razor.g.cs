#pragma checksum "C:\Users\HoangLong\source\repos\TASK_PROJECT\TASK.WebApp\Pages\Dashboard.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0619028cf78ab0e16f00f240ed87812c966daaab"
// <auto-generated/>
#pragma warning disable 1591
namespace TASK.WebApp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\HoangLong\source\repos\TASK_PROJECT\TASK.WebApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\HoangLong\source\repos\TASK_PROJECT\TASK.WebApp\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\HoangLong\source\repos\TASK_PROJECT\TASK.WebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\HoangLong\source\repos\TASK_PROJECT\TASK.WebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\HoangLong\source\repos\TASK_PROJECT\TASK.WebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\HoangLong\source\repos\TASK_PROJECT\TASK.WebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\HoangLong\source\repos\TASK_PROJECT\TASK.WebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\HoangLong\source\repos\TASK_PROJECT\TASK.WebApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\HoangLong\source\repos\TASK_PROJECT\TASK.WebApp\_Imports.razor"
using TASK.WebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\HoangLong\source\repos\TASK_PROJECT\TASK.WebApp\_Imports.razor"
using TASK.WebApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\HoangLong\source\repos\TASK_PROJECT\TASK.WebApp\_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\HoangLong\source\repos\TASK_PROJECT\TASK.WebApp\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\HoangLong\source\repos\TASK_PROJECT\TASK.WebApp\Pages\Dashboard.razor"
using System.Globalization;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Dashboard")]
    public partial class Dashboard : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Trang Dashboard</h1>\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "container");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "row");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "col-sm-12 my-5");
            __builder.OpenComponent<Radzen.Blazor.RadzenChart>(7);
            __builder.AddAttribute(8, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __Blazor.TASK.WebApp.Pages.Dashboard.TypeInference.CreateRadzenColumnSeries_0(__builder2, 9, 10, 
#nullable restore
#line 10 "C:\Users\HoangLong\source\repos\TASK_PROJECT\TASK.WebApp\Pages\Dashboard.razor"
                                           revenue2020

#line default
#line hidden
#nullable disable
                , 11, "Quarter", 12, "2020", 13, 
#nullable restore
#line 10 "C:\Users\HoangLong\source\repos\TASK_PROJECT\TASK.WebApp\Pages\Dashboard.razor"
                                                                                                          LineType.Dashed

#line default
#line hidden
#nullable disable
                , 14, "Revenue");
                __builder2.AddMarkupContent(15, "\r\n                ");
                __Blazor.TASK.WebApp.Pages.Dashboard.TypeInference.CreateRadzenColumnSeries_1(__builder2, 16, 17, 
#nullable restore
#line 11 "C:\Users\HoangLong\source\repos\TASK_PROJECT\TASK.WebApp\Pages\Dashboard.razor"
                                           revenue2019

#line default
#line hidden
#nullable disable
                , 18, "Quarter", 19, "2019", 20, "Revenue");
                __builder2.AddMarkupContent(21, "\r\n                ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenColumnOptions>(22);
                __builder2.AddAttribute(23, "Radius", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#nullable restore
#line 12 "C:\Users\HoangLong\source\repos\TASK_PROJECT\TASK.WebApp\Pages\Dashboard.razor"
                                             5

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(24, "\r\n                ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenValueAxis>(25);
                __builder2.AddAttribute(26, "Formatter", (System.Func<System.Object, System.String>)(
#nullable restore
#line 13 "C:\Users\HoangLong\source\repos\TASK_PROJECT\TASK.WebApp\Pages\Dashboard.razor"
                                             FormatAsUSD

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(27, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridLines>(28);
                    __builder3.AddAttribute(29, "Visible", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 14 "C:\Users\HoangLong\source\repos\TASK_PROJECT\TASK.WebApp\Pages\Dashboard.razor"
                                              true

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(30, "\r\n                    ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenAxisTitle>(31);
                    __builder3.AddAttribute(32, "Text", "Revenue in USD");
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 23 "C:\Users\HoangLong\source\repos\TASK_PROJECT\TASK.WebApp\Pages\Dashboard.razor"
       
    class DataItem
    {
        public string Quarter { get; set; }
        public double Revenue { get; set; }
    }

    string FormatAsUSD(object value)
    {
        return ((double)value).ToString("C0", CultureInfo.CreateSpecificCulture("en-US"));
    }

    DataItem[] revenue2019 = new DataItem[] {
        new DataItem
        {
            Quarter = "Q1",
            Revenue = 234000
        },
        new DataItem
        {
            Quarter = "Q2",
            Revenue = 284000
        },
        new DataItem
        {
            Quarter = "Q3",
            Revenue = 274000
        },
        new DataItem
        {
            Quarter = "Q4",
            Revenue = 294000
        },
    };

    DataItem[] revenue2020 = new DataItem[] {
        new DataItem
        {
            Quarter = "Q1",
            Revenue = 254000
        },
        new DataItem
        {
            Quarter = "Q2",
            Revenue = 324000
        },
        new DataItem
        {
            Quarter = "Q3",
            Revenue = 354000
        },
        new DataItem
        {
            Quarter = "Q4",
            Revenue = 394000
        },

    };

#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.TASK.WebApp.Pages.Dashboard
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateRadzenColumnSeries_0<TItem>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.IEnumerable<TItem> __arg0, int __seq1, global::System.String __arg1, int __seq2, global::System.String __arg2, int __seq3, global::Radzen.Blazor.LineType __arg3, int __seq4, global::System.String __arg4)
        {
        __builder.OpenComponent<global::Radzen.Blazor.RadzenColumnSeries<TItem>>(seq);
        __builder.AddAttribute(__seq0, "Data", __arg0);
        __builder.AddAttribute(__seq1, "CategoryProperty", __arg1);
        __builder.AddAttribute(__seq2, "Title", __arg2);
        __builder.AddAttribute(__seq3, "LineType", __arg3);
        __builder.AddAttribute(__seq4, "ValueProperty", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateRadzenColumnSeries_1<TItem>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.IEnumerable<TItem> __arg0, int __seq1, global::System.String __arg1, int __seq2, global::System.String __arg2, int __seq3, global::System.String __arg3)
        {
        __builder.OpenComponent<global::Radzen.Blazor.RadzenColumnSeries<TItem>>(seq);
        __builder.AddAttribute(__seq0, "Data", __arg0);
        __builder.AddAttribute(__seq1, "CategoryProperty", __arg1);
        __builder.AddAttribute(__seq2, "Title", __arg2);
        __builder.AddAttribute(__seq3, "ValueProperty", __arg3);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
