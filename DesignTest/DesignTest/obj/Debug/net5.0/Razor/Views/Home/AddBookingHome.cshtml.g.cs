#pragma checksum "D:\ELTE\MyGitHub\cs-web-app\DesignTest\DesignTest\Views\Home\AddBookingHome.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e6b2e92e94af9ec21ddfd8b4fbe6acf791980caf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_AddBookingHome), @"mvc.1.0.view", @"/Views/Home/AddBookingHome.cshtml")]
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
#line 1 "D:\ELTE\MyGitHub\cs-web-app\DesignTest\DesignTest\Views\Home\AddBookingHome.cshtml"
using DesignTest.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e6b2e92e94af9ec21ddfd8b4fbe6acf791980caf", @"/Views/Home/AddBookingHome.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eefecfcb5ae2618646b8334c7588e815a0f74c67", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_AddBookingHome : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Useer>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\ELTE\MyGitHub\cs-web-app\DesignTest\DesignTest\Views\Home\AddBookingHome.cshtml"
  
    Route selectedRoute = ViewBag.SelectedRoute;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<section class=""w3l-about-breadcrumb text-left"">
    <div class=""breadcrumb-bg breadcrumb-bg-about py-sm-5 py-4"">
        <div class=""container py-2"">
            <h2 class=""title"">Helyfoglalás</h2>
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
                                Kérlek töltsd ki az összes mezőt az űrlapon.
                            </p>
                        </div>
                        <div class=""hours"">
                            <h6 class=""mt-4"">Kiindulási hely:</h6>
                            <p>");
#nullable restore
#line 29 "D:\ELTE\MyGitHub\cs-web-app\DesignTest\DesignTest\Views\Home\AddBookingHome.cshtml"
                          Write(selectedRoute.FromCity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n                            <h6 class=\"mt-4\">Érkezési hely:</h6>\r\n                            <p>");
#nullable restore
#line 32 "D:\ELTE\MyGitHub\cs-web-app\DesignTest\DesignTest\Views\Home\AddBookingHome.cshtml"
                          Write(selectedRoute.ToCity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n                            <h6 class=\"mt-4\">Távolság (KM):</h6>\r\n                            <p>");
#nullable restore
#line 35 "D:\ELTE\MyGitHub\cs-web-app\DesignTest\DesignTest\Views\Home\AddBookingHome.cshtml"
                          Write(selectedRoute.Km);

#line default
#line hidden
#nullable disable
            WriteLiteral(" KM</p>\r\n\r\n                            <h6 class=\"mt-4\">Indulási időpont,</h6>\r\n                            <p>");
#nullable restore
#line 38 "D:\ELTE\MyGitHub\cs-web-app\DesignTest\DesignTest\Views\Home\AddBookingHome.cshtml"
                          Write(selectedRoute.When);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n                            <h6 class=\"mt-4\">Összes ülőhely / Foglalt helyek / Szabad helyek</h6>\r\n                            <p>");
#nullable restore
#line 41 "D:\ELTE\MyGitHub\cs-web-app\DesignTest\DesignTest\Views\Home\AddBookingHome.cshtml"
                          Write(selectedRoute.Seats);

#line default
#line hidden
#nullable disable
            WriteLiteral(" / ");
