#pragma checksum "C:\Users\Administrator\Desktop\AspFinalProject_JotexLive_CodeAcademy\AspFinalProject_JotexLive_CodeAcademy\Views\CaseStudies\CaseSingle.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "741341e0b20a7ae6d55e81e2a080879f2e58f1a3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CaseStudies_CaseSingle), @"mvc.1.0.view", @"/Views/CaseStudies/CaseSingle.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"741341e0b20a7ae6d55e81e2a080879f2e58f1a3", @"/Views/CaseStudies/CaseSingle.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5e9b60d80c3fe471e0bfed5cca7697660907ca3f", @"/Views/_ViewImports.cshtml")]
    public class Views_CaseStudies_CaseSingle : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CaseStudyViewModel>
    {
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
        private global::AspNetCore.Views_CaseStudies_CaseSingle.__Generated__AgentCaseSingleViewComponentTagHelper __AgentCaseSingleViewComponentTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Administrator\Desktop\AspFinalProject_JotexLive_CodeAcademy\AspFinalProject_JotexLive_CodeAcademy\Views\CaseStudies\CaseSingle.cshtml"
  
    ViewData["Title"] = "CaseSingle";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!-- start page-title -->
<section class=""page-title"">
    <div class=""page-title-container"">
        <div class=""page-title-wrapper"">
            <div class=""container"">
                <div class=""row"">
                    <div class=""col col-xs-12"">
                        <h2>");
#nullable restore
#line 14 "C:\Users\Administrator\Desktop\AspFinalProject_JotexLive_CodeAcademy\AspFinalProject_JotexLive_CodeAcademy\Views\CaseStudies\CaseSingle.cshtml"
                       Write(Model.MainTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h2>
                        <ol class=""breadcrumb"">
                            <li><a href=""index.html"">Home</a></li>
                            <li>Nümunəvi araşdırmalar</li>
                        </ol>
                    </div>
                </div> <!-- end row -->
            </div> <!-- end container -->
        </div>
    </div>
</section>
<!-- end page-title -->
<!-- start project-single-section -->
<section class=""project-single-section section-padding"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col col-md-6"">
                <div class=""img-holder"">
                    <img");
            BeginWriteAttribute("src", " src=\"", 1077, "\"", 1124, 1);
#nullable restore
#line 32 "C:\Users\Administrator\Desktop\AspFinalProject_JotexLive_CodeAcademy\AspFinalProject_JotexLive_CodeAcademy\Views\CaseStudies\CaseSingle.cshtml"
WriteAttributeValue("", 1083, _cloudinaryService.BuildUrl(Model.Image), 1083, 41, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 1125, "\"", 1131, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                </div>\r\n            </div>\r\n            <div class=\"col col-md-6\">\r\n                <div class=\"project-details\">\r\n                    <h2>");
#nullable restore
#line 37 "C:\Users\Administrator\Desktop\AspFinalProject_JotexLive_CodeAcademy\AspFinalProject_JotexLive_CodeAcademy\Views\CaseStudies\CaseSingle.cshtml"
                   Write(Model.MainTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                    <h3>");
#nullable restore
#line 38 "C:\Users\Administrator\Desktop\AspFinalProject_JotexLive_CodeAcademy\AspFinalProject_JotexLive_CodeAcademy\Views\CaseStudies\CaseSingle.cshtml"
                   Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                    <p>");
#nullable restore
#line 39 "C:\Users\Administrator\Desktop\AspFinalProject_JotexLive_CodeAcademy\AspFinalProject_JotexLive_CodeAcademy\Views\CaseStudies\CaseSingle.cshtml"
                  Write(Model.Text);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <div class=\"project-info\">\r\n                        <ul class=\"clearfix\">\r\n");
#nullable restore
#line 42 "C:\Users\Administrator\Desktop\AspFinalProject_JotexLive_CodeAcademy\AspFinalProject_JotexLive_CodeAcademy\Views\CaseStudies\CaseSingle.cshtml"
                             foreach (var specs in Model.studySpecs)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <li><span>");
#nullable restore
#line 44 "C:\Users\Administrator\Desktop\AspFinalProject_JotexLive_CodeAcademy\AspFinalProject_JotexLive_CodeAcademy\Views\CaseStudies\CaseSingle.cshtml"
                                     Write(specs.Key);

#line default
#line hidden
#nullable disable
            WriteLiteral(":</span> ");
#nullable restore
#line 44 "C:\Users\Administrator\Desktop\AspFinalProject_JotexLive_CodeAcademy\AspFinalProject_JotexLive_CodeAcademy\Views\CaseStudies\CaseSingle.cshtml"
                                                        Write(specs.Value);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 45 "C:\Users\Administrator\Desktop\AspFinalProject_JotexLive_CodeAcademy\AspFinalProject_JotexLive_CodeAcademy\Views\CaseStudies\CaseSingle.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        </ul>
                    </div>
                </div>
            </div>
        </div>
        <div class=""row"">
            <div class=""col col-xs-12"">
                <div class=""project-single-tab clearfix"">
                    <ul class=""nav"">
                        <li>
                            <a href=""#precautions"" data-toggle=""tab"">Təcrübə</a>
                        </li>
                        <li>
                            <a href=""#intelligence"" data-toggle=""tab"">Həll Yolu</a>
                        </li>
                        <li>
                            <a href=""#specializations"" data-toggle=""tab"">Nəticə</a>
                        </li>
                    </ul>

                    <div class=""tab-content"">
                        <div class=""tab-pane fade"" id=""precautions"">
                            <p>");
#nullable restore
#line 68 "C:\Users\Administrator\Desktop\AspFinalProject_JotexLive_CodeAcademy\AspFinalProject_JotexLive_CodeAcademy\Views\CaseStudies\CaseSingle.cshtml"
                          Write(Model.ChallengeText);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        </div>\r\n                        <div class=\"tab-pane fade\" id=\"intelligence\">\r\n                            <p>");
#nullable restore
#line 71 "C:\Users\Administrator\Desktop\AspFinalProject_JotexLive_CodeAcademy\AspFinalProject_JotexLive_CodeAcademy\Views\CaseStudies\CaseSingle.cshtml"
                          Write(Model.SolutionText);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        </div>\r\n                        <div class=\"tab-pane fade\" id=\"specializations\">\r\n                            <p>");
