#pragma checksum "/media/whuanle/Dowork/文章/龙芯支持/WebSystemInfo/BlazorWeb/Pages/FetchData.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7bd2f78e08cd171d2193ee3481b42574e4108f9d"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorWeb.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/media/whuanle/Dowork/文章/龙芯支持/WebSystemInfo/BlazorWeb/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/media/whuanle/Dowork/文章/龙芯支持/WebSystemInfo/BlazorWeb/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/media/whuanle/Dowork/文章/龙芯支持/WebSystemInfo/BlazorWeb/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/media/whuanle/Dowork/文章/龙芯支持/WebSystemInfo/BlazorWeb/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/media/whuanle/Dowork/文章/龙芯支持/WebSystemInfo/BlazorWeb/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/media/whuanle/Dowork/文章/龙芯支持/WebSystemInfo/BlazorWeb/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/media/whuanle/Dowork/文章/龙芯支持/WebSystemInfo/BlazorWeb/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/media/whuanle/Dowork/文章/龙芯支持/WebSystemInfo/BlazorWeb/_Imports.razor"
using BlazorWeb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/media/whuanle/Dowork/文章/龙芯支持/WebSystemInfo/BlazorWeb/_Imports.razor"
using BlazorWeb.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/media/whuanle/Dowork/文章/龙芯支持/WebSystemInfo/BlazorWeb/_Imports.razor"
using CZGL.SystemInfo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "/media/whuanle/Dowork/文章/龙芯支持/WebSystemInfo/BlazorWeb/_Imports.razor"
using CZGL.SystemInfo.Linux;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "/media/whuanle/Dowork/文章/龙芯支持/WebSystemInfo/BlazorWeb/_Imports.razor"
using CZGL.SystemInfo.Info;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/media/whuanle/Dowork/文章/龙芯支持/WebSystemInfo/BlazorWeb/Pages/FetchData.razor"
using BlazorWeb.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/fetchdata")]
    public partial class FetchData : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Weather forecast</h1>\r\n\r\n");
            __builder.AddMarkupContent(1, "<p>This component demonstrates fetching data from a service.</p>\r\n\r\n");
#nullable restore
#line 10 "/media/whuanle/Dowork/文章/龙芯支持/WebSystemInfo/BlazorWeb/Pages/FetchData.razor"
 if (forecasts == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(2, "    ");
            __builder.AddMarkupContent(3, "<p><em>Loading...</em></p>\r\n");
#nullable restore
#line 13 "/media/whuanle/Dowork/文章/龙芯支持/WebSystemInfo/BlazorWeb/Pages/FetchData.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(4, "    ");
            __builder.OpenElement(5, "table");
            __builder.AddAttribute(6, "class", "table");
            __builder.AddMarkupContent(7, "\r\n        ");
            __builder.AddMarkupContent(8, "<thead>\r\n            <tr>\r\n                <th>Date</th>\r\n                <th>Temp. (C)</th>\r\n                <th>Temp. (F)</th>\r\n                <th>Summary</th>\r\n            </tr>\r\n        </thead>\r\n        ");
            __builder.OpenElement(9, "tbody");
            __builder.AddMarkupContent(10, "\r\n");
#nullable restore
#line 26 "/media/whuanle/Dowork/文章/龙芯支持/WebSystemInfo/BlazorWeb/Pages/FetchData.razor"
             foreach (var forecast in forecasts)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(11, "                ");
            __builder.OpenElement(12, "tr");
            __builder.AddMarkupContent(13, "\r\n                    ");
            __builder.OpenElement(14, "td");
            __builder.AddContent(15, 
#nullable restore
#line 29 "/media/whuanle/Dowork/文章/龙芯支持/WebSystemInfo/BlazorWeb/Pages/FetchData.razor"
                         forecast.Date.ToShortDateString()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n                    ");
            __builder.OpenElement(17, "td");
            __builder.AddContent(18, 
#nullable restore
#line 30 "/media/whuanle/Dowork/文章/龙芯支持/WebSystemInfo/BlazorWeb/Pages/FetchData.razor"
                         forecast.TemperatureC

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n                    ");
            __builder.OpenElement(20, "td");
            __builder.AddContent(21, 
#nullable restore
#line 31 "/media/whuanle/Dowork/文章/龙芯支持/WebSystemInfo/BlazorWeb/Pages/FetchData.razor"
                         forecast.TemperatureF

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n                    ");
            __builder.OpenElement(23, "td");
            __builder.AddContent(24, 
#nullable restore
#line 32 "/media/whuanle/Dowork/文章/龙芯支持/WebSystemInfo/BlazorWeb/Pages/FetchData.razor"
                         forecast.Summary

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n");
#nullable restore
#line 34 "/media/whuanle/Dowork/文章/龙芯支持/WebSystemInfo/BlazorWeb/Pages/FetchData.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(27, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n");
#nullable restore
#line 37 "/media/whuanle/Dowork/文章/龙芯支持/WebSystemInfo/BlazorWeb/Pages/FetchData.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 39 "/media/whuanle/Dowork/文章/龙芯支持/WebSystemInfo/BlazorWeb/Pages/FetchData.razor"
       
    WeatherForecast[] forecasts;

    protected override async Task OnInitializedAsync()
    {
        forecasts = await ForecastService.GetForecastAsync(DateTime.Now);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private WeatherForecastService ForecastService { get; set; }
    }
}
#pragma warning restore 1591
