#pragma checksum "C:\Users\SOFT\Desktop\Work\WebApps\Spedito\Spedito\Spedito\Views\Shared\Components\Product\_SingleProduct.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fd4da9be84a278d1e4453afdd59e8f380ccd6768"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Product__SingleProduct), @"mvc.1.0.view", @"/Views/Shared/Components/Product/_SingleProduct.cshtml")]
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
#nullable restore
#line 6 "C:\Users\SOFT\Desktop\Work\WebApps\Spedito\Spedito\Spedito\Views\_ViewImports.cshtml"
using SpeditoReposity.Enum;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fd4da9be84a278d1e4453afdd59e8f380ccd6768", @"/Views/Shared/Components/Product/_SingleProduct.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"079e9b0d9c2c880388c8e1de4cdb0024b9fe0b43", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Product__SingleProduct : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProductViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Creamy Melt Pizza"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "product", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("uk-button uk-button-default"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "products", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"        <div class=""product-item"">
            <div class=""product-item__box"">
                <div class=""product-item__intro"">
                    <div class=""product-item__not-active"">
                        <div class=""product-item__media"">
                            <div class=""uk-inline-clip uk-transition-toggle uk-light"" data-uk-lightbox=""data-uk-lightbox"">
                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fd4da9be84a278d1e4453afdd59e8f380ccd67686212", async() => {
                WriteLiteral("\r\n                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "fd4da9be84a278d1e4453afdd59e8f380ccd67686503", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 531, "~/uploads/", 531, 10, true);
#nullable restore
#line 9 "C:\Users\SOFT\Desktop\Work\WebApps\Spedito\Spedito\Spedito\Views\Shared\Components\Product\_SingleProduct.cshtml"
AddHtmlAttributeValue("", 541, Model.Photos.FirstOrDefault(), 541, 30, false);

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
                WriteLiteral(@"
                                    <div class=""uk-transition-fade uk-position-cover uk-overlay uk-overlay-primary""></div>
                                    <div class=""uk-position-center""><span class=""uk-transition-fade"" data-uk-icon=""icon: search;""></span></div>
                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 441, "~/uploads/", 441, 10, true);
#nullable restore
#line 8 "C:\Users\SOFT\Desktop\Work\WebApps\Spedito\Spedito\Spedito\Views\Shared\Components\Product\_SingleProduct.cshtml"
AddHtmlAttributeValue("", 451, Model.Photos.FirstOrDefault(), 451, 30, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                            </div>
                            <div class=""product-item__whish""><i class=""fas fa-heart""></i></div>
                            <div class=""product-item__type spicy""></div>
                            <div class=""product-item__tooltip"" data-uk-tooltip=""title: spicy pizza; pos: bottom-right""><i class=""fas fa-info-circle""></i></div>
                        </div>
                        <div class=""product-item__title"">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fd4da9be84a278d1e4453afdd59e8f380ccd676810277", async() => {
#nullable restore
#line 18 "C:\Users\SOFT\Desktop\Work\WebApps\Spedito\Spedito\Spedito\Views\Shared\Components\Product\_SingleProduct.cshtml"
                                                                                                                            Write(Model.Name);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 18 "C:\Users\SOFT\Desktop\Work\WebApps\Spedito\Spedito\Spedito\Views\Shared\Components\Product\_SingleProduct.cshtml"
                                                                                                          WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</div>\r\n                        <div class=\"product-item__desc\">");
#nullable restore
#line 19 "C:\Users\SOFT\Desktop\Work\WebApps\Spedito\Spedito\Spedito\Views\Shared\Components\Product\_SingleProduct.cshtml"
                                                   Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
                        <div class=""product-item__select"">
                            <div class=""select-box select-box--thickness"">
                                <ul>
                                    <li><label><input type=""radio"" name=""thickness-1"" checked=""checked"" /><span>Thin</span></label></li>
                                    <li><label><input type=""radio"" name=""thickness-1"" /><span>Normal</span></label></li>
                                    <li><label><input type=""radio"" name=""thickness-1"" /><span>Thick</span></label></li>
                                </ul>
                            </div>
                            <div class=""select-box select-box--size"">
                                <ul>
                                    <li><label><input type=""radio"" name=""size-1"" /><span>7 “</span></label></li>
                                    <li><label><input type=""radio"" name=""size-1"" /><span>9 “</span></label></li>
                                    <li><label><i");
            WriteLiteral(@"nput type=""radio"" name=""size-1"" checked=""checked"" /><span>11 “</span></label></li>
                                </ul>
                            </div>
                        </div>
                    </div>
                </div>
                <div class=""product-item__info"">
                    <div class=""product-item__price""> <span>Price: </span><span class=""value"">$");
#nullable restore
#line 39 "C:\Users\SOFT\Desktop\Work\WebApps\Spedito\Spedito\Spedito\Views\Shared\Components\Product\_SingleProduct.cshtml"
                                                                                          Write(Model.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></div>\r\n                    <div class=\"product-item__addcart\"> ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fd4da9be84a278d1e4453afdd59e8f380ccd676815294", async() => {
                WriteLiteral("Add to Cart<span data-uk-icon=\"cart\"></span>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 40 "C:\Users\SOFT\Desktop\Work\WebApps\Spedito\Spedito\Spedito\Views\Shared\Components\Product\_SingleProduct.cshtml"
                                                                                                                                              WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n\r\n      ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProductViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
