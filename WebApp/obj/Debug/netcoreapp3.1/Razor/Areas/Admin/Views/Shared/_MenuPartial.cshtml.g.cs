#pragma checksum "E:\Do an\DoAnAspNet\WebSiteHocTap\WebApp\Areas\Admin\Views\Shared\_MenuPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e75e1bce5af1c03460b4d3eb2d52a726815118f7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Shared__MenuPartial), @"mvc.1.0.view", @"/Areas/Admin/Views/Shared/_MenuPartial.cshtml")]
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
#line 1 "E:\Do an\DoAnAspNet\WebSiteHocTap\WebApp\Areas\Admin\Views\_ViewImports.cshtml"
using WebApp.Areas.Admin.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e75e1bce5af1c03460b4d3eb2d52a726815118f7", @"/Areas/Admin/Views/Shared/_MenuPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"157a527780a79be07ea5f9836751adb2bedf89d1", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Shared__MenuPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("collapse-item"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Course", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Lesson", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "User", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Student", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Roles", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 2 "E:\Do an\DoAnAspNet\WebSiteHocTap\WebApp\Areas\Admin\Views\Shared\_MenuPartial.cshtml"
   
    var ID = Context.User.Claims.ToList()[2].Value;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<ul class=""navbar-nav bg-gradient-primary sidebar sidebar-dark accordion"" id=""accordionSidebar"">

    <!-- Sidebar - Brand -->
    <a class=""sidebar-brand d-flex align-items-center justify-content-center"" href=""index.html"">
        <div class=""sidebar-brand-icon rotate-n-15"">
            <i class=""fas fa-laugh-wink""></i>
        </div>
        <div class=""sidebar-brand-text mx-3""> Admin Web </div>
    </a>

    <!-- Divider -->
    <hr class=""sidebar-divider my-0"">

    <!-- Nav Item - Dashboard -->
    <li class=""nav-item"">
        <a class=""nav-link""");
            BeginWriteAttribute("href", " href=\"", 636, "\"", 643, 0);
            EndWriteAttribute();
            WriteLiteral(@">
            <i class=""fas fa-fw fa-tachometer-alt""></i>
            <span>Chức Năng</span>
        </a>
    </li>

    <!-- Divider -->
    <hr class=""sidebar-divider"">

    <!-- Heading -->
    <div class=""sidebar-heading"">
        Interface
    </div>

    <!-- Nav Item - Pages Collapse Menu -->
");
#nullable restore
#line 35 "E:\Do an\DoAnAspNet\WebSiteHocTap\WebApp\Areas\Admin\Views\Shared\_MenuPartial.cshtml"
     if (Context.User.IsInRole("Admin"))
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <li class=""nav-item"">
            <a class=""nav-link collapsed"" href=""#"" data-toggle=""collapse"" data-target=""#collapseTwo"" aria-expanded=""true"" aria-controls=""collapseTwo"">
                <i class=""fas fa-fw fa-cog""></i>
                <span>Quản Lý Khoá Học</span>
            </a>
            <div id=""collapseTwo"" class=""collapse"" aria-labelledby=""headingTwo"" data-parent=""#accordionSidebar"">
                <div class=""bg-white py-2 collapse-inner rounded"">
                    <h6 class=""collapse-header"">Chức Năng</h6>
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e75e1bce5af1c03460b4d3eb2d52a726815118f77622", async() => {
                WriteLiteral("Danh Sách Khoá Học");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                </div>
            </div>
        </li>
        <li class=""nav-item"">
            <a class=""nav-link collapsed"" href=""#"" data-toggle=""collapse"" data-target=""#collapseTwo1"" aria-expanded=""true"" aria-controls=""collapseTwo"">
                <i class=""fas fa-fw fa-cog""></i>
                <span>Quản Lý Bài Giảng</span>
            </a>
            <div id=""collapseTwo1"" class=""collapse"" aria-labelledby=""headingTwo"" data-parent=""#accordionSidebar"">
                <div class=""bg-white py-2 collapse-inner rounded"">
                    <h6 class=""collapse-header"">Chức Năng</h6>
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e75e1bce5af1c03460b4d3eb2d52a726815118f79731", async() => {
                WriteLiteral("Danh Sách Bài Giảng");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                </div>
            </div>
        </li>
        <li class=""nav-item"">
            <a class=""nav-link collapsed"" href=""#"" data-toggle=""collapse"" data-target=""#collapseTwo2"" aria-expanded=""true"" aria-controls=""collapseTwo"">
                <i class=""fas fa-fw fa-cog""></i>
                <span>Quản Lý Tài Khoản</span>
            </a>
            <div id=""collapseTwo2"" class=""collapse"" aria-labelledby=""headingTwo"" data-parent=""#accordionSidebar"">
                <div class=""bg-white py-2 collapse-inner rounded"">
                    <h6 class=""collapse-header"">Chức Năng</h6>
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e75e1bce5af1c03460b4d3eb2d52a726815118f711841", async() => {
                WriteLiteral("Danh Sách Tài Khoản");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                </div>
            </div>
        </li>
        <li class=""nav-item"">
            <a class=""nav-link collapsed"" href=""#"" data-toggle=""collapse"" data-target=""#collapseTwo3"" aria-expanded=""true"" aria-controls=""collapseTwo"">
                <i class=""fas fa-fw fa-cog""></i>
                <span>Quản Lý Bài Viết</span>
            </a>
            <div id=""collapseTwo3"" class=""collapse"" aria-labelledby=""headingTwo"" data-parent=""#accordionSidebar"">
                <div class=""bg-white py-2 collapse-inner rounded"">
                    <h6 class=""collapse-header"">Chức Năng</h6>
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e75e1bce5af1c03460b4d3eb2d52a726815118f713951", async() => {
                WriteLiteral("Danh Sách Bài Viết");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                </div>
            </div>
        </li>
        <li class=""nav-item"">
            <a class=""nav-link collapsed"" href=""#"" data-toggle=""collapse"" data-target=""#collapseTwo4"" aria-expanded=""true"" aria-controls=""collapseTwo"">
                <i class=""fas fa-fw fa-cog""></i>
                <span>Quản Lý Học Viên</span>
            </a>
            <div id=""collapseTwo4"" class=""collapse"" aria-labelledby=""headingTwo"" data-parent=""#accordionSidebar"">
                <div class=""bg-white py-2 collapse-inner rounded"">
                    <h6 class=""collapse-header"">Chức Năng</h6>
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e75e1bce5af1c03460b4d3eb2d52a726815118f716060", async() => {
                WriteLiteral("Danh Sách Học Viên");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                </div>
            </div>
        </li>
        <li class=""nav-item"">
            <a class=""nav-link collapsed"" href=""#"" data-toggle=""collapse"" data-target=""#collapseTwo5"" aria-expanded=""true"" aria-controls=""collapseTwo"">
                <i class=""fas fa-fw fa-cog""></i>
                <span>Quản Lý Quyền</span>
            </a>
            <div id=""collapseTwo5"" class=""collapse"" aria-labelledby=""headingTwo"" data-parent=""#accordionSidebar"">
                <div class=""bg-white py-2 collapse-inner rounded"">
                    <h6 class=""collapse-header"">Chức Năng</h6>
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e75e1bce5af1c03460b4d3eb2d52a726815118f718166", async() => {
                WriteLiteral("Danh Sách Quyền");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </li>\r\n");
#nullable restore
#line 109 "E:\Do an\DoAnAspNet\WebSiteHocTap\WebApp\Areas\Admin\Views\Shared\_MenuPartial.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 110 "E:\Do an\DoAnAspNet\WebSiteHocTap\WebApp\Areas\Admin\Views\Shared\_MenuPartial.cshtml"
     if (Context.User.IsInRole("Coach"))
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <li class=""nav-item"">
            <a class=""nav-link collapsed"" href=""#"" data-toggle=""collapse"" data-target=""#collapseTwo"" aria-expanded=""true"" aria-controls=""collapseTwo"">
                <i class=""fas fa-fw fa-cog""></i>
                <span>Quản Lý Khoá Học</span>
            </a>
            <div id=""collapseTwo"" class=""collapse"" aria-labelledby=""headingTwo"" data-parent=""#accordionSidebar"">
                <div class=""bg-white py-2 collapse-inner rounded"">
                    <h6 class=""collapse-header"">Chức Năng</h6>
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e75e1bce5af1c03460b4d3eb2d52a726815118f720701", async() => {
                WriteLiteral("Danh Sách Khoá Học");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 120 "E:\Do an\DoAnAspNet\WebSiteHocTap\WebApp\Areas\Admin\Views\Shared\_MenuPartial.cshtml"
                                                                                          WriteLiteral(ID);

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
            WriteLiteral(@"
                </div>
            </div>
        </li>
        <li class=""nav-item"">
            <a class=""nav-link collapsed"" href=""#"" data-toggle=""collapse"" data-target=""#collapseTwo1"" aria-expanded=""true"" aria-controls=""collapseTwo"">
                <i class=""fas fa-fw fa-cog""></i>
                <span>Quản Lý Bài Giảng</span>
            </a>
            <div id=""collapseTwo1"" class=""collapse"" aria-labelledby=""headingTwo"" data-parent=""#accordionSidebar"">
                <div class=""bg-white py-2 collapse-inner rounded"">
                    <h6 class=""collapse-header"">Chức Năng</h6>
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e75e1bce5af1c03460b4d3eb2d52a726815118f723858", async() => {
                WriteLiteral("Danh Sách Bài Giảng");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 132 "E:\Do an\DoAnAspNet\WebSiteHocTap\WebApp\Areas\Admin\Views\Shared\_MenuPartial.cshtml"
                                                                                          WriteLiteral(ID);

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
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </li>\r\n");
#nullable restore
#line 136 "E:\Do an\DoAnAspNet\WebSiteHocTap\WebApp\Areas\Admin\Views\Shared\_MenuPartial.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 137 "E:\Do an\DoAnAspNet\WebSiteHocTap\WebApp\Areas\Admin\Views\Shared\_MenuPartial.cshtml"
     if (Context.User.IsInRole("AdminForum"))
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <li class=""nav-item"">
            <a class=""nav-link collapsed"" href=""#"" data-toggle=""collapse"" data-target=""#collapseTwo3"" aria-expanded=""true"" aria-controls=""collapseTwo"">
                <i class=""fas fa-fw fa-cog""></i>
                <span>Quản Lý Bài Viết</span>
            </a>
            <div id=""collapseTwo3"" class=""collapse"" aria-labelledby=""headingTwo"" data-parent=""#accordionSidebar"">
                <div class=""bg-white py-2 collapse-inner rounded"">
                    <h6 class=""collapse-header"">Chức Năng</h6>
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e75e1bce5af1c03460b4d3eb2d52a726815118f727451", async() => {
                WriteLiteral("Danh Sách Bài Viết");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </li>\r\n");
#nullable restore
#line 151 "E:\Do an\DoAnAspNet\WebSiteHocTap\WebApp\Areas\Admin\Views\Shared\_MenuPartial.cshtml"
     }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    <!-- Divider -->
    <hr class=""sidebar-divider"">

    <!-- Heading -->
    <div class=""sidebar-heading"">
        Addons
    </div>

    <!-- Nav Item - Pages Collapse Menu -->
    <li class=""nav-item"">
        <a class=""nav-link"" href=""#"" data-toggle=""collapse"" data-target=""#collapsePages"" aria-expanded=""true"" aria-controls=""collapsePages"">
            <i class=""fas fa-fw fa-folder""></i>
            <span>Pages</span>
        </a>
        <div id=""collapsePages"" class=""collapse"" aria-labelledby=""headingPages"" data-parent=""#accordionSidebar"">
            <div class=""bg-white py-2 collapse-inner rounded"">
                <h6 class=""collapse-header"">Login Screens:</h6>
                <a class=""collapse-item""");
            BeginWriteAttribute("href", " href=\"", 8354, "\"", 8361, 0);
            EndWriteAttribute();
            WriteLiteral(">Login</a>\r\n                <a class=\"collapse-item\"");
            BeginWriteAttribute("href", " href=\"", 8414, "\"", 8421, 0);
            EndWriteAttribute();
            WriteLiteral(">Register</a>\r\n                <a class=\"collapse-item\"");
            BeginWriteAttribute("href", " href=\"", 8477, "\"", 8484, 0);
            EndWriteAttribute();
            WriteLiteral(">Forgot Password</a>\r\n                <div class=\"collapse-divider\"></div>\r\n                <h6 class=\"collapse-header\">Other Pages:</h6>\r\n                <a class=\"collapse-item\"");
            BeginWriteAttribute("href", " href=\"", 8664, "\"", 8671, 0);
            EndWriteAttribute();
            WriteLiteral(">404 Page</a>\r\n                <a class=\"collapse-item\"");
            BeginWriteAttribute("href", " href=\"", 8727, "\"", 8734, 0);
            EndWriteAttribute();
            WriteLiteral(@">Blank Page</a>
            </div>
        </div>
    </li>

    <!-- Nav Item - Charts -->
    <li class=""nav-item"">
        <a class=""nav-link"" href=""charts.html"">
            <i class=""fas fa-fw fa-chart-area""></i>
            <span>Charts</span>
        </a>
    </li>

    <!-- Nav Item - Tables -->
    <li class=""nav-item"">
        <a class=""nav-link"" href=""tables.html"">
            <i class=""fas fa-fw fa-table""></i>
            <span>Tables</span>
        </a>
    </li>

    <!-- Divider -->
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
