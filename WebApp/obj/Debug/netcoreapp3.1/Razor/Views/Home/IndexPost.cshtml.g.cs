#pragma checksum "D:\N_3_HK_1\LT WEB ASP.NET core\DoAn\Project\WebApp\Views\Home\IndexPost.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "402a0d20cd1f6cdd4bd62927ee1f29040aa6e13d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_IndexPost), @"mvc.1.0.view", @"/Views/Home/IndexPost.cshtml")]
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
#line 1 "D:\N_3_HK_1\LT WEB ASP.NET core\DoAn\Project\WebApp\Views\_ViewImports.cshtml"
using WebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\N_3_HK_1\LT WEB ASP.NET core\DoAn\Project\WebApp\Views\_ViewImports.cshtml"
using WebApp.Areas.Admin.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\N_3_HK_1\LT WEB ASP.NET core\DoAn\Project\WebApp\Views\_ViewImports.cshtml"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\N_3_HK_1\LT WEB ASP.NET core\DoAn\Project\WebApp\Views\_ViewImports.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\N_3_HK_1\LT WEB ASP.NET core\DoAn\Project\WebApp\Views\_ViewImports.cshtml"
using WebApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"402a0d20cd1f6cdd4bd62927ee1f29040aa6e13d", @"/Views/Home/IndexPost.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"819e68de9bbbc7d89a0314828859c43ca94fcae9", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_IndexPost : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WebApp.Controllers.HomeController.PostIndex>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("d-flex w-100"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Generic placeholder image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DetailPost", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("post-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\N_3_HK_1\LT WEB ASP.NET core\DoAn\Project\WebApp\Views\Home\IndexPost.cshtml"
   
    var listPost = ViewBag.ListCom as List<WebApp.Areas.Admin.Controllers.CommemtPostController>;

#line default
#line hidden
#nullable disable
            DefineSection("CSS", async() => {
                WriteLiteral("\r\n    <style>\r\n    ");
                WriteLiteral("@media (min-width: 992px) {\r\n        .home-blog {\r\n            padding-bottom: 100px;\r\n        }\r\n    }\r\n    .home-blog .section-title {\r\n        padding-bottom: 15px;\r\n    }\r\n    .home-blog .media {\r\n        margin-top: 50px;\r\n    }\r\n    ");
                WriteLiteral(@"@media (min-width: 768px) {
        .home-blog .media {
            margin-top: 30px;
        }
    }
    .bg-sand {
        background-color: #f5f5f6;
    }
    .media.blog-media {
        margin-top: 30px;
        position: relative;
        display: block;
    }
    ");
                WriteLiteral(@"@media (min-width: 992px) {
        .media.blog-media {
            display: table;
        }
    }
    .media.blog-media .circle {
        width: 70px;
        height: 70px;
        border-radius: 50%;
        background-color: rgba(0, 0, 0, 0.5);
        white-space: nowrap;
        position: absolute;
        padding: 0;
        top: 20px;
        left: 20px;
        text-align: center;
        box-shadow: none;
        transform: translateX(0);
        color: #fff;
        transition: background-color 0.3s ease;
    }
    .media.blog-media .circle .day {
        color: #fff;
        transition: color 0.25s ease;
        font-weight: 500;
        font-size: 28px;
        line-height: 1;
        margin-top: 12px;
    }
    .media.blog-media .circle .month {
        text-transform: uppercase;
        font-size: 14px;
    }
    .media.blog-media > a {
        position: relative;
        display: block;
    }
    ");
                WriteLiteral("@media (min-width: 992px) {\r\n        .media.blog-media > a {\r\n            display: table-cell;\r\n            vertical-align: top;\r\n            min-width: 200px;\r\n        }\r\n    }\r\n    ");
                WriteLiteral(@"@media (min-width: 1200px) {
        .media.blog-media > a {
            min-width: 230px;
        }
    }
 /*   .media.blog-media > a:before {
        position: absolute;
        content: """";
        top: 15px;
        left: 15px;
        right: 15px;
        bottom: 15px;
        opacity: 0;
        transform: scale(0);
        transition: transform 0.3s ease, opacity 0.3s;
        background: rgba(12, 198, 82, 0.7);
    }*/
    .media.blog-media > a img {
        width: 100%;
    }
    .media.blog-media:hover > a:before {
        opacity: 1;
        transform: scale(1);
    }
    .media.blog-media:hover .circle {
        background-color: rgba(255, 255, 255, 0.9);
    }
    .media.blog-media:hover .circle .day,
    .media.blog-media:hover .circle .month {
        color: #222;
    }
    .media.blog-media:hover .media-body h5 {
        color: #0cc652;
    }
    .media.blog-media:hover .media-body a.post-link {
        color: #0cc652;
        text-decoration: underline;
  ");
                WriteLiteral("  }\r\n    .media.blog-media .media-body {\r\n        border: 1px solid #efeff3;\r\n        padding: 30px 30px 10px;\r\n        font-size: 14px;\r\n        background: #fff;\r\n        border-top: none;\r\n    }\r\n    ");
                WriteLiteral(@"@media (min-width: 992px) {
        .media.blog-media .media-body {
            padding: 15px 20px 10px;
            border-top: 1px solid #efeff3;
            border-left: none;
            display: table-cell;
            vertical-align: top;
        }
    }
    ");
                WriteLiteral("@media (min-width: 1200px) {\r\n        .media.blog-media .media-body {\r\n            padding: 30px 20px 10px;\r\n        }\r\n    }\r\n    .media.blog-media .media-body h5 {\r\n        transition: color 0.3s ease;\r\n        margin-bottom: 15px;\r\n    }\r\n    ");
                WriteLiteral("@media (min-width: 992px) {\r\n        .media.blog-media .media-body h5 {\r\n            font-size: 15px;\r\n        }\r\n    }\r\n    ");
                WriteLiteral(@"@media (min-width: 1200px) {
        .media.blog-media .media-body h5 {
            margin-bottom: 15px;
            font-size: 18px;
        }
    }
    .media.blog-media .media-body a.post-link {
        display: block;
        color: #222;
        font-size: 11px;
        padding: 23px 0;
        text-transform: uppercase;
        font-weight: 400;
    }
    ");
                WriteLiteral("@media (min-width: 992px) {\r\n        .media.blog-media .media-body a.post-link {\r\n            padding: 7px 0;\r\n        }\r\n    }\r\n    ");
                WriteLiteral(@"@media (min-width: 1200px) {
        .media.blog-media .media-body a.post-link {
            padding: 23px 0;
        }
    }
    .media.blog-media .media-body ul {
        position: relative;
        padding: 10px 0 0;
    }
    .media.blog-media .media-body ul li {
        display: inline-block;
        width: 49%;
        position: relative;
    }
    .media.blog-media .media-body ul li:before {
        position: absolute;
        content: """";
        top: 5px;
        left: 0;
        width: 1px;
        height: 14px;
        background: #eeeef2;
    }
    .media.blog-media .media-body ul li:first-child:before {
        visibility: hidden;
    }
    .media.blog-media .media-body ul:before {
        position: absolute;
        content: """";
        top: 0;
        left: 0;
        width: 100%;
        height: 1px;
        background: #eeeef2;
    }
    </style>
");
            }
            );
            WriteLiteral("<section class=\"home-blog bg-sand\">\r\n    <div class=\"container\">\r\n        <!-- section title ends -->\r\n        <div class=\"row\" >\r\n");
#nullable restore
#line 203 "D:\N_3_HK_1\LT WEB ASP.NET core\DoAn\Project\WebApp\Views\Home\IndexPost.cshtml"
             foreach (var item in Model)
            {
                SelectList com = null;
                int comUn = 0;
                if (listPost != null)
                {
                     com = new SelectList(listPost, "idPost", "Content", item.idPost);
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"col-md-6\">\r\n                <div class=\"media blog-media\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "402a0d20cd1f6cdd4bd62927ee1f29040aa6e13d12127", async() => {
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "402a0d20cd1f6cdd4bd62927ee1f29040aa6e13d12344", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 5820, "~/Img//User/", 5820, 12, true);
#nullable restore
#line 213 "D:\N_3_HK_1\LT WEB ASP.NET core\DoAn\Project\WebApp\Views\Home\IndexPost.cshtml"
AddHtmlAttributeValue("", 5832, item.Img, 5832, 9, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 213 "D:\N_3_HK_1\LT WEB ASP.NET core\DoAn\Project\WebApp\Views\Home\IndexPost.cshtml"
                                                                       WriteLiteral(item.idPost);

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
            WriteLiteral("\r\n                    <div class=\"media-body w-100\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "402a0d20cd1f6cdd4bd62927ee1f29040aa6e13d16241", async() => {
                WriteLiteral("<h5 class=\"mt-0\">");
#nullable restore
#line 215 "D:\N_3_HK_1\LT WEB ASP.NET core\DoAn\Project\WebApp\Views\Home\IndexPost.cshtml"
                                                                                                                 Write(item.Title);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h5>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 215 "D:\N_3_HK_1\LT WEB ASP.NET core\DoAn\Project\WebApp\Views\Home\IndexPost.cshtml"
                                                                           WriteLiteral(item.idPost);

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
            WriteLiteral("\r\n                        ");
#nullable restore
#line 216 "D:\N_3_HK_1\LT WEB ASP.NET core\DoAn\Project\WebApp\Views\Home\IndexPost.cshtml"
                   Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "402a0d20cd1f6cdd4bd62927ee1f29040aa6e13d19276", async() => {
                WriteLiteral("Đọc ngay");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 217 "D:\N_3_HK_1\LT WEB ASP.NET core\DoAn\Project\WebApp\Views\Home\IndexPost.cshtml"
                                                                           WriteLiteral(item.idPost);

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
            WriteLiteral("\r\n                        <ul>\r\n                            <li>by: ");
#nullable restore
#line 219 "D:\N_3_HK_1\LT WEB ASP.NET core\DoAn\Project\WebApp\Views\Home\IndexPost.cshtml"
                               Write(item.roles);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                            <li class=\"text-right\"><a href=\"blog-post-left-sidebar.html\">\r\n");
#nullable restore
#line 221 "D:\N_3_HK_1\LT WEB ASP.NET core\DoAn\Project\WebApp\Views\Home\IndexPost.cshtml"
                                 if (com != null)
                                {
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 223 "D:\N_3_HK_1\LT WEB ASP.NET core\DoAn\Project\WebApp\Views\Home\IndexPost.cshtml"
                               Write(com.Count());

#line default
#line hidden
#nullable disable
#nullable restore
#line 223 "D:\N_3_HK_1\LT WEB ASP.NET core\DoAn\Project\WebApp\Views\Home\IndexPost.cshtml"
                                                
                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 225 "D:\N_3_HK_1\LT WEB ASP.NET core\DoAn\Project\WebApp\Views\Home\IndexPost.cshtml"
                                 if (com == null) { 

#line default
#line hidden
#nullable disable
#nullable restore
#line 225 "D:\N_3_HK_1\LT WEB ASP.NET core\DoAn\Project\WebApp\Views\Home\IndexPost.cshtml"
                                               Write(comUn);

#line default
#line hidden
#nullable disable
#nullable restore
#line 225 "D:\N_3_HK_1\LT WEB ASP.NET core\DoAn\Project\WebApp\Views\Home\IndexPost.cshtml"
                                                           }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                comments</a></li>\r\n\r\n                       </ul>\r\n\r\n                   </div>\r\n\r\n               </div>\r\n\r\n           </div>\r\n");
#nullable restore
#line 235 "D:\N_3_HK_1\LT WEB ASP.NET core\DoAn\Project\WebApp\Views\Home\IndexPost.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WebApp.Controllers.HomeController.PostIndex>> Html { get; private set; }
    }
}
#pragma warning restore 1591
