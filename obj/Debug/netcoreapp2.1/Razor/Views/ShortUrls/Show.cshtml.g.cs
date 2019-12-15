#pragma checksum "D:\SH\URL shortening\Views\ShortUrls\Show.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bfbfca568c52d35b9f02ab27696dbda1538897c7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ShortUrls_Show), @"mvc.1.0.view", @"/Views/ShortUrls/Show.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/ShortUrls/Show.cshtml", typeof(AspNetCore.Views_ShortUrls_Show))]
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
#line 1 "D:\SH\URL shortening\Views\_ViewImports.cshtml"
using UrlShortener;

#line default
#line hidden
#line 2 "D:\SH\URL shortening\Views\_ViewImports.cshtml"
using UrlShortener.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bfbfca568c52d35b9f02ab27696dbda1538897c7", @"/Views/ShortUrls/Show.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d8a27d981f102097d420cd8e66221d8a5c51ac96", @"/Views/_ViewImports.cshtml")]
    public class Views_ShortUrls_Show : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ShortUrl>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "ShortUrls", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "RedirectTo", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\SH\URL shortening\Views\ShortUrls\Show.cshtml"
  
    ViewData["Title"] = "Details of a short URL";

#line default
#line hidden
            BeginContext(71, 172, true);
            WriteLiteral("\n<br />\n\n<div class=\"jumbotron\">\n    <ul>\n        <li>\n            <span class=\"col-md-2\">\n                <strong>Original URL:</strong>\n            </span>\n            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 243, "\"", 268, 1);
#line 14 "D:\SH\URL shortening\Views\ShortUrls\Show.cshtml"
WriteAttributeValue("", 250, Model.OriginalUrl, 250, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(269, 18, true);
            WriteLiteral(">\n                ");
            EndContext();
            BeginContext(288, 17, false);
#line 15 "D:\SH\URL shortening\Views\ShortUrls\Show.cshtml"
           Write(Model.OriginalUrl);

#line default
#line hidden
            EndContext();
            BeginContext(305, 157, true);
            WriteLiteral("\n            </a>\n        </li>\n        <li>\n            <span class=\"col-md-2\">\n                <strong>Short URL:</strong>\n            </span>\n            ");
            EndContext();
            BeginContext(462, 231, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b1e015b42ccd4f5d93c2899438658a34", async() => {
                BeginContext(551, 2, true);
                WriteLiteral("\r\n");
                EndContext();
                BeginContext(635, 23, true);
                WriteLiteral("                http://");
                EndContext();
                BeginContext(659, 16, false);
#line 24 "D:\SH\URL shortening\Views\ShortUrls\Show.cshtml"
                  Write(ViewData["Path"]);

#line default
#line hidden
                EndContext();
                BeginContext(675, 14, true);
                WriteLiteral("\r\n            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-path", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 22 "D:\SH\URL shortening\Views\ShortUrls\Show.cshtml"
                                                                      WriteLiteral(ViewData["Path"]);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["path"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-path", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["path"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(693, 32, true);
            WriteLiteral("\n        </li>\n    </ul>\n</div>\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ShortUrl> Html { get; private set; }
    }
}
#pragma warning restore 1591
