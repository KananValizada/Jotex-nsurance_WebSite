#pragma checksum "C:\Users\Administrator\Desktop\AspFinalProject_JotexLive_CodeAcademy\AspFinalProject_JotexLive_CodeAcademy\Views\Shared\Components\Services\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7e225c313c20bf33c3aab756e2d91c9757968d22"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Services_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Services/Default.cshtml")]
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
#line 1 "C:\Users\Administrator\Desktop\AspFinalProject_JotexLive_CodeAcademy\AspFinalProject_JotexLive_CodeAcademy\Views\_ViewImports.cshtml"
using AspFinalProject_JotexLive_CodeAcademy;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Administrator\Desktop\AspFinalProject_JotexLive_CodeAcademy\AspFinalProject_JotexLive_CodeAcademy\Views\_ViewImports.cshtml"
using AspFinalProject_JotexLive_CodeAcademy.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Administrator\Desktop\AspFinalProject_JotexLive_CodeAcademy\AspFinalProject_JotexLive_CodeAcademy\Views\_ViewImports.cshtml"
using Repository.Services;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7e225c313c20bf33c3aab756e2d91c9757968d22", @"/Views/Shared/Components/Services/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5e9b60d80c3fe471e0bfed5cca7697660907ca3f", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Services_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<BestServicesViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Administrator\Desktop\AspFinalProject_JotexLive_CodeAcademy\AspFinalProject_JotexLive_CodeAcademy\Views\Shared\Components\Services\Default.cshtml"
   var a = 0;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Administrator\Desktop\AspFinalProject_JotexLive_CodeAcademy\AspFinalProject_JotexLive_CodeAcademy\Views\Shared\Components\Services\Default.cshtml"
   var b = 0;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Administrator\Desktop\AspFinalProject_JotexLive_CodeAcademy\AspFinalProject_JotexLive_CodeAcademy\Views\Shared\Components\Services\Default.cshtml"
   var toogle = "in active";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<section class=""service-single-section section-padding"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col col-xs-12"">
                <div class=""service-single-tab"">
                    <ul class=""nav tab-links clearfix"">
");
#nullable restore
#line 14 "C:\Users\Administrator\Desktop\AspFinalProject_JotexLive_CodeAcademy\AspFinalProject_JotexLive_CodeAcademy\Views\Shared\Components\Services\Default.cshtml"
                         foreach (var item in Model)
                        {

                            var id = "0";
                            a++;
                            id += a;
                            if (a == 1)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <li class=\"active\">\r\n                                    <a");
            BeginWriteAttribute("href", " href=\"", 780, "\"", 791, 2);
            WriteAttributeValue("", 787, "#", 787, 1, true);
#nullable restore
#line 23 "C:\Users\Administrator\Desktop\AspFinalProject_JotexLive_CodeAcademy\AspFinalProject_JotexLive_CodeAcademy\Views\Shared\Components\Services\Default.cshtml"
WriteAttributeValue("", 788, id, 788, 3, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" data-toggle=\"tab\">\r\n                                        <i");
            BeginWriteAttribute("class", " class=\"", 855, "\"", 873, 1);
