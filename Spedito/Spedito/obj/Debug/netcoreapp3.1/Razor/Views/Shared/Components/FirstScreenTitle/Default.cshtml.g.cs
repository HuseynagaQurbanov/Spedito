#pragma checksum "C:\Users\SOFT\Desktop\Spedito\Spedito\Spedito\Views\Shared\Components\FirstScreenTitle\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8ff826ba73e5a05b700d76d02cb44314ef92bb5b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_FirstScreenTitle_Default), @"mvc.1.0.view", @"/Views/Shared/Components/FirstScreenTitle/Default.cshtml")]
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
#nullable restore
#line 4 "C:\Users\SOFT\Desktop\Spedito\Spedito\Spedito\Views\_ViewImports.cshtml"
using Spedito.Libs;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8ff826ba73e5a05b700d76d02cb44314ef92bb5b", @"/Views/Shared/Components/FirstScreenTitle/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"746a7e401a5912ba2d9ff9affacc95e5d30f13d7", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_FirstScreenTitle_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<FirstScreenTitleViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"first-screen__box\">\r\n");
#nullable restore
#line 4 "C:\Users\SOFT\Desktop\Spedito\Spedito\Spedito\Views\Shared\Components\FirstScreenTitle\Default.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h2 class=\"first-screen__title\">");
#nullable restore
#line 6 "C:\Users\SOFT\Desktop\Spedito\Spedito\Spedito\Views\Shared\Components\FirstScreenTitle\Default.cshtml"
                                   Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n        <p class=\"first-screen__desc\">");
#nullable restore
#line 7 "C:\Users\SOFT\Desktop\Spedito\Spedito\Spedito\Views\Shared\Components\FirstScreenTitle\Default.cshtml"
                                 Write(item.Slogan);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <a class=\"uk-button\"");
            BeginWriteAttribute("href", " href=\"", 265, "\"", 286, 1);
#nullable restore
#line 8 "C:\Users\SOFT\Desktop\Spedito\Spedito\Spedito\Views\Shared\Components\FirstScreenTitle\Default.cshtml"
WriteAttributeValue("", 272, item.EndPoint, 272, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 8 "C:\Users\SOFT\Desktop\Spedito\Spedito\Spedito\Views\Shared\Components\FirstScreenTitle\Default.cshtml"
                                              Write(item.ActionText);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n");
#nullable restore
#line 9 "C:\Users\SOFT\Desktop\Spedito\Spedito\Spedito\Views\Shared\Components\FirstScreenTitle\Default.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div> ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<FirstScreenTitleViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
