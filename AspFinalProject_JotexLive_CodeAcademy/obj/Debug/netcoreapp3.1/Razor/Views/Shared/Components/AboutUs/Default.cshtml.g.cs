#pragma checksum "C:\Users\Administrator\Desktop\AspFinalProject_JotexLive_CodeAcademy\AspFinalProject_JotexLive_CodeAcademy\Views\Shared\Components\AboutUs\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b04e272c1452d26f9243c067b90ffe7dca177131"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_AboutUs_Default), @"mvc.1.0.view", @"/Views/Shared/Components/AboutUs/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b04e272c1452d26f9243c067b90ffe7dca177131", @"/Views/Shared/Components/AboutUs/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5e9b60d80c3fe471e0bfed5cca7697660907ca3f", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_AboutUs_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<AboutUsViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Administrator\Desktop\AspFinalProject_JotexLive_CodeAcademy\AspFinalProject_JotexLive_CodeAcademy\Views\Shared\Components\AboutUs\Default.cshtml"
 foreach (var item in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"row\">\r\n        <div class=\"col col-md-3\">\r\n            <div class=\"section-title mt\">\r\n                <span>Haqqımızda</span>\r\n                <img");
            BeginWriteAttribute("src", " src=\"", 235, "\"", 267, 2);
            WriteAttributeValue("", 241, "images/", 241, 7, true);
#nullable restore
#line 8 "C:\Users\Administrator\Desktop\AspFinalProject_JotexLive_CodeAcademy\AspFinalProject_JotexLive_CodeAcademy\Views\Shared\Components\AboutUs\Default.cshtml"
WriteAttributeValue("", 248, item.Settings.Logo, 248, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 268, "\"", 274, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n            </div>\r\n            <div class=\"info\">\r\n                <h3>");
#nullable restore
#line 11 "C:\Users\Administrator\Desktop\AspFinalProject_JotexLive_CodeAcademy\AspFinalProject_JotexLive_CodeAcademy\Views\Shared\Components\AboutUs\Default.cshtml"
               Write(item.Settings.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                <h4>");
#nullable restore
#line 12 "C:\Users\Administrator\Desktop\AspFinalProject_JotexLive_CodeAcademy\AspFinalProject_JotexLive_CodeAcademy\Views\Shared\Components\AboutUs\Default.cshtml"
               Write(item.Settings.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                <a href=\"#\" class=\"theme-btn\">Haqqımızda daha ətraflı</a>\r\n            </div>\r\n        </div>\r\n        <div class=\"col col-md-5\">\r\n            <div class=\"details-text mt\">\r\n                <h4>");
#nullable restore
#line 18 "C:\Users\Administrator\Desktop\AspFinalProject_JotexLive_CodeAcademy\AspFinalProject_JotexLive_CodeAcademy\Views\Shared\Components\AboutUs\Default.cshtml"
               Write(item.SubTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                <p>");
#nullable restore
#line 19 "C:\Users\Administrator\Desktop\AspFinalProject_JotexLive_CodeAcademy\AspFinalProject_JotexLive_CodeAcademy\Views\Shared\Components\AboutUs\Default.cshtml"
              Write(item.About);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
            </div>
        </div>
        <div class=""col col-md-4"">
            <div class=""features-grid clearfix"">
                <div class=""grid"">
                    <div class=""icon"">
                        <i class=""fi flaticon-money-bag""></i>
                    </div>
                    <h3>Tələb et</h3>
                    <p>Ödənişi tələb edə bilərsən</p>
                </div>
                <div class=""grid"">
                    <div class=""icon"">
                        <i class=""fi flaticon-agent""></i>
                    </div>
                    <h3>Agent tap</h3>
                    <p>Agent axtarışındasan?</p>
                </div>
                <div class=""grid"">
                    <div class=""icon"">
                        <i class=""fi flaticon-cost""></i>
                    </div>
                    <h3>Premium ödə</h3>
                    <p>Elə indicə ödə</p>
                </div>
            </div>
        </div>
    </div>
");
#nullable restore
#line 48 "C:\Users\Administrator\Desktop\AspFinalProject_JotexLive_CodeAcademy\AspFinalProject_JotexLive_CodeAcademy\Views\Shared\Components\AboutUs\Default.cshtml"
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
