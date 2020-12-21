#pragma checksum "D:\N_3_HK_1\LT WEB ASP.NET core\DoAn\Project\WebApp\Views\Home\IndexCourse.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "527df997277e460491e5b42af78e114ca9ce25bc"
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
#line 1 "D:\N_3_HK_1\LT WEB ASP.NET core\DoAn\Project\WebApp\Views\_ViewImports.cshtml"
using WebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\N_3_HK_1\LT WEB ASP.NET core\DoAn\Project\WebApp\Views\_ViewImports.cshtml"
using WebApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"527df997277e460491e5b42af78e114ca9ce25bc", @"/Views/Home/IndexCourse.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fc48f17eb9bac3476d8060730298bf398eb2fa5e", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_IndexCourse : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "D:\N_3_HK_1\LT WEB ASP.NET core\DoAn\Project\WebApp\Views\Home\IndexCourse.cshtml"
  
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
#line 200 "D:\N_3_HK_1\LT WEB ASP.NET core\DoAn\Project\WebApp\Views\Home\IndexCourse.cshtml"
     for (int i = 0; i < 6; i++)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""col-4"">
        <section class=""cards-wrapper"">
            <div class=""card-grid-space w-50"">
                <a class=""card w-75 h-75"" href=""https://codetheweb.blog/2017/10/06/html-syntax/"" style=""--bg-img: url(https://images1-focus-opensocial.googleusercontent.com/gadgets/proxy?container=focus&resize_w=1500&url=https://codetheweb.blog/assets/img/posts/html-syntax/cover.jpg)"">
                    <div>
                        <h1>HTML Syntax</h1>
                        <p>The syntax of a language is how it works. How to actually write it. Learn HTML syntax…</p>
                        <div class=""date"">6 Oct 2017</div>
                        <div class=""tags"">
                            <div class=""tag"">HTML</div>
                        </div>
                    </div>
                </a>
            </div>
            <!-- https://images.unsplash.com/photo-1520839090488-4a6c211e2f94?ixlib=rb-0.3.5&ixid=eyJhcHBfaWQiOjEyMDd9&s=38951b8650067840307cba514b554ba5&auto=format&f");
            WriteLiteral("it=crop&w=1350&q=80 -->\r\n        </section>\r\n    </div>");
#nullable restore
#line 218 "D:\N_3_HK_1\LT WEB ASP.NET core\DoAn\Project\WebApp\Views\Home\IndexCourse.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
