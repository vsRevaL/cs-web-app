#pragma checksum "D:\ELTE\MyGitHub\cs-web-app\DesignTest\DesignTest\Views\Admin\EditRoute.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ea6ba8e4900d99eb88e6228a9b579d1da3f38114"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_EditRoute), @"mvc.1.0.view", @"/Views/Admin/EditRoute.cshtml")]
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
#line 1 "D:\ELTE\MyGitHub\cs-web-app\DesignTest\DesignTest\Views\_ViewImports.cshtml"
using DesignTest;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\ELTE\MyGitHub\cs-web-app\DesignTest\DesignTest\Views\Admin\EditRoute.cshtml"
using DesignTest.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ea6ba8e4900d99eb88e6228a9b579d1da3f38114", @"/Views/Admin/EditRoute.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eefecfcb5ae2618646b8334c7588e815a0f74c67", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_EditRoute : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Route>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\ELTE\MyGitHub\cs-web-app\DesignTest\DesignTest\Views\Admin\EditRoute.cshtml"
  
    Route selectedRoute = ViewBag.SelectedRoute;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<section class=""w3l-about-breadcrumb text-left"">
    <div class=""breadcrumb-bg breadcrumb-bg-about py-sm-5 py-4"">
        <div class=""container py-2"">
            <h2 class=""title"">Út módosítása</h2>
        </div>
    </div>
</section>

<section class=""w3l-contact"" id=""contact"">
    <div class=""contact-infubd py-5"">
        <div class=""container py-lg-3"">
            <div class=""contact-grids row"">
                <div class=""col-lg-6 contact-left"">
                    <div class=""partners"">
                        <div class=""cont-details"">
                            <h5>A kiválasztott utad:</h5>
                            <p class=""mt-3 mb-4"">
                                Az itteni űrlapon módosíthatod a kiválaszott út adatait.
                            </p>
                        </div>
                        <div class=""hours"">
                            <h6 class=""mt-4"">Kiindulási hely:</h6>
                            <p>");
#nullable restore
#line 29 "D:\ELTE\MyGitHub\cs-web-app\DesignTest\DesignTest\Views\Admin\EditRoute.cshtml"
                          Write(selectedRoute.FromCity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n                            <h6 class=\"mt-4\">Érkezési hely:</h6>\r\n                            <p>");
#nullable restore
#line 32 "D:\ELTE\MyGitHub\cs-web-app\DesignTest\DesignTest\Views\Admin\EditRoute.cshtml"
                          Write(selectedRoute.ToCity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n                            <h6 class=\"mt-4\">Távolság (KM):</h6>\r\n                            <p>");
#nullable restore
#line 35 "D:\ELTE\MyGitHub\cs-web-app\DesignTest\DesignTest\Views\Admin\EditRoute.cshtml"
                          Write(selectedRoute.Km);

#line default
#line hidden
#nullable disable
            WriteLiteral(" KM</p>\r\n\r\n                            <h6 class=\"mt-4\">Indulási időpont,</h6>\r\n                            <p>");
#nullable restore
#line 38 "D:\ELTE\MyGitHub\cs-web-app\DesignTest\DesignTest\Views\Admin\EditRoute.cshtml"
                          Write(selectedRoute.When);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n                            <h6 class=\"mt-4\">Összes ülőhely / Foglalt helyek / Szabad helyek</h6>\r\n                            <p>");
#nullable restore
#line 41 "D:\ELTE\MyGitHub\cs-web-app\DesignTest\DesignTest\Views\Admin\EditRoute.cshtml"
                          Write(selectedRoute.Seats);

#line default
#line hidden
#nullable disable
            WriteLiteral(" / ");
