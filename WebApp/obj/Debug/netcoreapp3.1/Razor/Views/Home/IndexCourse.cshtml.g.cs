#pragma checksum "E:\Do an\DoAnAspNet\WebSiteHocTap\WebApp\Views\Home\IndexCourse.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d741c5f474ba194df09f55a6350ae42dca33c593"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_IndexCourse), @"mvc.1.0.view", @"/Views/Home/IndexCourse.cshtml")]
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
#line 1 "E:\Do an\DoAnAspNet\WebSiteHocTap\WebApp\Views\_ViewImports.cshtml"
using WebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Do an\DoAnAspNet\WebSiteHocTap\WebApp\Views\_ViewImports.cshtml"
using WebApp.Areas.Admin.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\Do an\DoAnAspNet\WebSiteHocTap\WebApp\Views\_ViewImports.cshtml"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\Do an\DoAnAspNet\WebSiteHocTap\WebApp\Views\_ViewImports.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\Do an\DoAnAspNet\WebSiteHocTap\WebApp\Views\_ViewImports.cshtml"
using WebApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d741c5f474ba194df09f55a6350ae42dca33c593", @"/Views/Home/IndexCourse.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"819e68de9bbbc7d89a0314828859c43ca94fcae9", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_IndexCourse : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WebApp.Areas.Admin.Models.CourseModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card w-75 h-75"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DetailCourse", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("--bg-img: url(https://images1-focus-opensocial.googleusercontent.com/gadgets/proxy?container=focus&resize_w=1500&url=https://codetheweb.blog/assets/img/posts/html-syntax/cover.jpg)"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "E:\Do an\DoAnAspNet\WebSiteHocTap\WebApp\Views\Home\IndexCourse.cshtml"
  
    ViewData["Title"] = "IndexCourse";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("CSS", async() => {
                WriteLiteral(@"
    <style>

:root {
  --color: #3c3163;
  --transition-time: 0.5s;
}

* {
  box-sizing: border-box;
}


a {
  color: inherit;
}

.cards-wrapper {
  display: grid;
  justify-content: center;
  align-items: center;
  grid-template-columns: 1fr 1fr 1fr;
  grid-gap: 4rem;
  padding: 4rem;
  margin: 0 auto;
  width: max-content;
}

.card {
  font-family: 'Heebo';
  --bg-filter-opacity: 0.5;
  background-image: linear-gradient(rgba(0,0,0,var(--bg-filter-opacity)),rgba(0,0,0,var(--bg-filter-opacity))), var(--bg-img);
  height: 20em;
  width: 15em;
  font-size: 1.5em;
  color: white;
  border-radius: 1em;
  padding: 1em;
  /*margin: 2em;*/
  display: flex;
  align-items: flex-end;
  background-size: cover;
  background-position: center;
  box-shadow: 0 0 5em -1em black;
  transition: all, var(--transition-time);
  position: relative;
  overflow: hidden;
  border: 10px solid #ccc;
  text-decoration: none;
}

.card:hover {
  transform: rotate(0);
}

.card h1 {
 ");
                WriteLiteral(@" margin: 0;
  font-size: 1.5em;
  line-height: 1.2em;
}

.card p {
  font-size: 0.75em;
  font-family: 'Open Sans';
  margin-top: 0.5em;
  line-height: 2em;
}

.card .tags {
  display: flex;
}

.card .tags .tag {
  font-size: 0.75em;
  background: rgba(255,255,255,0.5);
  border-radius: 0.3rem;
  padding: 0 0.5em;
  margin-right: 0.5em;
  line-height: 1.5em;
  transition: all, var(--transition-time);
}

.card:hover .tags .tag {
  background: var(--color);
  color: white;
}

.card .date {
  position: absolute;
  top: 0;
  right: 0;
  font-size: 0.75em;
  padding: 1em;
  line-height: 1em;
  opacity: .8;
}

.card:before, .card:after {
  content: '';
  transform: scale(0);
  transform-origin: top left;
  border-radius: 50%;
  position: absolute;
  left: -50%;
  top: -50%;
  z-index: -5;
  transition: all, var(--transition-time);
  transition-timing-function: ease-in-out;
}

.card:before {
  background: #ddd;
  width: 250%;
  height: 250%;
}

.card:after ");
                WriteLiteral(@"{
  background: white;
  width: 200%;
  height: 200%;
}

.card:hover {
  color: var(--color);
}

.card:hover:before, .card:hover:after {
  transform: scale(1);
}

.card-grid-space .num {
  font-size: 3em;
  margin-bottom: 1.2rem;
  margin-left: 1rem;
}

.info {
  font-size: 1.2em;
  display: flex;
  padding: 1em 3em;
  height: 3em;
}

.info img {
  height: 3em;
  margin-right: 0.5em;
}

.info h1 {
  font-size: 1em;
  font-weight: normal;
}

/* MEDIA QUERIES */
");
                WriteLiteral("@ media screen and (max-width: 1285px) {\r\n  .cards-wrapper {\r\n    grid-template-columns: 1fr 1fr;\r\n  }\r\n}\r\n\r\n");
                WriteLiteral("@ media screen and (max-width: 900px) {\r\n  .cards-wrapper {\r\n    grid-template-columns: 1fr;\r\n  }\r\n  .info {\r\n    justify-content: center;\r\n  }\r\n  .card-grid-space .num {\r\n    /margin-left: 0;\r\n    /text-align: center;\r\n  }\r\n}\r\n\r\n");
                WriteLiteral("@ media screen and (max-width: 500px) {\r\n  .cards-wrapper {\r\n    padding: 4rem 2rem;\r\n  }\r\n  .card {\r\n    max-width: calc(100vw - 4rem);\r\n  }\r\n}\r\n\r\n");
                WriteLiteral("@ media screen and (max-width: 450px) {\r\n  .info {\r\n    display: block;\r\n    text-align: center;\r\n  }\r\n  .info h1 {\r\n    margin: 0;\r\n  }\r\n}\r\n    </style>\r\n");
            }
            );
            WriteLiteral("<div class=\"row\">\r\n");
#nullable restore
#line 200 "E:\Do an\DoAnAspNet\WebSiteHocTap\WebApp\Views\Home\IndexCourse.cshtml"
     foreach (var item in Model )
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"col-4\">\r\n        <section class=\"cards-wrapper\">\r\n            <div class=\"card-grid-space w-50\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d741c5f474ba194df09f55a6350ae42dca33c5939306", async() => {
                WriteLiteral("\r\n                    <div>\r\n                        <h1>");
#nullable restore
#line 207 "E:\Do an\DoAnAspNet\WebSiteHocTap\WebApp\Views\Home\IndexCourse.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Title));

#line default
#line hidden
#nullable disable
                WriteLiteral("</h1>\r\n                        <p>");
#nullable restore
#line 208 "E:\Do an\DoAnAspNet\WebSiteHocTap\WebApp\Views\Home\IndexCourse.cshtml"
                      Write(Html.DisplayFor(modelItem => item.Description));

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                        <div class=\"tags\">\r\n                            <div class=\"tag\">");
#nullable restore
#line 210 "E:\Do an\DoAnAspNet\WebSiteHocTap\WebApp\Views\Home\IndexCourse.cshtml"
                                        Write(Html.DisplayFor(modelItem => item.Lang));

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n                        </div>\r\n                    </div>\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
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
#line 205 "E:\Do an\DoAnAspNet\WebSiteHocTap\WebApp\Views\Home\IndexCourse.cshtml"
                                                                                            WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n            <!-- https://images.unsplash.com/photo-1520839090488-4a6c211e2f94?ixlib=rb-0.3.5&ixid=eyJhcHBfaWQiOjEyMDd9&s=38951b8650067840307cba514b554ba5&auto=format&fit=crop&w=1350&q=80 -->\r\n        </section>\r\n    </div>");
#nullable restore
#line 217 "E:\Do an\DoAnAspNet\WebSiteHocTap\WebApp\Views\Home\IndexCourse.cshtml"
          }

#line default
#line hidden
#nullable disable
            WriteLiteral("   \r\n</div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WebApp.Areas.Admin.Models.CourseModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
