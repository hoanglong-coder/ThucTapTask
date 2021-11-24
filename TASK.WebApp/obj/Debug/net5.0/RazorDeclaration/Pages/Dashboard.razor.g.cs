// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace TASK.WebApp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\ASC\BaiTapLon\TASK.WebApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\ASC\BaiTapLon\TASK.WebApp\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\ASC\BaiTapLon\TASK.WebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\ASC\BaiTapLon\TASK.WebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\ASC\BaiTapLon\TASK.WebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\ASC\BaiTapLon\TASK.WebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\ASC\BaiTapLon\TASK.WebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\ASC\BaiTapLon\TASK.WebApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\ASC\BaiTapLon\TASK.WebApp\_Imports.razor"
using TASK.WebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\ASC\BaiTapLon\TASK.WebApp\_Imports.razor"
using TASK.WebApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\ASC\BaiTapLon\TASK.WebApp\_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\ASC\BaiTapLon\TASK.WebApp\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\ASC\BaiTapLon\TASK.WebApp\Pages\Dashboard.razor"
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
        }
        #pragma warning restore 1998
#nullable restore
#line 23 "D:\ASC\BaiTapLon\TASK.WebApp\Pages\Dashboard.razor"
       
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
#pragma warning restore 1591
