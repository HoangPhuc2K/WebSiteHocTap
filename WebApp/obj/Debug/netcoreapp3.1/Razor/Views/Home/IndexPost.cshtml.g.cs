#pragma checksum "D:\N_3_HK_1\LT WEB ASP.NET core\DoAn\Project\WebApp\Views\Home\IndexPost.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6f1661e416a69404e34cde14545eb1612902802b"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6f1661e416a69404e34cde14545eb1612902802b", @"/Views/Home/IndexPost.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"819e68de9bbbc7d89a0314828859c43ca94fcae9", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_IndexPost : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
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
    .media.blog-media > a:before {
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
    }
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
    }
                WriteLiteral("\n    .media.blog-media .media-body {\r\n        border: 1px solid #efeff3;\r\n        padding: 30px 30px 10px;\r\n        font-size: 14px;\r\n        background: #fff;\r\n        border-top: none;\r\n    }\r\n    ");
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
            WriteLiteral(@"<section class=""home-blog bg-sand"">
    <div class=""container"">
        <!-- section title ends -->
        <div class=""row "">
            <div class=""col-md-6"">
                <div class=""media blog-media"">
                    <a href=""blog-post-left-sidebar.html""><img class=""d-flex"" src=""https://via.placeholder.com/350x380/6495ED/000000"" alt=""Generic placeholder image""></a>
                    <div class=""media-body"">
                        <a");
            BeginWriteAttribute("href", " href=\"", 5465, "\"", 5472, 0);
            EndWriteAttribute();
            WriteLiteral(@"><h5 class=""mt-0"">Standard Blog Post</h5></a>
                        Sodales aliquid, in eget ac cupidatat velit autem numquam ullam ducimus occaecati placeat error.
                        <a href=""blog-post-left-sidebar.html"" class=""post-link"">Read More</a>
                        <ul>
                            <li>by: Admin</li>
                            <li class=""text-right""><a href=""blog-post-left-sidebar.html"">07 comments</a></li>
                        </ul>
                    </div>
                </div>
            </div>
            <div class=""col-md-6"">
                <div class=""media blog-media"">
                    <a href=""blog-post-left-sidebar.html""><img class=""d-flex"" src=""https://via.placeholder.com/350x380/FFB6C1/000000"" alt=""Generic placeholder image""></a>
                    <div class=""media-body"">
                        <a");
            BeginWriteAttribute("href", " href=\"", 6357, "\"", 6364, 0);
            EndWriteAttribute();
            WriteLiteral(@"><h5 class=""mt-0"">perferendis labore</h5></a>
                        Sodales aliquid, in eget ac cupidatat velit autem numquam ullam ducimus occaecati placeat error.
                        <a href=""blog-post-left-sidebar.html"" class=""post-link"">Read More</a>
                        <ul>
                            <li>by: Admin</li>
                            <li class=""text-right""><a href=""blog-post-left-sidebar.html"">04 comments</a></li>
                        </ul>
                    </div>
                </div>
            </div>
            <div class=""col-md-6"">
                <div class=""media blog-media"">
                    <a href=""blog-post-left-sidebar.html""><img class=""d-flex"" src=""https://via.placeholder.com/350x380/FF7F50/000000"" alt=""Generic placeholder image""></a>
                    <div class=""media-body"">
                        <a");
            BeginWriteAttribute("href", " href=\"", 7249, "\"", 7256, 0);
            EndWriteAttribute();
            WriteLiteral(@"><h5 class=""mt-0"">deleniti incdunt magni</h5></a>
                        Sodales aliquid, in eget ac cupidatat velit autem numquam ullam ducimus occaecati placeat error.
                        <a href=""blog-post-left-sidebar.html"" class=""post-link"">Read More</a>
                        <ul>
                            <li>by: Admin</li>
                            <li class=""text-right""><a href=""blog-post-left-sidebar.html"">10 comments</a></li>
                        </ul>
                    </div>
                </div>
            </div>
            <div class=""col-md-6"">
                <div class=""media blog-media"">
                    <a href=""blog-post-left-sidebar.html""><img class=""d-flex"" src=""https://via.placeholder.com/350x380/008B8B/000000"" alt=""Generic placeholder image""></a>
                    <div class=""circle"">
                        <h5 class=""day"">04</h5>
                        <span class=""month"">sep</span>
                    </div>
                    <div class=""m");
            WriteLiteral("edia-body\">\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 8320, "\"", 8327, 0);
            EndWriteAttribute();
            WriteLiteral(@"><h5 class=""mt-0"">Explicabo magnam </h5></a>
                        Sodales aliquid, in eget ac cupidatat velit autem numquam ullam ducimus occaecati placeat error.
                        <a href=""blog-post-left-sidebar.html"" class=""post-link"">Read More</a>
                        <ul>
                            <li>by: Admin</li>
                            <li class=""text-right""><a href=""blog-post-left-sidebar.html"">06 comments</a></li>
                        </ul>
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>");
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