#nullable restore
#line 41 "D:\ELTE\MyGitHub\cs-web-app\DesignTest\DesignTest\Views\Home\AddBookingHome.cshtml"
                                                 Write(selectedRoute.Bookings.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral(" / ");
#nullable restore
#line 41 "D:\ELTE\MyGitHub\cs-web-app\DesignTest\DesignTest\Views\Home\AddBookingHome.cshtml"
                                                                                  Write(selectedRoute.Seats-selectedRoute.Bookings.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n                <div class=\"col-lg-6 mt-lg-0 mt-5 contact-right\">\r\n\r\n");
#nullable restore
#line 47 "D:\ELTE\MyGitHub\cs-web-app\DesignTest\DesignTest\Views\Home\AddBookingHome.cshtml"
                     using (Html.BeginForm("AddBookingHome", "Home", FormMethod.Post, new { @class = "signin-form" }))
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"input-grids\">\r\n\r\n                            <div class=\"form-group\">\r\n                                ");
#nullable restore
#line 52 "D:\ELTE\MyGitHub\cs-web-app\DesignTest\DesignTest\Views\Home\AddBookingHome.cshtml"
                           Write(Html.TextBoxFor(m => m.Id, new
                                   {
                                       @type = "text",
                                       @placeholder = "",
                                       @class = "contact-input",
                                       @style = "display: none"

                                   }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </div>\r\n                            <div class=\"form-group\">\r\n                                ");
#nullable restore
#line 62 "D:\ELTE\MyGitHub\cs-web-app\DesignTest\DesignTest\Views\Home\AddBookingHome.cshtml"
                           Write(Html.TextBoxFor(m => m.Username, new
                                   {
                                       @type = "text",
                                       @placeholder = "",
                                       @class = "contact-input",
                                       @style = "display: none"

                                   }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </div>\r\n                            <div class=\"form-group\">\r\n                                ");
#nullable restore
#line 72 "D:\ELTE\MyGitHub\cs-web-app\DesignTest\DesignTest\Views\Home\AddBookingHome.cshtml"
                           Write(Html.TextBoxFor(m => m.Password, new
                                   {
                                       @type = "text",
                                       @placeholder = "",
                                       @class = "contact-input",
                                       @style = "display: none"

                                   }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </div>\r\n\r\n                            <div class=\"form-group\">\r\n                                ");
#nullable restore
#line 83 "D:\ELTE\MyGitHub\cs-web-app\DesignTest\DesignTest\Views\Home\AddBookingHome.cshtml"
                           Write(Html.TextBoxFor(m => m.Name, new
                                   {
                                       @type = "text",
                                       @placeholder = "Neved*",
                                       @class = "contact-input",

                                   }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                ");
#nullable restore
#line 90 "D:\ELTE\MyGitHub\cs-web-app\DesignTest\DesignTest\Views\Home\AddBookingHome.cshtml"
                           Write(Html.ValidationMessageFor(m => m.Name, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </div>\r\n                            <div class=\"form-group\">\r\n                                ");
#nullable restore
#line 93 "D:\ELTE\MyGitHub\cs-web-app\DesignTest\DesignTest\Views\Home\AddBookingHome.cshtml"
                           Write(Html.TextBoxFor(m => m.Address, new
                                   {
                                       @type = "text",
                                       @placeholder = "Címed (Irányítószám): ",
                                       @class = "contact-input",

                                   }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                ");
#nullable restore
#line 100 "D:\ELTE\MyGitHub\cs-web-app\DesignTest\DesignTest\Views\Home\AddBookingHome.cshtml"
                           Write(Html.ValidationMessageFor(m => m.Address, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </div>\r\n                            <div class=\"form-group\">\r\n                                ");
#nullable restore
#line 103 "D:\ELTE\MyGitHub\cs-web-app\DesignTest\DesignTest\Views\Home\AddBookingHome.cshtml"
                           Write(Html.TextBoxFor(m => m.Email, new
                                   {
                                       @type = "email",
                                       @placeholder = "Email címed*",
                                       @class = "contact-input",

                                   }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                ");
#nullable restore
#line 110 "D:\ELTE\MyGitHub\cs-web-app\DesignTest\DesignTest\Views\Home\AddBookingHome.cshtml"
                           Write(Html.ValidationMessageFor(m => m.Email, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </div>\r\n                            <div class=\"form-group\">\r\n                                ");
#nullable restore
#line 113 "D:\ELTE\MyGitHub\cs-web-app\DesignTest\DesignTest\Views\Home\AddBookingHome.cshtml"
                           Write(Html.TextBoxFor(m => m.Phone, new
                                   {
                                       @type = "text",
                                       @placeholder = "Telefonszámod*",
                                       @class = "contact-input",

                                   }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                ");
#nullable restore
#line 120 "D:\ELTE\MyGitHub\cs-web-app\DesignTest\DesignTest\Views\Home\AddBookingHome.cshtml"
                           Write(Html.ValidationMessageFor(m => m.Phone, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n");
            WriteLiteral("                        <div class=\"text-right\">\r\n                            <button type=\"submit\" class=\"btn btn-style btn-primary\">Jóváhagyás</button>\r\n                            ");
#nullable restore
#line 126 "D:\ELTE\MyGitHub\cs-web-app\DesignTest\DesignTest\Views\Home\AddBookingHome.cshtml"
                       Write(Html.ActionLink("Visszalép", "Index", "Home", new { @class = "btn btn-style btn-primary" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n");
#nullable restore
#line 128 "D:\ELTE\MyGitHub\cs-web-app\DesignTest\DesignTest\Views\Home\AddBookingHome.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Useer> Html { get; private set; }
    }
}
#pragma warning restore 1591