#nullable restore
#line 41 "D:\ELTE\MyGitHub\cs-web-app\DesignTest\DesignTest\Views\Admin\EditRoute.cshtml"
                                                 Write(selectedRoute.Bookings.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral(" / ");
#nullable restore
#line 41 "D:\ELTE\MyGitHub\cs-web-app\DesignTest\DesignTest\Views\Admin\EditRoute.cshtml"
                                                                                  Write(selectedRoute.Seats-selectedRoute.Bookings.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n                <div class=\"col-lg-6 mt-lg-0 mt-5 contact-right\">\r\n\r\n");
#nullable restore
#line 47 "D:\ELTE\MyGitHub\cs-web-app\DesignTest\DesignTest\Views\Admin\EditRoute.cshtml"
                     using (Html.BeginForm("EditRoute", "Admin", FormMethod.Post, new { @class = "signin-form" }))
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"input-grids\">\r\n\r\n                            <div class=\"form-group\">\r\n                                ");
#nullable restore
#line 52 "D:\ELTE\MyGitHub\cs-web-app\DesignTest\DesignTest\Views\Admin\EditRoute.cshtml"
                           Write(Html.TextBoxFor(m => m.Id, new
                           {
                               @type = "text",
                               @class = "contact-input",
                               @style = "display: none"

                           }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </div>\r\n\r\n                            <div class=\"form-group\">\r\n                                ");
#nullable restore
#line 62 "D:\ELTE\MyGitHub\cs-web-app\DesignTest\DesignTest\Views\Admin\EditRoute.cshtml"
                           Write(Html.TextBoxFor(m => m.FromCity, new
                                   {
                                       @type = "text",
                                       @placeholder = "Honnan*",
                                       @class = "contact-input",
                                   }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                ");
#nullable restore
#line 68 "D:\ELTE\MyGitHub\cs-web-app\DesignTest\DesignTest\Views\Admin\EditRoute.cshtml"
                           Write(Html.ValidationMessageFor(m => m.FromCity, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </div>\r\n                            <div class=\"form-group\">\r\n                                ");
#nullable restore
#line 71 "D:\ELTE\MyGitHub\cs-web-app\DesignTest\DesignTest\Views\Admin\EditRoute.cshtml"
                           Write(Html.TextBoxFor(m => m.ToCity, new
                                   {
                                       @type = "text",
                                       @placeholder = "Hova*",
                                       @class = "contact-input",
                                   }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                ");
#nullable restore
#line 77 "D:\ELTE\MyGitHub\cs-web-app\DesignTest\DesignTest\Views\Admin\EditRoute.cshtml"
                           Write(Html.ValidationMessageFor(m => m.ToCity, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </div>\r\n                            <div class=\"form-group\">\r\n                                ");
#nullable restore
#line 80 "D:\ELTE\MyGitHub\cs-web-app\DesignTest\DesignTest\Views\Admin\EditRoute.cshtml"
                           Write(Html.TextBoxFor(m => m.When, new
                                   {
                                       @type = "datetime-local",
                                       @placeholder = "Időpont*",
                                       @class = "contact-input",
                                   }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                ");
#nullable restore
#line 86 "D:\ELTE\MyGitHub\cs-web-app\DesignTest\DesignTest\Views\Admin\EditRoute.cshtml"
                           Write(Html.ValidationMessageFor(m => m.When, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </div>\r\n                            <div class=\"form-group\">\r\n                                ");
#nullable restore
#line 89 "D:\ELTE\MyGitHub\cs-web-app\DesignTest\DesignTest\Views\Admin\EditRoute.cshtml"
                           Write(Html.TextBoxFor(m => m.Km, new
                                   {
                                       @type = "number",
                                       @placeholder = "Távolság (KM)*",
                                       @class = "contact-input",
                                   }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                ");
#nullable restore
#line 95 "D:\ELTE\MyGitHub\cs-web-app\DesignTest\DesignTest\Views\Admin\EditRoute.cshtml"
                           Write(Html.ValidationMessageFor(m => m.Km, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </div>\r\n                            <div class=\"form-group\">\r\n                                ");
#nullable restore
#line 98 "D:\ELTE\MyGitHub\cs-web-app\DesignTest\DesignTest\Views\Admin\EditRoute.cshtml"
                           Write(Html.TextBoxFor(m => m.Seats, new
                                   {
                                       @type = "number",
                                       @placeholder = "Ülőhelyek száma*",
                                       @class = "contact-input",
                                   }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                ");
#nullable restore
#line 104 "D:\ELTE\MyGitHub\cs-web-app\DesignTest\DesignTest\Views\Admin\EditRoute.cshtml"
                           Write(Html.ValidationMessageFor(m => m.Seats, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n");
            WriteLiteral(@"                        <div class=""text-right"">
                            <button type=""submit"" class=""btn btn-style btn-primary"">Mentés</button>
                            <button type=""reset"" class=""btn btn-style btn-primary"">Alaphelyzet</button>
                        </div>
");
#nullable restore
#line 112 "D:\ELTE\MyGitHub\cs-web-app\DesignTest\DesignTest\Views\Admin\EditRoute.cshtml"

                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Route> Html { get; private set; }
    }
}
#pragma warning restore 1591