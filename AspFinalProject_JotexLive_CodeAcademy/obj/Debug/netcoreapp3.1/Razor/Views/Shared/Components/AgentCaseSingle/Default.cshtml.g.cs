#pragma checksum "C:\Users\Administrator\Desktop\AspFinalProject_JotexLive_CodeAcademy\AspFinalProject_JotexLive_CodeAcademy\Views\Shared\Components\AgentCaseSingle\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4ec1eda5caa5dd272ceb01e76e8cfd6a354dceed"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_AgentCaseSingle_Default), @"mvc.1.0.view", @"/Views/Shared/Components/AgentCaseSingle/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4ec1eda5caa5dd272ceb01e76e8cfd6a354dceed", @"/Views/Shared/Components/AgentCaseSingle/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8cdf00ea3aab2732c387c7b9e129c9e6bb2cfdff", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_AgentCaseSingle_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<BestServicesViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Administrator\Desktop\AspFinalProject_JotexLive_CodeAcademy\AspFinalProject_JotexLive_CodeAcademy\Views\Shared\Components\AgentCaseSingle\Default.cshtml"
 foreach (var item in Model)
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Administrator\Desktop\AspFinalProject_JotexLive_CodeAcademy\AspFinalProject_JotexLive_CodeAcademy\Views\Shared\Components\AgentCaseSingle\Default.cshtml"
     foreach (var agent in item.Agents)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"grid\">\r\n            <div class=\"img-holder\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "4ec1eda5caa5dd272ceb01e76e8cfd6a354dceed4512", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 218, "~/images/case-studies/", 218, 22, true);
#nullable restore
#line 9 "C:\Users\Administrator\Desktop\AspFinalProject_JotexLive_CodeAcademy\AspFinalProject_JotexLive_CodeAcademy\Views\Shared\Components\AgentCaseSingle\Default.cshtml"
AddHtmlAttributeValue("", 240, agent.Image, 240, 12, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n            <div class=\"overlay\">\r\n                <div class=\"content\">\r\n                    <p class=\"cat\">Sığorta</p>\r\n                    <h3><a href=\"#\">");
#nullable restore
#line 14 "C:\Users\Administrator\Desktop\AspFinalProject_JotexLive_CodeAcademy\AspFinalProject_JotexLive_CodeAcademy\Views\Shared\Components\AgentCaseSingle\Default.cshtml"
                               Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h3>\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 18 "C:\Users\Administrator\Desktop\AspFinalProject_JotexLive_CodeAcademy\AspFinalProject_JotexLive_CodeAcademy\Views\Shared\Components\AgentCaseSingle\Default.cshtml"
        break;
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\Administrator\Desktop\AspFinalProject_JotexLive_CodeAcademy\AspFinalProject_JotexLive_CodeAcademy\Views\Shared\Components\AgentCaseSingle\Default.cshtml"
     

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<BestServicesViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
