#pragma checksum "D:\Unity Projects\Turtle\Spedito\Spedito\Spedito\Views\Shared\Components\Slider\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "048b8fe4c881fffbc1849dee15d0fe087bd492f7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Slider_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Slider/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"048b8fe4c881fffbc1849dee15d0fe087bd492f7", @"/Views/Shared/Components/Slider/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6683956ace1150be5761480987334349baab5d94", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Slider_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SliderItemViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"first-screen__slideshow\">\r\n    <div data-uk-slideshow=\"min-height: 400; max-height: 785; autoplay: true\">\r\n        <div class=\"uk-position-relative\" tabindex=\"-1\">\r\n            <ul class=\"uk-slideshow-items\">\r\n");
#nullable restore
#line 7 "D:\Unity Projects\Turtle\Spedito\Spedito\Spedito\Views\Shared\Components\Slider\Default.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <li>\r\n                        <div class=\"uk-position-cover uk-animation-kenburns uk-animation-reverse uk-transform-origin-center-left\">\r\n                            <img");
            BeginWriteAttribute("src", " src=\"", 520, "\"", 545, 2);
            WriteAttributeValue("", 526, "uploads/", 526, 8, true);
#nullable restore
#line 11 "D:\Unity Projects\Turtle\Spedito\Spedito\Spedito\Views\Shared\Components\Slider\Default.cshtml"
WriteAttributeValue("", 534, item.Image, 534, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"slider-1\" data-uk-cover>\r\n                        </div>\r\n                    </li>\r\n");
#nullable restore
#line 14 "D:\Unity Projects\Turtle\Spedito\Spedito\Spedito\Views\Shared\Components\Slider\Default.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </ul>\r\n        </div>\r\n        <div class=\"slideshow-dotnav uk-position-bottom-center\">\r\n            <ul class=\"uk-slideshow-nav uk-dotnav uk-flex-center\"></ul>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<SliderItemViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
