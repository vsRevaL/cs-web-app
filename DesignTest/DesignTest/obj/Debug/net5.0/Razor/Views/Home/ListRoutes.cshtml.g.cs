#pragma checksum "D:\ELTE\MyGitHub\cs-web-app\DesignTest\DesignTest\Views\Home\ListRoutes.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4fe59a81386ea12312c5c0fa086f1935832f00d4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ListRoutes), @"mvc.1.0.view", @"/Views/Home/ListRoutes.cshtml")]
namespace AspNetCore
{
    #line hidden
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\ELTE\MyGitHub\cs-web-app\DesignTest\DesignTest\Views\_ViewImports.cshtml"
using DesignTest;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\ELTE\MyGitHub\cs-web-app\DesignTest\DesignTest\Views\_ViewImports.cshtml"
using DesignTest.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\ELTE\MyGitHub\cs-web-app\DesignTest\DesignTest\Views\Home\ListRoutes.cshtml"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\ELTE\MyGitHub\cs-web-app\DesignTest\DesignTest\Views\Home\ListRoutes.cshtml"
using System;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\ELTE\MyGitHub\cs-web-app\DesignTest\DesignTest\Views\Home\ListRoutes.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\ELTE\MyGitHub\cs-web-app\DesignTest\DesignTest\Views\Home\ListRoutes.cshtml"
using System.Collections.Generic;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\ELTE\MyGitHub\cs-web-app\DesignTest\DesignTest\Views\Home\ListRoutes.cshtml"
using System.ComponentModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\ELTE\MyGitHub\cs-web-app\DesignTest\DesignTest\Views\Home\ListRoutes.cshtml"
using System.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\ELTE\MyGitHub\cs-web-app\DesignTest\DesignTest\Views\Home\ListRoutes.cshtml"
using System.Drawing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\ELTE\MyGitHub\cs-web-app\DesignTest\DesignTest\Views\Home\ListRoutes.cshtml"
using System.Linq;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\ELTE\MyGitHub\cs-web-app\DesignTest\DesignTest\Views\Home\ListRoutes.cshtml"
using System.Text;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\ELTE\MyGitHub\cs-web-app\DesignTest\DesignTest\Views\Home\ListRoutes.cshtml"
using System.Threading.Tasks;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\ELTE\MyGitHub\cs-web-app\DesignTest\DesignTest\Views\Home\ListRoutes.cshtml"
using System.Text.Json;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4fe59a81386ea12312c5c0fa086f1935832f00d4", @"/Views/Home/ListRoutes.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eefecfcb5ae2618646b8334c7588e815a0f74c67", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ListRoutes : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 12 "D:\ELTE\MyGitHub\cs-web-app\DesignTest\DesignTest\Views\Home\ListRoutes.cshtml"
  
    var filteredRoutes = Model;
    var x = Context.Session.GetString("LoggedIn");


#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<section class=""w3l-about-breadcrumb text-left"">
    <div class=""breadcrumb-bg breadcrumb-bg-about py-sm-5 py-4"">
        <div class=""container py-2"">
            <h2 class=""title"">Indulások</h2>
        </div>
    </div>
</section>

<style>
    #customers {
        font-family: Arial, Helvetica, sans-serif;
        border-collapse: collapse;
        width: 100%;
    }

        #customers td, #customers th {
            border: 1px solid #ddd;
            padding: 8px;
            text-align: center;
        }

        #customers tr:nth-child(even) {
            background-color: #f2f2f2;
        }

        #customers tr:hover {
            background-color: #ddd;
        }

        #customers th {
            padding-top: 12px;
            padding-bottom: 12px;
            text-align: left;
            background-color: #04AA6D;
            color: white;
            text-align: center;
        }
</style>

<section class=""w3l-contact"" id=""contact"">
    <div class=""con");
            WriteLiteral(@"tact-infubd py-5"">
        <div class=""container py-lg-3"">
            <div class=""contact-grids row"">

                <table id=""customers"" data-show-toggle=""false"" data-expand-first=""true"">
                    <tr>
                        <th style=""display:none;"">ID</th>
                        <th>Honnan</th>
                        <th>Hova</th>
                        <th>Távolság (Km)</th>
                        <th>Időpont</th>
                        <th>Helyek</th>
                        <th>Ár</th>
                        <th>Csatlakozás</th>
");
#nullable restore
#line 72 "D:\ELTE\MyGitHub\cs-web-app\DesignTest\DesignTest\Views\Home\ListRoutes.cshtml"
                         if (x == "admin")
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <th>Foglalás másnak</th>\r\n                            <th>Út Módosítása</th>\r\n");
#nullable restore
#line 76 "D:\ELTE\MyGitHub\cs-web-app\DesignTest\DesignTest\Views\Home\ListRoutes.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tr>\r\n");
#nullable restore
#line 78 "D:\ELTE\MyGitHub\cs-web-app\DesignTest\DesignTest\Views\Home\ListRoutes.cshtml"
                     foreach (Route item in filteredRoutes)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td style=\"display:none;\">");
