#pragma checksum "D:\Unity Projects\Turtle\Spedito\Spedito\Spedito\Views\Products\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f4eaea9068bbe0643e7905e846a4490fd9b13791"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Products_Index), @"mvc.1.0.view", @"/Views/Products/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f4eaea9068bbe0643e7905e846a4490fd9b13791", @"/Views/Products/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6683956ace1150be5761480987334349baab5d94", @"/Views/_ViewImports.cshtml")]
    public class Views_Products_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProductViewModel>
    {
        private global::AspNetCore.Views_Products_Index.__Generated__BannerViewComponentTagHelper __BannerViewComponentTagHelper;
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "products", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "leavereview", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("text-decoration: none; color: white;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\Unity Projects\Turtle\Spedito\Spedito\Spedito\Views\Products\Index.cshtml"
  
    ViewData["Title"] = Model.Name;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<main class=\"page-main\">\r\n    <div class=\"section-first-screen\">\r\n        <div class=\"first-screen__bg\"></div>\r\n        <div class=\"first-screen__content\">\r\n            <div class=\"uk-container\">\r\n                \r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("vc:banner", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f4eaea9068bbe0643e7905e846a4490fd9b137915791", async() => {
            }
            );
            __BannerViewComponentTagHelper = CreateTagHelper<global::AspNetCore.Views_Products_Index.__Generated__BannerViewComponentTagHelper>();
            __tagHelperExecutionContext.Add(__BannerViewComponentTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n                <div class=\"first-screen__box\">\r\n                    <h2 class=\"first-screen__title\">");
#nullable restore
#line 16 "D:\Unity Projects\Turtle\Spedito\Spedito\Spedito\Views\Products\Index.cshtml"
                                               Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                    <div class=\"first-screen__breadcrumb\">\r\n                        <ul class=\"uk-breadcrumb\">\r\n                            <li>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f4eaea9068bbe0643e7905e846a4490fd9b137917215", async() => {
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
            WriteLiteral("</li>\r\n                            <li><span>");
#nullable restore
#line 20 "D:\Unity Projects\Turtle\Spedito\Spedito\Spedito\Views\Products\Index.cshtml"
                                 Write(Model.Name);

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
    <div class=""page-content"">
        <div class=""uk-margin-large-top uk-container"">
            <div class=""product-full-card"">
                <div class=""uk-grid uk-grid-large uk-child-width-1-2@m uk-flex-middle"" data-uk-grid>
                    <div>
                        <div class=""product-full-card__gallery"">
                            <div data-uk-slideshow=""ratio: 1:1; animation: slide"">
                                <div class=""product-full-card__gallery-box"">
                                    <ul class=""uk-slideshow-items uk-child-width-1-1"">
");
#nullable restore
#line 36 "D:\Unity Projects\Turtle\Spedito\Spedito\Spedito\Views\Products\Index.cshtml"
                                         foreach (var item in Model.Photos)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <li class=\"uk-flex uk-flex-center uk-flex-middle\"><img");
            BeginWriteAttribute("src", " src=\"", 1662, "\"", 1713, 2);
            WriteAttributeValue("", 1668, "https://res.cloudinary.com/dkuqiqad9/v1/", 1668, 40, true);
#nullable restore
#line 38 "D:\Unity Projects\Turtle\Spedito\Spedito\Spedito\Views\Products\Index.cshtml"
WriteAttributeValue("", 1708, item, 1708, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"pizza-big\"></li>\r\n");
#nullable restore
#line 39 "D:\Unity Projects\Turtle\Spedito\Spedito\Spedito\Views\Products\Index.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                    </ul>
                                </div>
                                <div class=""uk-margin-top"" data-uk-slider=""finite: true"">
                                    <ul class=""uk-thumbnav uk-slider-items uk-grid uk-grid-small uk-child-width-1-3 uk-child-width-1-4@l"">
");
#nullable restore
#line 44 "D:\Unity Projects\Turtle\Spedito\Spedito\Spedito\Views\Products\Index.cshtml"
                                         foreach (var item in Model.Photos)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <li data-uk-slideshow-item=\"0\"><a href=\"#\"><img");
            BeginWriteAttribute("src", " src=\"", 2306, "\"", 2357, 2);
            WriteAttributeValue("", 2312, "https://res.cloudinary.com/dkuqiqad9/v1/", 2312, 40, true);
#nullable restore
#line 46 "D:\Unity Projects\Turtle\Spedito\Spedito\Spedito\Views\Products\Index.cshtml"
WriteAttributeValue("", 2352, item, 2352, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"pizza-big\"></a></li>\r\n");
#nullable restore
#line 47 "D:\Unity Projects\Turtle\Spedito\Spedito\Spedito\Views\Products\Index.cshtml"
                                            
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                        </ul>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div>
                        <div class=""product-full-card__content"">
                            <div class=""product-full-card__not-active"">
                                <div class=""product-full-card__title"">");
#nullable restore
#line 57 "D:\Unity Projects\Turtle\Spedito\Spedito\Spedito\Views\Products\Index.cshtml"
                                                                 Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                                <div class=\"product-full-card__desc\">");
