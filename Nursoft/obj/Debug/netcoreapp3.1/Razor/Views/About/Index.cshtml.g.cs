#pragma checksum "C:\Users\User\RiderProjects\Nursoft\Nursoft\Views\About\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9c01631d776193bed655f23ac4e5e4241c381693"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_About_Index), @"mvc.1.0.view", @"/Views/About/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9c01631d776193bed655f23ac4e5e4241c381693", @"/Views/About/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4ebdc68990a4f9af9a3f84679c512ba0dfddad33", @"/Views/_ViewImports.cshtml")]
    public class Views_About_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AboutViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\User\RiderProjects\Nursoft\Nursoft\Views\About\Index.cshtml"
  
    ViewBag.Title = "About";
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"


<section class=""with-bg solid-section"">
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
                </li><li>Pages</li>
                <li class=""path-separator"">
                    <i class=""fas fa-chevron-right"" aria-hidden=""true""></i>
                </li><li>About Us</li>
            </ul>
        </div>
    </div>
</section>
<section class=""muted-bg solid-section"" data-inview-showup=""showup-translate-up"">
    <div class=""container"">
        <div class=""row cols-xl rows-lg"">
");
#nullable restore
#line 33 "C:\Users\User\RiderProjects\Nursoft\Nursoft\Views\About\Index.cshtml"
             foreach (var about in Model.Abouts)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"md-col-6 text-center md-text-left\">\r\n                    <h2 class=\"text-upper text-semibold\">What we do</h2>\r\n                    <p>");
#nullable restore
#line 37 "C:\Users\User\RiderProjects\Nursoft\Nursoft\Views\About\Index.cshtml"
                  Write(about.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                </div>\r\n                <div class=\"md-col-6 md-fix-container\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "9c01631d776193bed655f23ac4e5e4241c3816935529", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1374, "~/images/service/", 1374, 17, true);
#nullable restore
#line 40 "C:\Users\User\RiderProjects\Nursoft\Nursoft\Views\About\Index.cshtml"
AddHtmlAttributeValue("", 1391, about.Image, 1391, 12, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 40 "C:\Users\User\RiderProjects\Nursoft\Nursoft\Views\About\Index.cshtml"
AddHtmlAttributeValue("", 1410, about.Image, 1410, 12, false);

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
            WriteLiteral("\r\n                </div>\r\n");
#nullable restore
#line 42 "C:\Users\User\RiderProjects\Nursoft\Nursoft\Views\About\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </div>
    </div>
</section>
<section class=""content-section"" data-inview-showup=""showup-translate-up"">
    <div class=""container"">
        <div class=""row cols-md rows-xl"">
            <div class=""md-col-3 text-center md-text-left"">
                <h3 class=""text-upper text-semibold"">Our team</h3>
                <p>Meet with our qualified and expert team. We are specialized in our individual field. We have enough skill and tested. That’s why you’re getting the quality repair services.</p>
                <div class=""shift-lg"">
                    <a class=""btn text-upper"" href=""contact-us.html"">Contact us</a>
                </div>
            </div>
");
#nullable restore
#line 56 "C:\Users\User\RiderProjects\Nursoft\Nursoft\Views\About\Index.cshtml"
             foreach (var team in Model.Teams)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <div class=""md-col-3 sm-col-4"">
                    <div class=""member sm-fix-container"">
                        <div class=""text-center"">
                            <span class=""image-wrap"">
                                <img class=""image""");
            BeginWriteAttribute("src", " src=\"", 2475, "\"", 2509, 2);
            WriteAttributeValue("", 2481, "images/outsource/", 2481, 17, true);
#nullable restore
#line 62 "C:\Users\User\RiderProjects\Nursoft\Nursoft\Views\About\Index.cshtml"
WriteAttributeValue("", 2498, team.Image, 2498, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 2510, "\"", 2527, 1);
#nullable restore
#line 62 "C:\Users\User\RiderProjects\Nursoft\Nursoft\Views\About\Index.cshtml"
WriteAttributeValue("", 2516, team.Image, 2516, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                            </span>\r\n                        </div>\r\n                        <div class=\"member-info muted-bg text-center\">\r\n                            <div class=\"member-title\">");
#nullable restore
#line 66 "C:\Users\User\RiderProjects\Nursoft\Nursoft\Views\About\Index.cshtml"
                                                 Write(team.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                            <div class=\"member-subtitle\">");
#nullable restore
#line 67 "C:\Users\User\RiderProjects\Nursoft\Nursoft\Views\About\Index.cshtml"
                                                    Write(team.Position);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
                            <div class=""cols-list cols-sm socials inline-block"">
                                <a href=""#"" class=""list-item"">
                                    <i class=""fab fa-facebook-f"" aria-hidden=""true""></i>
                                </a>
                                <a href=""#"" class=""list-item"">
                                    <i class=""fab fa-twitter"" aria-hidden=""true""></i>
                                </a>
                                <a href=""#"" class=""list-item"">
                                    <i class=""fab fa-google-plus-g"" aria-hidden=""true""></i>
                                </a>
                            </div>
                        </div>
                    </div>
                </div>
");
#nullable restore
#line 82 "C:\Users\User\RiderProjects\Nursoft\Nursoft\Views\About\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </div>
    </div>
</section>
<section class=""main-bg"" data-inview-showup=""showup-translate-up"">
    <div class=""container"">
        <div class=""contact-table only-xs-text-center"">
            <div class=""contact-icon xs-hidden"">
                <i class=""fas fa-bicycle"" aria-hidden=""true""></i>
            </div>
            <div class=""contact-content"">
                <div class=""contact-title"">Request free consultation</div>
                <div class=""text-justify only-xs-text-justify-center"">Get answers and advice from people you want it from.</div>
            </div>
            <div class=""contact-btn"">
                <a href=""contact-us.html"" class=""btn btns-white text-upper"">Contact Us</a>
            </div>
        </div>
    </div>
</section>
<a href=""#"" class=""scroll-top disabled"">
    <i class=""fas fa-angle-up"" aria-hidden=""true""></i>
</a>
<div class=""loader-block"">
    <div class=""loader-back alt-bg""></div>
    <div class=""loader-image"">
        <img class=""image");
            WriteLiteral("\" src=\"images/parts/loader.gif\"");
            BeginWriteAttribute("alt", " alt=\"", 4671, "\"", 4677, 0);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AboutViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