#nullable restore
#line 74 "C:\Users\Administrator\Desktop\AspFinalProject_JotexLive_CodeAcademy\AspFinalProject_JotexLive_CodeAcademy\Views\CaseStudies\CaseSingle.cshtml"
                          Write(Model.ResultText);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                        </div>
                    </div>
                </div>
            </div>
        </div>

        <div class=""row"">
            <div class=""col col-xs-12"">
                <div class=""related-case-studies"">
                    <h2>Əlaqəli nümunəvi araşdırmalar</h2>
                    <div class=""case-studies-grids"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("vc:agent-case-single", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "741341e0b20a7ae6d55e81e2a080879f2e58f1a310832", async() => {
            }
            );
            __AgentCaseSingleViewComponentTagHelper = CreateTagHelper<global::AspNetCore.Views_CaseStudies_CaseSingle.__Generated__AgentCaseSingleViewComponentTagHelper>();
            __tagHelperExecutionContext.Add(__AgentCaseSingleViewComponentTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div> <!-- end container -->\r\n</section>\r\n<!-- end project-single-section -->");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CaseStudyViewModel> Html { get; private set; }
        [Microsoft.AspNetCore.Razor.TagHelpers.HtmlTargetElementAttribute("vc:agent-case-single")]
        public class __Generated__AgentCaseSingleViewComponentTagHelper : Microsoft.AspNetCore.Razor.TagHelpers.TagHelper
        {
            private readonly global::Microsoft.AspNetCore.Mvc.IViewComponentHelper __helper = null;
            public __Generated__AgentCaseSingleViewComponentTagHelper(global::Microsoft.AspNetCore.Mvc.IViewComponentHelper helper)
            {
                __helper = helper;
            }
            [Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeNotBoundAttribute, global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewContextAttribute]
            public global::Microsoft.AspNetCore.Mvc.Rendering.ViewContext ViewContext { get; set; }
            public override async global::System.Threading.Tasks.Task ProcessAsync(Microsoft.AspNetCore.Razor.TagHelpers.TagHelperContext __context, Microsoft.AspNetCore.Razor.TagHelpers.TagHelperOutput __output)
            {
                (__helper as global::Microsoft.AspNetCore.Mvc.ViewFeatures.IViewContextAware)?.Contextualize(ViewContext);
                var __helperContent = await __helper.InvokeAsync("AgentCaseSingle", new {  });
                __output.TagName = null;
                __output.Content.SetHtmlContent(__helperContent);
            }
        }
    }
}
#pragma warning restore 1591
