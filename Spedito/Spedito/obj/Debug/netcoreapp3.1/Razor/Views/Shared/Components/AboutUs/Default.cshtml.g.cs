#pragma checksum "C:\Users\SOFT\Desktop\Spedito\Spedito\Spedito\Views\Shared\Components\AboutUs\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a0a45d12ae31992a01e6a2f1eb5b5771bdc5ba55"
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
#line 1 "C:\Users\SOFT\Desktop\Spedito\Spedito\Spedito\Views\_ViewImports.cshtml"
using Spedito;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\SOFT\Desktop\Spedito\Spedito\Spedito\Views\_ViewImports.cshtml"
using Spedito.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\SOFT\Desktop\Spedito\Spedito\Spedito\Views\_ViewImports.cshtml"
using Spedito.Models.Account;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a0a45d12ae31992a01e6a2f1eb5b5771bdc5ba55", @"/Views/Shared/Components/AboutUs/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5f92e776abf991ef83d5f030b63dabd3c9a83a1e", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_AboutUs_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<AboutUsViewModel>>
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
            WriteLiteral("\r\n<div class=\"uk-grid uk-child-width-1-2@m uk-flex-middle\" data-uk-grid>\r\n");
#nullable restore
#line 4 "C:\Users\SOFT\Desktop\Spedito\Spedito\Spedito\Views\Shared\Components\AboutUs\Default.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"uk-text-center\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "a0a45d12ae31992a01e6a2f1eb5b5771bdc5ba554090", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 213, "~/uploads/", 213, 10, true);
#nullable restore
#line 7 "C:\Users\SOFT\Desktop\Spedito\Spedito\Spedito\Views\Shared\Components\AboutUs\Default.cshtml"
AddHtmlAttributeValue("", 223, item.Image, 223, 11, false);

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
            WriteLiteral("\r\n        </div>\r\n        <div>\r\n            <div class=\"section-title burger wave\">\r\n                <h3 class=\"uk-h3\">");
#nullable restore
#line 11 "C:\Users\SOFT\Desktop\Spedito\Spedito\Spedito\Views\Shared\Components\AboutUs\Default.cshtml"
                             Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n            </div>\r\n            <div class=\"section-content\">\r\n                <p>");
#nullable restore
#line 14 "C:\Users\SOFT\Desktop\Spedito\Spedito\Spedito\Views\Shared\Components\AboutUs\Default.cshtml"
              Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <div class=\"uk-margin-medium-top\">\r\n                    <a class=\"uk-button\"");
            BeginWriteAttribute("href", " href=\"", 578, "\"", 599, 1);
#nullable restore
#line 16 "C:\Users\SOFT\Desktop\Spedito\Spedito\Spedito\Views\Shared\Components\AboutUs\Default.cshtml"
WriteAttributeValue("", 585, item.EndPoint, 585, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                        <span>");
#nullable restore
#line 17 "C:\Users\SOFT\Desktop\Spedito\Spedito\Spedito\Views\Shared\Components\AboutUs\Default.cshtml"
                         Write(item.ActionText);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                    </a></div>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 21 "C:\Users\SOFT\Desktop\Spedito\Spedito\Spedito\Views\Shared\Components\AboutUs\Default.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>");
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
