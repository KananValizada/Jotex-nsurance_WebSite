#pragma checksum "C:\Users\Administrator\Desktop\AspFinalProject_JotexLive_CodeAcademy\AspFinalProject_JotexLive_CodeAcademy\Views\Shared\Components\Fag\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6ae392d73a208e4fd7e67b9501112c92fb6ad08e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Fag_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Fag/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6ae392d73a208e4fd7e67b9501112c92fb6ad08e", @"/Views/Shared/Components/Fag/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8cdf00ea3aab2732c387c7b9e129c9e6bb2cfdff", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Fag_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<FagViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Administrator\Desktop\AspFinalProject_JotexLive_CodeAcademy\AspFinalProject_JotexLive_CodeAcademy\Views\Shared\Components\Fag\Default.cshtml"
  var a = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"row\">\r\n    <div class=\"col col-xs-12\">\r\n        <div class=\"panel-group faq-accordion theme-accordion-s1\" id=\"accordion\">\r\n");
#nullable restore
#line 6 "C:\Users\Administrator\Desktop\AspFinalProject_JotexLive_CodeAcademy\AspFinalProject_JotexLive_CodeAcademy\Views\Shared\Components\Fag\Default.cshtml"
             foreach (var item in Model)
            {
                a++;

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"panel panel-default\">\r\n                    <div class=\"panel-heading\">\r\n                        <a data-toggle=\"collapse\" data-parent=\"#accordion\"");
            BeginWriteAttribute("href", " href=\"", 437, "\"", 456, 2);
            WriteAttributeValue("", 444, "#collapse-", 444, 10, true);
#nullable restore
#line 11 "C:\Users\Administrator\Desktop\AspFinalProject_JotexLive_CodeAcademy\AspFinalProject_JotexLive_CodeAcademy\Views\Shared\Components\Fag\Default.cshtml"
WriteAttributeValue("", 454, a, 454, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" aria-expanded=\"false\">");
#nullable restore
#line 11 "C:\Users\Administrator\Desktop\AspFinalProject_JotexLive_CodeAcademy\AspFinalProject_JotexLive_CodeAcademy\Views\Shared\Components\Fag\Default.cshtml"
                                                                                                                Write(item.Question);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                    </div>\r\n                    <div");
            BeginWriteAttribute("id", " id=\"", 552, "\"", 568, 2);
            WriteAttributeValue("", 557, "collapse-", 557, 9, true);
#nullable restore
#line 13 "C:\Users\Administrator\Desktop\AspFinalProject_JotexLive_CodeAcademy\AspFinalProject_JotexLive_CodeAcademy\Views\Shared\Components\Fag\Default.cshtml"
WriteAttributeValue("", 566, a, 566, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"panel-collapse collapse\">\r\n                        <div class=\"panel-body\">\r\n                            <p>");
#nullable restore
#line 15 "C:\Users\Administrator\Desktop\AspFinalProject_JotexLive_CodeAcademy\AspFinalProject_JotexLive_CodeAcademy\Views\Shared\Components\Fag\Default.cshtml"
                          Write(item.Answer);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 19 "C:\Users\Administrator\Desktop\AspFinalProject_JotexLive_CodeAcademy\AspFinalProject_JotexLive_CodeAcademy\Views\Shared\Components\Fag\Default.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<FagViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591