#nullable restore
#line 24 "C:\Users\Administrator\Desktop\AspFinalProject_JotexLive_CodeAcademy\AspFinalProject_JotexLive_CodeAcademy\Views\Shared\Components\Services\Default.cshtml"
WriteAttributeValue("", 863, item.Logo, 863, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></i>\r\n                                        <h3>");
#nullable restore
#line 25 "C:\Users\Administrator\Desktop\AspFinalProject_JotexLive_CodeAcademy\AspFinalProject_JotexLive_CodeAcademy\Views\Shared\Components\Services\Default.cshtml"
                                       Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                                    </a>\r\n                                </li>\r\n");
#nullable restore
#line 28 "C:\Users\Administrator\Desktop\AspFinalProject_JotexLive_CodeAcademy\AspFinalProject_JotexLive_CodeAcademy\Views\Shared\Components\Services\Default.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <li>\r\n                                    <a");
            BeginWriteAttribute("href", " href=\"", 1195, "\"", 1206, 2);
            WriteAttributeValue("", 1202, "#", 1202, 1, true);
#nullable restore
#line 32 "C:\Users\Administrator\Desktop\AspFinalProject_JotexLive_CodeAcademy\AspFinalProject_JotexLive_CodeAcademy\Views\Shared\Components\Services\Default.cshtml"
WriteAttributeValue("", 1203, id, 1203, 3, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" data-toggle=\"tab\">\r\n                                        <i");
            BeginWriteAttribute("class", " class=\"", 1270, "\"", 1288, 1);
#nullable restore
#line 33 "C:\Users\Administrator\Desktop\AspFinalProject_JotexLive_CodeAcademy\AspFinalProject_JotexLive_CodeAcademy\Views\Shared\Components\Services\Default.cshtml"
WriteAttributeValue("", 1278, item.Logo, 1278, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></i>\r\n                                        <h3>");
#nullable restore
#line 34 "C:\Users\Administrator\Desktop\AspFinalProject_JotexLive_CodeAcademy\AspFinalProject_JotexLive_CodeAcademy\Views\Shared\Components\Services\Default.cshtml"
                                       Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                                    </a>\r\n                                </li>\r\n");
#nullable restore
#line 37 "C:\Users\Administrator\Desktop\AspFinalProject_JotexLive_CodeAcademy\AspFinalProject_JotexLive_CodeAcademy\Views\Shared\Components\Services\Default.cshtml"
                            }

                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </ul>\r\n\r\n                    <div class=\"tab-content\">\r\n");
