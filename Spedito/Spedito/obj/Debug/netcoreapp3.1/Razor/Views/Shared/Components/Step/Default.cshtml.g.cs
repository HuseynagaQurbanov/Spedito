#pragma checksum "D:\Unity Projects\Turtle\Spedito\Spedito\Spedito\Views\Shared\Components\Step\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "67a0c0f020bd00f45ad10a018d554fb1518af195"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Step_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Step/Default.cshtml")]
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
#line 1 "D:\Unity Projects\Turtle\Spedito\Spedito\Spedito\Views\_ViewImports.cshtml"
using Spedito;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Unity Projects\Turtle\Spedito\Spedito\Spedito\Views\_ViewImports.cshtml"
using Spedito.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Unity Projects\Turtle\Spedito\Spedito\Spedito\Views\_ViewImports.cshtml"
using Spedito.Models.Account;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Unity Projects\Turtle\Spedito\Spedito\Spedito\Views\_ViewImports.cshtml"
using Spedito.Models.Catalog;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Unity Projects\Turtle\Spedito\Spedito\Spedito\Views\_ViewImports.cshtml"
using Spedito.Libs;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"67a0c0f020bd00f45ad10a018d554fb1518af195", @"/Views/Shared/Components/Step/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6683956ace1150be5761480987334349baab5d94", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Step_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<StepViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<ul class=\"uk-slider-items uk-grid uk-grid-medium uk-child-width-1-1 uk-child-width-1-2@s uk-child-width-1-3@m uk-child-width-1-3@l uk-child-width-1-4@xl\">\r\n");
#nullable restore
#line 4 "D:\Unity Projects\Turtle\Spedito\Spedito\Spedito\Views\Shared\Components\Step\Default.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li>\r\n            <div class=\"step-item step-item--1\">\r\n                <div class=\"step-item__icon\">\r\n                    <img");
            BeginWriteAttribute("src", " src=\"", 370, "\"", 396, 2);
            WriteAttributeValue("", 376, "/uploads/", 376, 9, true);
#nullable restore
#line 9 "D:\Unity Projects\Turtle\Spedito\Spedito\Spedito\Views\Shared\Components\Step\Default.cshtml"
WriteAttributeValue("", 385, item.Image, 385, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"img-step\">\r\n                </div>\r\n                <div class=\"step-item__numb\">Step ");
#nullable restore
#line 11 "D:\Unity Projects\Turtle\Spedito\Spedito\Spedito\Views\Shared\Components\Step\Default.cshtml"
                                             Write(item.Steps);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                <div class=\"step-item__title\">");
#nullable restore
#line 12 "D:\Unity Projects\Turtle\Spedito\Spedito\Spedito\Views\Shared\Components\Step\Default.cshtml"
                                         Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                <div class=\"step-item__desc\">");
#nullable restore
#line 13 "D:\Unity Projects\Turtle\Spedito\Spedito\Spedito\Views\Shared\Components\Step\Default.cshtml"
                                        Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n            </div>\r\n        </li>\r\n");
#nullable restore
#line 16 "D:\Unity Projects\Turtle\Spedito\Spedito\Spedito\Views\Shared\Components\Step\Default.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</ul>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<StepViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
