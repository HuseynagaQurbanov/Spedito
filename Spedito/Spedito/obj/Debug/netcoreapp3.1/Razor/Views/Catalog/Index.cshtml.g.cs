#pragma checksum "C:\Users\SOFT\Desktop\Work\WebApps\Spedito\Spedito\Spedito\Views\Catalog\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "afcac6db1b13c32fa473a928828abe8b7e0eb481"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Catalog_Index), @"mvc.1.0.view", @"/Views/Catalog/Index.cshtml")]
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
#line 1 "C:\Users\SOFT\Desktop\Work\WebApps\Spedito\Spedito\Spedito\Views\_ViewImports.cshtml"
using Spedito;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\SOFT\Desktop\Work\WebApps\Spedito\Spedito\Spedito\Views\_ViewImports.cshtml"
using Spedito.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\SOFT\Desktop\Work\WebApps\Spedito\Spedito\Spedito\Views\_ViewImports.cshtml"
using Spedito.Models.Account;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\SOFT\Desktop\Work\WebApps\Spedito\Spedito\Spedito\Views\_ViewImports.cshtml"
using Spedito.Models.Catalog;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\SOFT\Desktop\Work\WebApps\Spedito\Spedito\Spedito\Views\_ViewImports.cshtml"
using Spedito.Libs;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"afcac6db1b13c32fa473a928828abe8b7e0eb481", @"/Views/Catalog/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6683956ace1150be5761480987334349baab5d94", @"/Views/_ViewImports.cshtml")]
    public class Views_Catalog_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FoodCatalogListViewModel>
    {
        private global::AspNetCore.Views_Catalog_Index.__Generated__BannerViewComponentTagHelper __BannerViewComponentTagHelper;
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "Components/Product/_SingleProduct", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\SOFT\Desktop\Work\WebApps\Spedito\Spedito\Spedito\Views\Catalog\Index.cshtml"
  
    ViewData["Title"] = "Catalog";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<main class=\"page-main\">\r\n    <div class=\"section-first-screen\">\r\n        <div class=\"first-screen__bg\"></div>\r\n        <div class=\"first-screen__content\">\r\n            <div class=\"uk-container\">\r\n                \r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("vc:banner", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "afcac6db1b13c32fa473a928828abe8b7e0eb4815328", async() => {
            }
            );
            __BannerViewComponentTagHelper = CreateTagHelper<global::AspNetCore.Views_Catalog_Index.__Generated__BannerViewComponentTagHelper>();
            __tagHelperExecutionContext.Add(__BannerViewComponentTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n                <div class=\"first-screen__box\">\r\n                    <h2 style=\"text-transform:uppercase\" class=\"first-screen__title\">");
#nullable restore
#line 15 "C:\Users\SOFT\Desktop\Work\WebApps\Spedito\Spedito\Spedito\Views\Catalog\Index.cshtml"
                                                                                Write(Model.FoodCatalog.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                    <p class=\"first-screen__desc\">Delicious & Tasty Pizzas By Expert Chefs</p>\r\n                    <div class=\"first-screen__breadcrumb\">\r\n                        <ul class=\"uk-breadcrumb\">\r\n                            <li>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "afcac6db1b13c32fa473a928828abe8b7e0eb4816940", async() => {
                WriteLiteral("HOME");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</li>\r\n                            <li><span style=\"text-transform:uppercase\">");
#nullable restore
#line 20 "C:\Users\SOFT\Desktop\Work\WebApps\Spedito\Spedito\Spedito\Views\Catalog\Index.cshtml"
                                                                  Write(Model.FoodCatalog.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span></li>
                        </ul>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div class=""page-content"" style=""margin-top: 150px"">
        <div class=""uk-container"">
            <div data-uk-filter=""target: .js-filter"">
                <ul class=""uk-slider-items uk-grid uk-grid-small uk-child-width-1-2@s uk-child-width-1-3@m uk-child-width-1-4@l"" data-uk-grid>
");
#nullable restore
#line 31 "C:\Users\SOFT\Desktop\Work\WebApps\Spedito\Spedito\Spedito\Views\Catalog\Index.cshtml"
                     foreach (var item in Model.Products)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <li class=\"uk-first-column\" style=\"width:25%; display:inline\">\r\n                            <div class=\"product-item\">\r\n                                <div class=\"product-item__box\">\r\n\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "afcac6db1b13c32fa473a928828abe8b7e0eb4819665", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
#nullable restore
#line 37 "C:\Users\SOFT\Desktop\Work\WebApps\Spedito\Spedito\Spedito\Views\Catalog\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = item;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n                                </div>\r\n                            </div>\r\n                        </li>\r\n");
#nullable restore
#line 42 "C:\Users\SOFT\Desktop\Work\WebApps\Spedito\Spedito\Spedito\Views\Catalog\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </ul>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</main>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FoodCatalogListViewModel> Html { get; private set; }
        [Microsoft.AspNetCore.Razor.TagHelpers.HtmlTargetElementAttribute("vc:banner")]
        public class __Generated__BannerViewComponentTagHelper : Microsoft.AspNetCore.Razor.TagHelpers.TagHelper
        {
            private readonly global::Microsoft.AspNetCore.Mvc.IViewComponentHelper __helper = null;
            public __Generated__BannerViewComponentTagHelper(global::Microsoft.AspNetCore.Mvc.IViewComponentHelper helper)
            {
                __helper = helper;
            }
            [Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeNotBoundAttribute, global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewContextAttribute]
            public global::Microsoft.AspNetCore.Mvc.Rendering.ViewContext ViewContext { get; set; }
            public override async global::System.Threading.Tasks.Task ProcessAsync(Microsoft.AspNetCore.Razor.TagHelpers.TagHelperContext __context, Microsoft.AspNetCore.Razor.TagHelpers.TagHelperOutput __output)
            {
                (__helper as global::Microsoft.AspNetCore.Mvc.ViewFeatures.IViewContextAware)?.Contextualize(ViewContext);
                var __helperContent = await __helper.InvokeAsync("Banner", new {  });
                __output.TagName = null;
                __output.Content.SetHtmlContent(__helperContent);
            }
        }
    }
}
#pragma warning restore 1591
