#pragma checksum "C:\Users\User\RiderProjects\Nursoft\Nursoft\Views\Services\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "817db1a3da8238e5a10adf096607b16dff7cf197"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Services_Index), @"mvc.1.0.view", @"/Views/Services/Index.cshtml")]
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
#line 1 "C:\Users\User\RiderProjects\Nursoft\Nursoft\Views\_ViewImports.cshtml"
using Nursoft;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\RiderProjects\Nursoft\Nursoft\Views\_ViewImports.cshtml"
using Nursoft.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\User\RiderProjects\Nursoft\Nursoft\Views\_ViewImports.cshtml"
using Nursoft.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"817db1a3da8238e5a10adf096607b16dff7cf197", @"/Views/Services/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5299c053a1a2681cb0f517d3061f9992bb2d96b9", @"/Views/_ViewImports.cshtml")]
    public class Views_Services_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Service>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Service", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-md btns-bordered text-upper pull-right"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\User\RiderProjects\Nursoft\Nursoft\Views\Services\Index.cshtml"
  
    ViewBag.Title = "Services";
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<section class=""with-bg solid-section"">
    <div class=""fix-image-wrap"" data-image-src=""./images/service/motherboard-4.jpg"" data-parallax=""scroll""></div>
    <div class=""theme-back""></div>
    <div class=""container page-info"">
    </div>
    <div class=""section-footer"">
        <div class=""container"" data-inview-showup=""showup-translate-down"">
            <ul class=""page-path"">
                <li>
                    <a href=""index.html"">Home</a>
                </li>
                <li class=""path-separator"">
                    <i class=""fas fa-chevron-right"" aria-hidden=""true""></i>
                </li><li>Services</li>
            </ul>
        </div>
    </div>
