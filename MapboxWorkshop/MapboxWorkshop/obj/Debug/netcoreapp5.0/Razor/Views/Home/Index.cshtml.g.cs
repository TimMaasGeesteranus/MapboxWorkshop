#pragma checksum "C:\Users\Tim Maas Gesteranus\Desktop\MapboxWorkshop\MapboxWorkshop\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f4d6789eda47dbb2a42a053f35a204bbecf91af4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\Tim Maas Gesteranus\Desktop\MapboxWorkshop\MapboxWorkshop\Views\_ViewImports.cshtml"
using MapboxWorkshop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Tim Maas Gesteranus\Desktop\MapboxWorkshop\MapboxWorkshop\Views\_ViewImports.cshtml"
using MapboxWorkshop.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f4d6789eda47dbb2a42a053f35a204bbecf91af4", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fd26b69b6816246cc125501cf4e259f046461b94", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Tim Maas Gesteranus\Desktop\MapboxWorkshop\MapboxWorkshop\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""text-center"">
    <h1 class=""display-4"">hallo!</h1>
    <p>Learn about <a href=""https://docs.microsoft.com/aspnet/core"">building Web apps with ASP.NET Core</a>.</p>
</div>

<script src='https://api.mapbox.com/mapbox.js/v3.3.1/mapbox.js'></script>
<link href='https://api.mapbox.com/mapbox.js/v3.3.1/mapbox.css' rel='stylesheet' />

<div id='map'></div>

<style>
    #map {
        position: absolute;
        width: 80%;
        height: 50%;
    }

    .marker {
        background-image: url('https://www.quantmania.nl/wp-content/uploads/2018/02/map-marker-icon-300x300.png');
        background-size: cover;
        width: 50px;
        height: 50px;
        border-radius: 50%;
        cursor: pointer;
    }
</style>

<script>
    L.mapbox.accessToken = 'pk.eyJ1IjoidGltMzYzIiwiYSI6ImNrOW1yYjN6ajA3enUza3MwMmJwbTk0MGYifQ.Lk-6Gc9r6Cjg-heLLQoVIA';
    var map = L.mapbox.map('map')
        .setView([51.983047, 5.903408], 12)
        .addLayer(L.mapbox.styleLayer('mapbox://sty");
            WriteLiteral("les/mapbox/streets-v11\'));\r\n\r\n    var marker = L.divIcon({\r\n        className: \'marker\',\r\n        iconSize: [60, 60]\r\n    });\r\n\r\n    L.marker([51.988769, 5.949507], { icon: marker }).addTo(map);\r\n</script>\r\n\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591