#pragma checksum "D:\N_3_HK_1\LT WEB ASP.NET core\DoAn\WebSiteHocTap\WebApp\Areas\Admin\Views\CommemtPost\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c320405cc37c732ad99959e6ac01614e62027306"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_CommemtPost_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/CommemtPost/Index.cshtml")]
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
#line 1 "D:\N_3_HK_1\LT WEB ASP.NET core\DoAn\WebSiteHocTap\WebApp\Areas\Admin\Views\_ViewImports.cshtml"
using WebApp.Areas.Admin.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c320405cc37c732ad99959e6ac01614e62027306", @"/Areas/Admin/Views/CommemtPost/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"157a527780a79be07ea5f9836751adb2bedf89d1", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_CommemtPost_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WebApp.Areas.Admin.Models.CommemtPostModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\N_3_HK_1\LT WEB ASP.NET core\DoAn\WebSiteHocTap\WebApp\Areas\Admin\Views\CommemtPost\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div id=\"view-all\">\r\n    ");
#nullable restore
#line 8 "D:\N_3_HK_1\LT WEB ASP.NET core\DoAn\WebSiteHocTap\WebApp\Areas\Admin\Views\CommemtPost\Index.cshtml"
Write(await Html.PartialAsync("_ViewAll.cshtml", Model));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WebApp.Areas.Admin.Models.CommemtPostModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
