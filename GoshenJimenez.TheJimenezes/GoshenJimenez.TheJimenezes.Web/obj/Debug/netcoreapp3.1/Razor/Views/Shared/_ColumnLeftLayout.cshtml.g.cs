#pragma checksum "C:\Users\goshe\OneDrive\Documents\Personal\TheJimenezes\GoshenJimenez.TheJimenezes\GoshenJimenez.TheJimenezes.Web\Views\Shared\_ColumnLeftLayout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cb2b2d178acbc24b873fa5e48df6810db66e93fb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__ColumnLeftLayout), @"mvc.1.0.view", @"/Views/Shared/_ColumnLeftLayout.cshtml")]
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
#line 1 "C:\Users\goshe\OneDrive\Documents\Personal\TheJimenezes\GoshenJimenez.TheJimenezes\GoshenJimenez.TheJimenezes.Web\Views\_ViewImports.cshtml"
using GoshenJimenez.TheJimenezes.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\goshe\OneDrive\Documents\Personal\TheJimenezes\GoshenJimenez.TheJimenezes\GoshenJimenez.TheJimenezes.Web\Views\_ViewImports.cshtml"
using GoshenJimenez.TheJimenezes.Web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cb2b2d178acbc24b873fa5e48df6810db66e93fb", @"/Views/Shared/_ColumnLeftLayout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2c49cb6f1d9026abf12ae07a0f92f653e1b41e4d", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__ColumnLeftLayout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("search-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\goshe\OneDrive\Documents\Personal\TheJimenezes\GoshenJimenez.TheJimenezes\GoshenJimenez.TheJimenezes.Web\Views\Shared\_ColumnLeftLayout.cshtml"
  
    Layout = "~/Views/Shared/_CommonLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<main class=\"post blog-post posts-listing col-lg-8\">\r\n    <div class=\"container\">\r\n        ");
#nullable restore
#line 7 "C:\Users\goshe\OneDrive\Documents\Personal\TheJimenezes\GoshenJimenez.TheJimenezes\GoshenJimenez.TheJimenezes.Web\Views\Shared\_ColumnLeftLayout.cshtml"
   Write(RenderBody());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n</main>\r\n\r\n<aside class=\"col-lg-4\">\r\n    <!-- Widget [Search Bar Widget]-->\r\n    <div class=\"widget search\">\r\n        <header>\r\n            <h3 class=\"h6\">Search the blog</h3>\r\n        </header>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cb2b2d178acbc24b873fa5e48df6810db66e93fb5114", async() => {
                WriteLiteral("\r\n            <div class=\"form-group\">\r\n                <input type=\"search\" placeholder=\"What are you looking for?\">\r\n                <button type=\"submit\" class=\"submit\"><i class=\"icon-search\"></i></button>\r\n            </div>\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
    </div>
    <!-- Widget [Latest Posts Widget]        -->
    <div class=""widget latest-posts"">
        <header>
            <h3 class=""h6"">Latest Posts</h3>
        </header>
        <div class=""blog-posts"">
            <a href=""#"">
                <div class=""item d-flex align-items-center"">
                    <div class=""image""><img src=""img/small-thumbnail-1.jpg"" alt=""..."" class=""img-fluid""></div>
                    <div class=""title"">
                        <strong>Alberto Savoia Can Teach You About</strong>
                        <div class=""d-flex align-items-center"">
                            <div class=""views""><i class=""icon-eye""></i> 500</div>
                            <div class=""comments""><i class=""icon-comment""></i>12</div>
                        </div>
                    </div>
                </div>
            </a><a href=""#"">
                <div class=""item d-flex align-items-center"">
                    <div class=""image""><img src=""img/small-thumbnail-2.jpg");
            WriteLiteral(@""" alt=""..."" class=""img-fluid""></div>
                    <div class=""title"">
                        <strong>Alberto Savoia Can Teach You About</strong>
                        <div class=""d-flex align-items-center"">
                            <div class=""views""><i class=""icon-eye""></i> 500</div>
                            <div class=""comments""><i class=""icon-comment""></i>12</div>
                        </div>
                    </div>
                </div>
            </a><a href=""#"">
                <div class=""item d-flex align-items-center"">
                    <div class=""image""><img src=""img/small-thumbnail-3.jpg"" alt=""..."" class=""img-fluid""></div>
                    <div class=""title"">
                        <strong>Alberto Savoia Can Teach You About</strong>
                        <div class=""d-flex align-items-center"">
                            <div class=""views""><i class=""icon-eye""></i> 500</div>
                            <div class=""comments""><i class=""icon-comment""></i>");
            WriteLiteral(@"12</div>
                        </div>
                    </div>
                </div>
            </a>
        </div>
    </div>
    <!-- Widget [Categories Widget]-->
    <div class=""widget categories"">
        <header>
            <h3 class=""h6"">Categories</h3>
        </header>
        <div class=""item d-flex justify-content-between""><a href=""#"">Growth</a><span>12</span></div>
        <div class=""item d-flex justify-content-between""><a href=""#"">Local</a><span>25</span></div>
        <div class=""item d-flex justify-content-between""><a href=""#"">Sales</a><span>8</span></div>
        <div class=""item d-flex justify-content-between""><a href=""#"">Tips</a><span>17</span></div>
        <div class=""item d-flex justify-content-between""><a href=""#"">Local</a><span>25</span></div>
    </div>
    <!-- Widget [Tags Cloud Widget]-->
    <div class=""widget tags"">
        <header>
            <h3 class=""h6"">Tags</h3>
        </header>
        <ul class=""list-inline"">
            <li class=""list-in");
            WriteLiteral(@"line-item""><a href=""#"" class=""tag"">#Business</a></li>
            <li class=""list-inline-item""><a href=""#"" class=""tag"">#Technology</a></li>
            <li class=""list-inline-item""><a href=""#"" class=""tag"">#Fashion</a></li>
            <li class=""list-inline-item""><a href=""#"" class=""tag"">#Sports</a></li>
            <li class=""list-inline-item""><a href=""#"" class=""tag"">#Economy</a></li>
        </ul>
    </div>
</aside>

");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    ");
#nullable restore
#line 93 "C:\Users\goshe\OneDrive\Documents\Personal\TheJimenezes\GoshenJimenez.TheJimenezes\GoshenJimenez.TheJimenezes.Web\Views\Shared\_ColumnLeftLayout.cshtml"
Write(RenderSection("Scripts", false));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
            }
            );
            WriteLiteral("\r\n");
            DefineSection("Styles", async() => {
                WriteLiteral("\r\n    ");
#nullable restore
#line 97 "C:\Users\goshe\OneDrive\Documents\Personal\TheJimenezes\GoshenJimenez.TheJimenezes\GoshenJimenez.TheJimenezes.Web\Views\Shared\_ColumnLeftLayout.cshtml"
Write(RenderSection("Styles", false));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
            }
            );
            WriteLiteral(" ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