#nullable restore
#line 81 "D:\ELTE\MyGitHub\cs-web-app\DesignTest\DesignTest\Views\Home\ListRoutes.cshtml"
                                         Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 82 "D:\ELTE\MyGitHub\cs-web-app\DesignTest\DesignTest\Views\Home\ListRoutes.cshtml"
                   Write(item.FromCity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 83 "D:\ELTE\MyGitHub\cs-web-app\DesignTest\DesignTest\Views\Home\ListRoutes.cshtml"
                   Write(item.ToCity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 84 "D:\ELTE\MyGitHub\cs-web-app\DesignTest\DesignTest\Views\Home\ListRoutes.cshtml"
                   Write(item.Km);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 85 "D:\ELTE\MyGitHub\cs-web-app\DesignTest\DesignTest\Views\Home\ListRoutes.cshtml"
                   Write(item.When);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 86 "D:\ELTE\MyGitHub\cs-web-app\DesignTest\DesignTest\Views\Home\ListRoutes.cshtml"
                   Write(item.Seats);

#line default
#line hidden
#nullable disable
            WriteLiteral(" / ");
#nullable restore
#line 86 "D:\ELTE\MyGitHub\cs-web-app\DesignTest\DesignTest\Views\Home\ListRoutes.cshtml"
                                 Write(item.Bookings.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 87 "D:\ELTE\MyGitHub\cs-web-app\DesignTest\DesignTest\Views\Home\ListRoutes.cshtml"
                    Write(@JsonData.CostKm * @item.Km);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 88 "D:\ELTE\MyGitHub\cs-web-app\DesignTest\DesignTest\Views\Home\ListRoutes.cshtml"
                     if (item.Seats == item.Bookings.Count)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td></td>\r\n");
#nullable restore
#line 91 "D:\ELTE\MyGitHub\cs-web-app\DesignTest\DesignTest\Views\Home\ListRoutes.cshtml"
                    }
                    else
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 94 "D:\ELTE\MyGitHub\cs-web-app\DesignTest\DesignTest\Views\Home\ListRoutes.cshtml"
                         if (x == null)
                        {


#line default
#line hidden
#nullable disable
            WriteLiteral("                            <td>");
#nullable restore
#line 97 "D:\ELTE\MyGitHub\cs-web-app\DesignTest\DesignTest\Views\Home\ListRoutes.cshtml"
                           Write(Html.ActionLink("Helyfoglalás", "AddBookingHome", "Home", new { @routeIdStr = item.Id.ToString() }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 98 "D:\ELTE\MyGitHub\cs-web-app\DesignTest\DesignTest\Views\Home\ListRoutes.cshtml"
                        }
                        else if (x != null && x == "admin")
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <td>");
#nullable restore
#line 101 "D:\ELTE\MyGitHub\cs-web-app\DesignTest\DesignTest\Views\Home\ListRoutes.cshtml"
                           Write(Html.ActionLink("Helyfoglalás", "AddBookingUser", "User", new { @routeIdStr = item.Id.ToString() }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 102 "D:\ELTE\MyGitHub\cs-web-app\DesignTest\DesignTest\Views\Home\ListRoutes.cshtml"
                           Write(Html.ActionLink("Foglalás másnak", "AddBookingHome", "Home", new { @routeIdStr = item.Id.ToString() }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 103 "D:\ELTE\MyGitHub\cs-web-app\DesignTest\DesignTest\Views\Home\ListRoutes.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <td>");
#nullable restore
#line 106 "D:\ELTE\MyGitHub\cs-web-app\DesignTest\DesignTest\Views\Home\ListRoutes.cshtml"
                           Write(Html.ActionLink("Helyfoglalás", "AddBookingUser", "User", new { @routeIdStr = item.Id.ToString() }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 107 "D:\ELTE\MyGitHub\cs-web-app\DesignTest\DesignTest\Views\Home\ListRoutes.cshtml"

                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 108 "D:\ELTE\MyGitHub\cs-web-app\DesignTest\DesignTest\Views\Home\ListRoutes.cshtml"
                         
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 110 "D:\ELTE\MyGitHub\cs-web-app\DesignTest\DesignTest\Views\Home\ListRoutes.cshtml"
                     if (x == "admin")
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td>");
#nullable restore
#line 112 "D:\ELTE\MyGitHub\cs-web-app\DesignTest\DesignTest\Views\Home\ListRoutes.cshtml"
                       Write(Html.ActionLink("Módosít", "EditRoute", "Admin", new { @routeIdStr = item.Id.ToString() }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 113 "D:\ELTE\MyGitHub\cs-web-app\DesignTest\DesignTest\Views\Home\ListRoutes.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tr>\r\n");
#nullable restore
#line 115 "D:\ELTE\MyGitHub\cs-web-app\DesignTest\DesignTest\Views\Home\ListRoutes.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                </table>\r\n\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>");
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