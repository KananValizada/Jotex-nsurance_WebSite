#pragma checksum "C:\Users\Administrator\Desktop\AspFinalProject_JotexLive_CodeAcademy\AspFinalProject_JotexLive_CodeAcademy\Views\Shared\Components\AboutUsHome\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e18737eb4eea8dbbbfc0f54dfb43e5e488a34129"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_AboutUsHome_Default), @"mvc.1.0.view", @"/Views/Shared/Components/AboutUsHome/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e18737eb4eea8dbbbfc0f54dfb43e5e488a34129", @"/Views/Shared/Components/AboutUsHome/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8cdf00ea3aab2732c387c7b9e129c9e6bb2cfdff", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_AboutUsHome_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<AboutUsViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Administrator\Desktop\AspFinalProject_JotexLive_CodeAcademy\AspFinalProject_JotexLive_CodeAcademy\Views\Shared\Components\AboutUsHome\Default.cshtml"
                 foreach (var item in Model)
                {
                    

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        <div class=""inner clearfix"">
                            <div class=""left-col"">
                                <div class=""section-title"">
                                    <span>Haqqımızda</span>
                                    <h2>");
#nullable restore
#line 10 "C:\Users\Administrator\Desktop\AspFinalProject_JotexLive_CodeAcademy\AspFinalProject_JotexLive_CodeAcademy\Views\Shared\Components\AboutUsHome\Default.cshtml"
                                   Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                                </div>\r\n                                <div class=\"details\">\r\n                                    <p>");
#nullable restore
#line 13 "C:\Users\Administrator\Desktop\AspFinalProject_JotexLive_CodeAcademy\AspFinalProject_JotexLive_CodeAcademy\Views\Shared\Components\AboutUsHome\Default.cshtml"
                                  Write(item.Text);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                    <h5>Phone:");
#nullable restore
#line 14 "C:\Users\Administrator\Desktop\AspFinalProject_JotexLive_CodeAcademy\AspFinalProject_JotexLive_CodeAcademy\Views\Shared\Components\AboutUsHome\Default.cshtml"
                                         Write(item.Settings.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                                </div>\r\n                            </div>\r\n                            <div class=\"right-col\">\r\n                                <div class=\"about-info\">\r\n                                    <h3>");
#nullable restore
#line 19 "C:\Users\Administrator\Desktop\AspFinalProject_JotexLive_CodeAcademy\AspFinalProject_JotexLive_CodeAcademy\Views\Shared\Components\AboutUsHome\Default.cshtml"
                                   Write(item.SubTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                                    <p>");
#nullable restore
#line 20 "C:\Users\Administrator\Desktop\AspFinalProject_JotexLive_CodeAcademy\AspFinalProject_JotexLive_CodeAcademy\Views\Shared\Components\AboutUsHome\Default.cshtml"
                                  Write(item.About);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                    <a href=\"#\" class=\"theme-btn\">Daha ətraflı</a>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n");
#nullable restore
#line 25 "C:\Users\Administrator\Desktop\AspFinalProject_JotexLive_CodeAcademy\AspFinalProject_JotexLive_CodeAcademy\Views\Shared\Components\AboutUsHome\Default.cshtml"

      
                }

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<AboutUsViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
