#pragma checksum "C:\D\asp\WebSiteHocTap\WebApp\Views\Shared\_MenuPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7f91d08101d61b192254758da4e4cbafd0207e4d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__MenuPartial), @"mvc.1.0.view", @"/Views/Shared/_MenuPartial.cshtml")]
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
#line 1 "C:\D\asp\WebSiteHocTap\WebApp\Views\_ViewImports.cshtml"
using WebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\D\asp\WebSiteHocTap\WebApp\Views\_ViewImports.cshtml"
using WebApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7f91d08101d61b192254758da4e4cbafd0207e4d", @"/Views/Shared/_MenuPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fc48f17eb9bac3476d8060730298bf398eb2fa5e", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__MenuPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<ul class="" navbar-nav slide bg-dark sidebar sidebar-dark accordion"" id=""accordionSidebar"" style=""z-index: 1000"">

    <!-- Sidebar - Brand -->
    <a class=""sidebar-brand d-flex align-items-center justify-content-center"" href=""#l"">
        <div class=""sidebar-brand-icon rotate-n-15"">
            <i class=""fas fa-laugh-wink""></i>
        </div>
        <div class=""sidebar-brand-text mx-3"">404 Not Found <sup>2</sup></div>
    </a>

    <!-- Heading -->
    <div class=""sidebar-heading"">
        Hoạt động
    </div>

    <!-- Nav Item - Pages Collapse Menu -->
    <li class=""nav-item"">
        <a class=""nav-link collapsed"" href=""#"" data-target=""#collapseTwo"" aria-expanded=""true"" aria-controls=""collapseTwo"">
            <i class=""fas fa-clock""></i>
            <span>Lịch sử</span>
        </a>
    </li>

    <!-- Nav Item - Utilities Collapse Menu -->
    <li class=""nav-item"">
        <a class=""nav-link collapsed"" href=""#"" data-target=""#collapseUtilities"" aria-expanded=""true"" aria-contr");
            WriteLiteral(@"ols=""collapseUtilities"">
            <i class=""far fa-bookmark""></i>
            <span>Đã lưu</span>
        </a>
    </li>

    <!-- Divider -->
    <hr class=""sidebar-divider"">

    <!-- Heading -->
    <div class=""sidebar-heading"">
        Trang
    </div>

    <!-- Nav Item - menu khoahoc -->
    <li class=""nav-item"">
        <a class=""nav-link"" href=""#"" data-toggle=""collapse"" data-target=""#collapsePages"" aria-expanded=""true"" aria-controls=""collapsePages"">
            <i class=""fas fa-book-open""></i>
            <span>Khóa học</span>
        </a>
        <div id=""collapsePages"" class=""collapse"" aria-labelledby=""headingPages"" data-parent=""#accordionSidebar"">
            <div class=""bg-white py-2 collapse-inner rounded"">
                <h6 class=""collapse-header"">Lập trình:</h6>
                <a class=""collapse-item"" href=""#"">Lập trình Android</a>
                <a class=""collapse-item"" href=""#"">Lập trình C++</a>
                <a class=""collapse-item"" href=""#"">Lập trình C# .Ne");
            WriteLiteral(@"t</a>
                <a class=""collapse-item"" href=""#"">Lập trình Java</a>
                <a class=""collapse-item"" href=""#"">Unity3D</a>

                <div class=""collapse-divider""></div>
                <h6 class=""collapse-header"">Văn phòng:</h6>
                <a class=""collapse-item"" href=""#"">Microsoft Word 2016</a>
                <a class=""collapse-item"" href=""#"">Microsoft Excel 2016</a>
                <a class=""collapse-item"" href=""#"">Microsoft PowerPoint 2016</a>
            </div>
        </div>

");
            WriteLiteral(@"
    <!-- Nav Item - baiviet -->
    <li class=""nav-item"">
        <a class=""nav-link"" href=""#"">
            <i class=""far fa-newspaper""></i>
            <span>Bài viết</span>
        </a>
    </li>

    <!-- Nav Item - Tag -->
    <li class=""nav-item"">
        <a class=""nav-link"" href=""#"">
            <i class=""fas fa-tag""></i>
            <span>Tag</span>
        </a>
    </li>

    <!-- Nav Item - hoidap -->
    <li class=""nav-item"">
        <a class=""nav-link"" href=""#"">
            <i class=""fas fa-question""></i>
            <span>Hỏi đáp</span>
        </a>
    </li>

    <!-- Nav Item - tai tro -->
    <li class=""nav-item"">
        <a class=""nav-link"" href=""#"">
            <i class=""fas fa-mug-hot""></i>
            <span>Tài trợ</span>
        </a>
    </li>

    <!-- Nav Item - thongtinKteam -->
    <li class=""nav-item"">
        <a class=""nav-link"" href=""#"">
            <i class=""fas fa-info-circle""></i>
            <span>Về 404</span>
        </a>
    </li>


");
            WriteLiteral(@"    <!-- Divider -->
    <hr class=""sidebar-divider d-none d-md-block"">

    <!-- Sidebar Toggler (Sidebar) -->
    <div class=""text-center d-none d-md-inline"">
        <button class=""rounded-circle border-0"" id=""sidebarToggle""></button>
    </div>

</ul>
");
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
