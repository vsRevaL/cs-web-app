#pragma checksum "D:\ELTE\MyGitHub\cs-web-app\DesignTest\DesignTest\Views\Identity\Register.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "56dbda01850712d09fbae50cce64a351a12703d1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Identity_Register), @"mvc.1.0.view", @"/Views/Identity/Register.cshtml")]
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
#line 2 "D:\ELTE\MyGitHub\cs-web-app\DesignTest\DesignTest\Views\_ViewImports.cshtml"
using DesignTest.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"56dbda01850712d09fbae50cce64a351a12703d1", @"/Views/Identity/Register.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eefecfcb5ae2618646b8334c7588e815a0f74c67", @"/Views/_ViewImports.cshtml")]
    public class Views_Identity_Register : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Useer>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<!-- about breadcrumb -->
<section class=""w3l-about-breadcrumb text-left"">
    <div class=""breadcrumb-bg breadcrumb-bg-about py-sm-5 py-4"">
        <div class=""container py-2"">
            <h2 class=""title"">Registration</h2>
        </div>
    </div>
</section>

<!-- //about breadcrumb -->
<!-- contact-form -->
<section class=""w3l-contact"" id=""contact"">
    <div class=""contact-infubd py-5"">
        <div class=""container py-lg-3"">
            <div class=""contact-grids row"">
                <div class=""col-lg-6 contact-left"">
                    <div class=""partners"">
                        <div class=""cont-details"">
                            <h5>Get in touch</h5>
                            <p class=""mt-3 mb-4"">
                                Hi there, We are available 24/7 by fax, e-mail or by phone. Drop us line so we can talk
                                futher about that.
                            </p>
                        </div>
                        <div class=""hours");
            WriteLiteral(@""">
                            <h6 class=""mt-4"">Email:</h6>
                            <p>
                                <a href=""mailto:mail@traversal.com"">
                                    mail@traversal.com
                                </a>
                            </p>
                            <h6 class=""mt-4"">Visit Us:</h6>
                            <p> 78-80 Upper St Giles St. Norwich NR2 1LT United Kingdom.</p>
                            <h6 class=""mt-4"">Contact:</h6>
                            <p class=""margin-top""><a href=""tel:+44-255-366-88"">+44-255-366-88</a></p>
                        </div>
                    </div>
                </div>
                <div class=""col-lg-6 mt-lg-0 mt-5 contact-right"">

");
#nullable restore
#line 42 "D:\ELTE\MyGitHub\cs-web-app\DesignTest\DesignTest\Views\Identity\Register.cshtml"
                     using (Html.BeginForm("Register", "Identity", FormMethod.Post, new { @class = "signin-form" }))
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"input-grids\">\r\n                            <div class=\"form-group\">\r\n                                ");
#nullable restore
#line 46 "D:\ELTE\MyGitHub\cs-web-app\DesignTest\DesignTest\Views\Identity\Register.cshtml"
                           Write(Html.TextBoxFor(m => m.Username, new
                                   {
                                       @type = "text",
                                       @placeholder = "Your Username*",
                                       @class = "contact-input",

                                   }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                ");
#nullable restore
#line 53 "D:\ELTE\MyGitHub\cs-web-app\DesignTest\DesignTest\Views\Identity\Register.cshtml"
                           Write(Html.ValidationMessageFor(m => m.Username, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </div>\r\n                            <div class=\"form-group\">\r\n                                ");
#nullable restore
#line 56 "D:\ELTE\MyGitHub\cs-web-app\DesignTest\DesignTest\Views\Identity\Register.cshtml"
                           Write(Html.TextBoxFor(m => m.Email, new
                                   {
                                       @type = "email",
                                       @placeholder = "Your Email*",
                                       @class = "contact-input",

                                   }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                ");
#nullable restore
#line 63 "D:\ELTE\MyGitHub\cs-web-app\DesignTest\DesignTest\Views\Identity\Register.cshtml"
                           Write(Html.ValidationMessageFor(m => m.Email, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </div>\r\n                            <div class=\"form-group\">\r\n                                ");
#nullable restore
#line 66 "D:\ELTE\MyGitHub\cs-web-app\DesignTest\DesignTest\Views\Identity\Register.cshtml"
                           Write(Html.TextBoxFor(m => m.Password, new
                                   {
                                       @type = "password",
                                       @placeholder = "Your Password*",
                                       @class = "contact-input",

                                   }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                ");
#nullable restore
#line 73 "D:\ELTE\MyGitHub\cs-web-app\DesignTest\DesignTest\Views\Identity\Register.cshtml"
                           Write(Html.ValidationMessageFor(m => m.Password, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </div>\r\n                            <div class=\"form-group\">\r\n                                ");
#nullable restore
#line 76 "D:\ELTE\MyGitHub\cs-web-app\DesignTest\DesignTest\Views\Identity\Register.cshtml"
                           Write(Html.TextBoxFor(m => m.ConfirmPassword, new
                                   {
                                       @type = "password",
                                       @placeholder = "Your Password Again*",
                                       @class = "contact-input",

                                   }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                ");
#nullable restore
#line 83 "D:\ELTE\MyGitHub\cs-web-app\DesignTest\DesignTest\Views\Identity\Register.cshtml"
                           Write(Html.ValidationMessageFor(m => m.ConfirmPassword, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </div>\r\n                            <div class=\"form-group\">\r\n                                ");
#nullable restore
#line 86 "D:\ELTE\MyGitHub\cs-web-app\DesignTest\DesignTest\Views\Identity\Register.cshtml"
                           Write(Html.TextBoxFor(m => m.Name, new
                                   {
                                       @type = "text",
                                       @placeholder = "Your Name*",
                                       @class = "contact-input",

                                   }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                ");
#nullable restore
#line 93 "D:\ELTE\MyGitHub\cs-web-app\DesignTest\DesignTest\Views\Identity\Register.cshtml"
                           Write(Html.ValidationMessageFor(m => m.Name, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </div>\r\n                            <div class=\"form-group\">\r\n                                ");
#nullable restore
#line 96 "D:\ELTE\MyGitHub\cs-web-app\DesignTest\DesignTest\Views\Identity\Register.cshtml"
                           Write(Html.TextBoxFor(m => m.Address, new
                                   {
                                       @type = "text",
                                       @placeholder = "Your Address*",
                                       @class = "contact-input",

                                   }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                ");
#nullable restore
#line 103 "D:\ELTE\MyGitHub\cs-web-app\DesignTest\DesignTest\Views\Identity\Register.cshtml"
                           Write(Html.ValidationMessageFor(m => m.Address, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </div>\r\n                            <div class=\"form-group\">\r\n                                ");
#nullable restore
#line 106 "D:\ELTE\MyGitHub\cs-web-app\DesignTest\DesignTest\Views\Identity\Register.cshtml"
                           Write(Html.TextBoxFor(m => m.Phone, new
                                   {
                                       @type = "text",
                                       @placeholder = "Your Phone Number*",
                                       @class = "contact-input",

                                   }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                ");
#nullable restore
#line 113 "D:\ELTE\MyGitHub\cs-web-app\DesignTest\DesignTest\Views\Identity\Register.cshtml"
                           Write(Html.ValidationMessageFor(m => m.Phone, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n");
            WriteLiteral(@"                        <div class=""text-right"">
                            <button type=""submit"" class=""btn btn-style btn-primary"">Registrate</button>
                            <button type=""reset"" class=""btn btn-style btn-primary"">Reset</button>
                        </div>
");
#nullable restore
#line 121 "D:\ELTE\MyGitHub\cs-web-app\DesignTest\DesignTest\Views\Identity\Register.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                </div>

            </div>
            <div class=""map mt-5 pt-md-5"">
                <h5>Map</h5>
                <iframe src=""https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d1389063.6425128083!2d18.383948747856092!3d47.157562075521845!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x4741837bdf37e4c3%3A0xc4290c1e1010!2sMagyarorsz%C3%A1g!5e0!3m2!1shu!2shu!4v1635424892687!5m2!1shu!2shu""
                        style=""border:0""");
            BeginWriteAttribute("allowfullscreen", " allowfullscreen=\"", 6638, "\"", 6656, 0);
            EndWriteAttribute();
            WriteLiteral("></iframe>\r\n            </div>\r\n        </div>\r\n</section>\r\n<!-- /contact-form -->\r\n");
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