#nullable restore
#line 43 "C:\Users\Administrator\Desktop\AspFinalProject_JotexLive_CodeAcademy\AspFinalProject_JotexLive_CodeAcademy\Views\Shared\Components\Services\Default.cshtml"
                         foreach (var item in Model)
                        {
                            var id = "0";
                            b++;
                            id += b;
                            if (b > 1)
                            {
                                toogle = "";
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div");
            BeginWriteAttribute("class", " class=\"", 1950, "\"", 1979, 3);
            WriteAttributeValue("", 1958, "tab-pane", 1958, 8, true);
            WriteAttributeValue(" ", 1966, "fade", 1967, 5, true);
#nullable restore
#line 52 "C:\Users\Administrator\Desktop\AspFinalProject_JotexLive_CodeAcademy\AspFinalProject_JotexLive_CodeAcademy\Views\Shared\Components\Services\Default.cshtml"
WriteAttributeValue(" ", 1971, toogle, 1972, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("id", " id=\"", 1980, "\"", 1988, 1);
#nullable restore
#line 52 "C:\Users\Administrator\Desktop\AspFinalProject_JotexLive_CodeAcademy\AspFinalProject_JotexLive_CodeAcademy\Views\Shared\Components\Services\Default.cshtml"
WriteAttributeValue("", 1985, id, 1985, 3, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                <div class=\"content-area clearfix\">\r\n                                    <div class=\"grid info-grid\">\r\n                                        <h3>");
#nullable restore
#line 55 "C:\Users\Administrator\Desktop\AspFinalProject_JotexLive_CodeAcademy\AspFinalProject_JotexLive_CodeAcademy\Views\Shared\Components\Services\Default.cshtml"
                                       Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                                        <p> ");
#nullable restore
#line 56 "C:\Users\Administrator\Desktop\AspFinalProject_JotexLive_CodeAcademy\AspFinalProject_JotexLive_CodeAcademy\Views\Shared\Components\Services\Default.cshtml"
                                       Write(item.Text);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                        <p><strong>");
#nullable restore
#line 57 "C:\Users\Administrator\Desktop\AspFinalProject_JotexLive_CodeAcademy\AspFinalProject_JotexLive_CodeAcademy\Views\Shared\Components\Services\Default.cshtml"
                                              Write(item.Slogan);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong></p>\r\n                                        <table>\r\n                                            <tbody>\r\n");
#nullable restore
#line 60 "C:\Users\Administrator\Desktop\AspFinalProject_JotexLive_CodeAcademy\AspFinalProject_JotexLive_CodeAcademy\Views\Shared\Components\Services\Default.cshtml"
                                                 foreach (var spec in item.ServiceSpecs)
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <tr>\r\n                                                        <td>");
#nullable restore
#line 63 "C:\Users\Administrator\Desktop\AspFinalProject_JotexLive_CodeAcademy\AspFinalProject_JotexLive_CodeAcademy\Views\Shared\Components\Services\Default.cshtml"
                                                       Write(spec.Key);

#line default
#line hidden
#nullable disable
            WriteLiteral(":</td>\r\n                                                        <td>");
#nullable restore
#line 64 "C:\Users\Administrator\Desktop\AspFinalProject_JotexLive_CodeAcademy\AspFinalProject_JotexLive_CodeAcademy\Views\Shared\Components\Services\Default.cshtml"
                                                       Write(spec.Value);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                    </tr>\r\n");
#nullable restore
#line 66 "C:\Users\Administrator\Desktop\AspFinalProject_JotexLive_CodeAcademy\AspFinalProject_JotexLive_CodeAcademy\Views\Shared\Components\Services\Default.cshtml"
                                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            </tbody>\r\n                                        </table>\r\n                                    </div>\r\n                                    <div class=\"grid\">\r\n                                        <img");
            BeginWriteAttribute("src", " src=\"", 3142, "\"", 3188, 1);
#nullable restore
#line 72 "C:\Users\Administrator\Desktop\AspFinalProject_JotexLive_CodeAcademy\AspFinalProject_JotexLive_CodeAcademy\Views\Shared\Components\Services\Default.cshtml"
WriteAttributeValue("", 3148, _cloudinaryService.BuildUrl(item.Image), 3148, 40, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 3189, "\"", 3195, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    </div>\r\n                                </div>\r\n                                <div class=\"bottom-info\">\r\n                                    <div class=\"text\">\r\n                                        <h4>");
#nullable restore
#line 77 "C:\Users\Administrator\Desktop\AspFinalProject_JotexLive_CodeAcademy\AspFinalProject_JotexLive_CodeAcademy\Views\Shared\Components\Services\Default.cshtml"
                                       Write(item.Slogan);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                                        <p>");
#nullable restore
#line 78 "C:\Users\Administrator\Desktop\AspFinalProject_JotexLive_CodeAcademy\AspFinalProject_JotexLive_CodeAcademy\Views\Shared\Components\Services\Default.cshtml"
                                      Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                                    </div>
                                    <div class=""pdf-dwn-area"">
                                        <a href=""#"">
                                            <i class=""ti-receipt""></i>
                                            <h5>General Insurance Conditions</h5>
                                            <p>Document size: 34kb</p>
                                        </a>
                                    </div>
                                </div>
                                <div class=""features-grid clearfix"">
");
#nullable restore
#line 89 "C:\Users\Administrator\Desktop\AspFinalProject_JotexLive_CodeAcademy\AspFinalProject_JotexLive_CodeAcademy\Views\Shared\Components\Services\Default.cshtml"
                                     foreach (var feature in item.ServiceFeatures)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <div class=\"grid\">\r\n                                            <div class=\"icon\">\r\n                                                <i");
            BeginWriteAttribute("class", " class=\"", 4413, "\"", 4434, 1);
#nullable restore
#line 93 "C:\Users\Administrator\Desktop\AspFinalProject_JotexLive_CodeAcademy\AspFinalProject_JotexLive_CodeAcademy\Views\Shared\Components\Services\Default.cshtml"
WriteAttributeValue("", 4421, feature.Logo, 4421, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></i>\r\n                                            </div>\r\n                                            <h3>");
#nullable restore
#line 95 "C:\Users\Administrator\Desktop\AspFinalProject_JotexLive_CodeAcademy\AspFinalProject_JotexLive_CodeAcademy\Views\Shared\Components\Services\Default.cshtml"
                                           Write(feature.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                                            <p>");
#nullable restore
#line 96 "C:\Users\Administrator\Desktop\AspFinalProject_JotexLive_CodeAcademy\AspFinalProject_JotexLive_CodeAcademy\Views\Shared\Components\Services\Default.cshtml"
                                          Write(feature.Text);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                        </div>\r\n");
#nullable restore
#line 98 "C:\Users\Administrator\Desktop\AspFinalProject_JotexLive_CodeAcademy\AspFinalProject_JotexLive_CodeAcademy\Views\Shared\Components\Services\Default.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                                </div>\r\n                            </div>\r\n");
#nullable restore
#line 103 "C:\Users\Administrator\Desktop\AspFinalProject_JotexLive_CodeAcademy\AspFinalProject_JotexLive_CodeAcademy\Views\Shared\Components\Services\Default.cshtml"


                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div> <!-- end container -->\r\n</section>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public ICloudinaryService _cloudinaryService { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<BestServicesViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