#nullable restore
#line 58 "D:\Unity Projects\Turtle\Spedito\Spedito\Spedito\Views\Products\Index.cshtml"
                                                                Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
                                
                            </div>
                        </div>
                        <div class=""product-full-card__info"" style=""margin-top:30px"">
                            <div class=""product-full-card__price""> <span>Price: </span><span class=""value"">$");
#nullable restore
#line 63 "D:\Unity Projects\Turtle\Spedito\Spedito\Spedito\Views\Products\Index.cshtml"
                                                                                                       Write(Model.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span></div>
                            <div class=""product-full-card__btns"">
                                <a class=""uk-button"" href=""#!"">
                                    Add to Cart<span data-uk-icon=""cart"">
                                    </span>
                                </a>
                            </div>
                        </div>
                        <div class=""product-full-card__share"">
                            <span>Share This:</span>
                            <ul>
                                <li><a href=""https://twitter.com/""><i class=""fab fa-twitter""></i></a></li>
                                <li><a href=""https://www.facebook.com/""><i class=""fab fa-facebook-f""></i></a></li>
                                <li><a href=""https://myaccount.google.com/""><i class=""fab fa-google-plus-g""></i></a></li>
                            </ul>
                        </div>
                    </div>
                </div>
                <div class=""produ");
            WriteLiteral(@"ct-full-card__tabs"">
                    <ul class=""uk-subnav"" data-uk-switcher=""animation: uk-animation-slide-left-medium, uk-animation-slide-right-medium"">
                        <li><a href=""#"">Description</a></li>
                        <li><a href=""#"">Reviews (");
#nullable restore
#line 84 "D:\Unity Projects\Turtle\Spedito\Spedito\Spedito\Views\Products\Index.cshtml"
                                            Write(Model.Reviews.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral(")</a></li>\r\n                    </ul>\r\n                    <ul class=\"uk-switcher uk-margin\">\r\n                        <li>\r\n                            ");
#nullable restore
#line 88 "D:\Unity Projects\Turtle\Spedito\Spedito\Spedito\Views\Products\Index.cshtml"
                       Write(Html.Raw(Model.Text));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        </li>
                        
                        <li>
                            <div class=""section-title"">
                                <div class=""uk-h2"">Reviews</div>
                            </div>
                            <ul class=""uk-comment-list"">
");
#nullable restore
#line 96 "D:\Unity Projects\Turtle\Spedito\Spedito\Spedito\Views\Products\Index.cshtml"
                                 foreach (var item in Model.Reviews)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                    <li>
                                        <article class=""uk-comment"">
                                            <header class=""uk-comment-header"">
                                                <div class=""uk-grid-small uk-grid-divider"" data-uk-grid>
                                                    <div class=""uk-width-expand@s"">
                                                        <div class=""uk-flex uk-flex-middle uk-margin-small-bottom"">
                                                            <h4 class=""uk-comment-title uk-margin-remove"">");
#nullable restore
#line 104 "D:\Unity Projects\Turtle\Spedito\Spedito\Spedito\Views\Products\Index.cshtml"
                                                                                                     Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4><span class=\"uk-text-meta uk-margin-small-left\">");
#nullable restore
#line 104 "D:\Unity Projects\Turtle\Spedito\Spedito\Spedito\Views\Products\Index.cshtml"
                                                                                                                                                                    Write(item.AddedDate.ToString("dd MMMM yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                                        </div>\r\n                                                        <div class=\"uk-comment-body\">\r\n                                                            <p>");
#nullable restore
#line 107 "D:\Unity Projects\Turtle\Spedito\Spedito\Spedito\Views\Products\Index.cshtml"
                                                          Write(item.Review);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                                                        </div>
                                                    </div>
                                                </div>
                                            </header>
                                        </article>
                                    </li>
");
#nullable restore
#line 114 "D:\Unity Projects\Turtle\Spedito\Spedito\Spedito\Views\Products\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            </ul>
                            <hr />
                            <div class=""block-form uk-margin-medium-top"">
                                <div class=""section-title"">
                                    <div class=""uk-h2"">Leave a Review</div>
                                </div>

");
#nullable restore
#line 122 "D:\Unity Projects\Turtle\Spedito\Spedito\Spedito\Views\Products\Index.cshtml"
                                 if (_auth.User == null)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <p style=\" font-size: 26px; color: red;\">*Sign in for leave review</p>\r\n");
#nullable restore
#line 125 "D:\Unity Projects\Turtle\Spedito\Spedito\Spedito\Views\Products\Index.cshtml"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                    <div class=""section-content"">
                                        <div class=""uk-grid uk-grid-small uk-child-width-1-2@s"" data-uk-grid>
                                            <div>
                                                <button  class=""uk-button uk-button-large"" type=""submit"">
                                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f4eaea9068bbe0643e7905e846a4490fd9b1379120405", async() => {
                WriteLiteral("\r\n                                                        Leave Review\r\n                                                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 134 "D:\Unity Projects\Turtle\Spedito\Spedito\Spedito\Views\Products\Index.cshtml"
                                                         WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                                </button>\r\n                                            </div>\r\n                                        </div>\r\n                                    </div>\r\n");
#nullable restore
#line 142 "D:\Unity Projects\Turtle\Spedito\Spedito\Spedito\Views\Products\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </div>\r\n                        </li>\r\n                    </ul>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n    \r\n</main>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IAuth _auth { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProductViewModel> Html { get; private set; }
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