</section>
<section class=""content-section"" style=""padding-bottom: 40px"">
<div class=""container"">
<div class=""shuffle-js"">
<div class=""row cols-md rows-md shuffle-items"">
");
#nullable restore
#line 31 "C:\Users\User\RiderProjects\Nursoft\Nursoft\Views\Services\Index.cshtml"
 foreach (var service in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""shuffle-item col-12 md-col-4 sm-col-6"" data-groups='[""Computer"", ""Laptop"", ""Smartphone""]'>
        <div class=""item muted-bg"" data-inview-showup=""showup-scale"">
            <a href=""service.html"" class=""block-link"">
                <span class=""image-wrap"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "817db1a3da8238e5a10adf096607b16dff7cf1976121", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1328, "~/images/service/", 1328, 17, true);
#nullable restore
#line 37 "C:\Users\User\RiderProjects\Nursoft\Nursoft\Views\Services\Index.cshtml"
AddHtmlAttributeValue("", 1345, service.Image, 1345, 14, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 37 "C:\Users\User\RiderProjects\Nursoft\Nursoft\Views\Services\Index.cshtml"
AddHtmlAttributeValue("", 1366, service.Image, 1366, 14, false);

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
                </span>
                <span class=""hover"">
                    <span class=""hover-show"">
                        <span class=""back""></span>
                        <span class=""content"">
                            <i class=""fas fa-search"" aria-hidden=""true""></i>
                        </span>
                    </span>
                </span>
            </a>
            <div class=""item-content"">
                <div class=""item-title text-upper"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "817db1a3da8238e5a10adf096607b16dff7cf1978662", async() => {
#nullable restore
#line 50 "C:\Users\User\RiderProjects\Nursoft\Nursoft\Views\Services\Index.cshtml"
                                                                  Write(Html.Raw(service.Name));

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 50 "C:\Users\User\RiderProjects\Nursoft\Nursoft\Views\Services\Index.cshtml"
                                              WriteLiteral(service.Id);

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
            WriteLiteral("\r\n                </div>\r\n                <div class=\"item-text\">");
#nullable restore
#line 52 "C:\Users\User\RiderProjects\Nursoft\Nursoft\Views\Services\Index.cshtml"
                                  Write(service.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "817db1a3da8238e5a10adf096607b16dff7cf19711363", async() => {
                WriteLiteral("read more");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 53 "C:\Users\User\RiderProjects\Nursoft\Nursoft\Views\Services\Index.cshtml"
                                          WriteLiteral(service.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 57 "C:\Users\User\RiderProjects\Nursoft\Nursoft\Views\Services\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
</div>
</div>
</section>
<div class=""block-cart collapse"" data-block=""cart"" data-show-block-class=""animation-scale-top-right"" data-hide-block-class=""animation-unscale-top-right"">
    <div class=""cart-inner"">
        <a href=""#"" class=""close-link"" data-close-block>
            <i class=""fas fa-times"" aria-hidden=""true""></i>
        </a><h4 class=""text-upper text-center"">Your cart</h4>
        <div class=""items"">
            <div class=""items collapse"" data-block=""cart"" data-show-block-class=""animation-scale-top-right"" data-hide-block-class=""animation-unscale-top-right"">
                <div class=""shop-side-item cart-item"">
                    <a href=""#"" class=""remove"">
                        <i class=""fas fa-times""></i>
                    </a>
                    <div class=""item-side-image"">
                        <a href=""shop-item.html"" class=""item-image responsive-1by1"">
                            <img src=""images/shop/usb-hub.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 3227, "\"", 3233, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                        </a>
                    </div>
                    <div class=""item-side"">
                        <div class=""item-title"">
                            <a class=""item-label-sm item-label-sale item-label"" href=""#"">sale</a> <a href=""shop-item.html"" class=""content-link text-upper"">USB 3.0 HUB</a>
                        </div>
                        <div class=""item-quantity"">Quantity - 1</div>
                        <div class=""item-prices"">
                            <div class=""item-price"">$67.05</div>
                            <div class=""item-old-price"">$102.5</div>
                        </div>
                    </div>
                </div>
                <div class=""shop-side-item cart-item"">
                    <a href=""#"" class=""remove"">
                        <i class=""fas fa-times""></i>
                    </a>
                    <div class=""item-side-image"">
                        <a href=""shop-item.html"" class=""item-image responsive-1by1"">
");
            WriteLiteral("                            <img src=\"images/shop/cable-organizer.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 4328, "\"", 4334, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                        </a>
                    </div>
                    <div class=""item-side"">
                        <div class=""item-title"">
                            <a class=""item-label-sm item-label-new item-label"" href=""#"">new</a> <a href=""shop-item.html"" class=""content-link text-upper"">Cable Organizer</a>
                        </div>
                        <div class=""item-quantity"">Quantity - 1</div>
                        <div class=""item-prices"">
                            <div class=""item-price"">$15.25</div>
                        </div>
                    </div>
                </div>
                <div class=""shop-side-item cart-item"">
                    <a href=""#"" class=""remove"">
                        <i class=""fas fa-times""></i>
                    </a>
                    <div class=""item-side-image"">
                        <a href=""shop-item.html"" class=""item-image responsive-1by1"">
                            <img src=""images/shop/tablet.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 5352, "\"", 5358, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                        </a>
                    </div>
                    <div class=""item-side"">
                        <div class=""item-title"">
                            <a href=""shop-item.html"" class=""content-link text-upper"">10"" Octa Core Tablet</a>
                        </div>
                        <div class=""item-quantity"">Quantity - 1</div>
                        <div class=""item-prices"">
                            <div class=""item-price"">$145.99</div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div class=""line-sides main-bg shift-lg""></div>
        <div class=""row out-md"">
            <div class=""col-6 cart-price-title"">Subtotal:</div>
            <div class=""col-6 text-right cart-price"">$105.20</div>
        </div>
        <div class=""line-sides main-bg offs-lg""></div>
        <div class=""clearfix"">
            <a href=""cart.html"" class=""btn text-upper btn-md btns-bordered pull-left"">vi");
            WriteLiteral(@"ew cart</a> <a href=""checkout.html"" class=""btn text-upper btn-md pull-right"">checkout</a>
        </div>
    </div>
</div>
<a href=""#"" class=""scroll-top disabled"">
    <i class=""fas fa-angle-up"" aria-hidden=""true""></i>
</a>
<div class=""singlepage-block collapse alt-bg"" data-block=""search"" data-show-block-class=""animation-scale-top-right"" data-hide-block-class=""animation-unscale-top-right"">
    <a href=""#"" class=""close-link"" data-close-block>
        <i class=""fas fa-times"" aria-hidden=""true""></i>
    </a>
    <div class=""pos-v-center col-12"">
        <div class=""container"">
            <div class=""row cols-md rows-md"">
                <div class=""lg-col-9 md-col-8 sm-col-12"">
                    <div class=""field-group"">
                        <div class=""field-wrap"">
                            <input class=""field-control"" name=""search"" placeholder=""Search Tags"" required=""required""> <span class=""field-back""></span>
                        </div>
                    </div>
               ");
            WriteLiteral(@" </div>
                <div class=""lg-col-3 md-col-4 sm-col-6"">
                    <button class=""btn btns-white-bordered text-upper"" type=""submit"">search</button>
                </div>
            </div>
        </div>
    </div>
</div>
<div class=""loader-block"">
    <div class=""loader-back alt-bg""></div>
    <div class=""loader-image"">
        <img class=""image"" src=""images/parts/loader.gif""");
            BeginWriteAttribute("alt", " alt=\"", 7816, "\"", 7822, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Service>> Html { get; private set; }
    }
}
#pragma warning restore 1591